using System;
using System.Net.NetworkInformation;
using System.Threading;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace Community_Task_Management_System
{
    public partial class AddTaskForm : KryptonForm
    {
        string databaseAddress = "server=localhost; database=barangay_task_management_system; username=root; password=;";
        MySqlCommand command;
        TasksTab tasksTab;
        DashboardTab dashboardTab;
        TasksTab.Task task;
        ProjectsTab projectsTab;
        bool forEditing;

        string taskName;
        string projectName;
        DateTime dueDate;
        string description;

        public AddTaskForm(TasksTab tasksTab, DashboardTab dashboardTab, bool forEditing = false, ProjectsTab projectsTab = null, TasksTab.Task task = null)
        {
            InitializeComponent();
            this.tasksTab = tasksTab;
            this.dashboardTab = dashboardTab;
            this.forEditing = forEditing;
            this.task = task;
            this.projectsTab = projectsTab;
            if (forEditing)
            {
                AddNewTaskButton.Text = "Update Task";
                AddTaskLabel.Text = "Edit Task";
                using (MySqlConnection connection = new MySqlConnection(databaseAddress))
                {
                    connection.Open();
                    string GET_TASK_DATA = $"SELECT * FROM tasks WHERE id='{task.id}'";
                    using (MySqlCommand command = new MySqlCommand(GET_TASK_DATA, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            reader.Read();
                            taskName = reader["name"].ToString();
                            projectName = GetProjectName();
                            description = reader["description"].ToString();
                            dueDate = DateTime.Parse(GetDueDate(projectName, "TO_FORM"));

                            TaskNameTextbox.Text = taskName;
                            TaskDescriptionTextbox.Text = description;
                        }
                    }
                }
            }
            using (MySqlConnection connection = new MySqlConnection(databaseAddress))
            {
                connection.Open();
                string GET_PROJECT_DATA = "SELECT * FROM projectS";
                StoreCommand(GET_PROJECT_DATA, connection);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string projectName = reader["name"].ToString();

                        ProjectComboBox.Items.Add(projectName);
                    }
                    reader.Close();
                }
                connection.Close();
            }
        }

        private string GetProjectName()
        {
            using (MySqlConnection connection = new MySqlConnection(databaseAddress))
            {
                connection.Open();
                string GET_PROJECT_NAME = $"SELECT name FROM projects WHERE id = '{task.projectId}'";
                using (MySqlCommand command = new MySqlCommand(GET_PROJECT_NAME, connection))
                {
                    string projectName = command.ExecuteScalar().ToString();
                    return projectName;
                }
            }
        }
        #region GENERAL CODE


        private void StoreCommand(string query, MySqlConnection connection)
        {
            command = new MySqlCommand(query, connection);
        }
        #endregion

        private void TaskDescriptionTextbox_TextChanged(object sender, EventArgs e)
        {
            TextCountLabel.Text = $"{TaskDescriptionTextbox.Text.Length}/300";
        }

        private void AddNewTaskButton_Click(object sender, EventArgs e)
        {
            if (forEditing)
            {
                if (string.IsNullOrWhiteSpace(TaskNameTextbox.Text) ||
                    string.IsNullOrWhiteSpace(ProjectComboBox.Text))
                {
                    MessageBox.Show("Please fill up all fields", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    using (MySqlConnection connection = new MySqlConnection(databaseAddress))
                    {
                        connection.Open();
                        string CHECK_TASK_NAME = "UPDATE tasks SET project_id=@projectId, name=@name, due_date=@dueDate, description=@description";
                        StoreCommand(CHECK_TASK_NAME, connection);
                        command.Parameters.AddWithValue("@projectId", GetProjectID(ProjectComboBox.Text));
                        command.Parameters.AddWithValue("@name", TaskNameTextbox.Text);
                        command.Parameters.AddWithValue("@description", TaskDescriptionTextbox.Text);
                        command.Parameters.AddWithValue("@dueDate", GetDueDate(ProjectComboBox.Text, "TO_DATABASE"));

                        int rowsAffected = Convert.ToInt32(command.ExecuteNonQuery());
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Task successfully updated to Project {ProjectComboBox.Text}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Updating the Task
                            TasksTab.Task tasksTask = tasksTab.tasksList.Find(task => task.id == this.task.id);
                            tasksTask.name = TaskNameTextbox.Text;
                            tasksTask.description = TaskDescriptionTextbox.Text;
                            tasksTask.projectId = GetProjectID(ProjectComboBox.Text);
                            tasksTask.dueDate = DateTime.Parse(DueDateButton.Text);
                            tasksTab.RefreshPanels();
                            tasksTab.RefreshPanels();

                            int dashboardTaskCount = dashboardTab.GetProjectTotalTasks(task.projectId);
                            DashboardTab.Project dashboardProject = dashboardTab.projectList.Find(project => project.id == task.projectId);
                            dashboardProject.taskCount = dashboardTaskCount;
                            dashboardProject.progress = dashboardTab.GetProjectProgress(dashboardProject.taskCount, task.projectId);
                            dashboardTab.RefreshDashboardPanel();

                            int projectTaskCount = dashboardTab.GetProjectTotalTasks(task.projectId);
                            ProjectsTab.Project projectsProject = projectsTab.projectsList.Find(project => project.id == task.projectId);
                            projectsProject.totalTasks = projectTaskCount;
                            projectsProject.progress = dashboardTab.GetProjectProgress(dashboardProject.taskCount, task.projectId);
                            projectsTab.RefreshProjectsPanel();

                            connection.Close();
                            Close();
                        }
                    }
                }
                return;
            }
            using (MySqlConnection connection = new MySqlConnection(databaseAddress))
            {
                if (string.IsNullOrWhiteSpace(TaskNameTextbox.Text) ||
                    string.IsNullOrWhiteSpace(ProjectComboBox.Text))
                {
                    MessageBox.Show("Please fill up all fields", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    connection.Open();
                    string CHECK_TASK_NAME = "SELECT * FROM tasks WHERE name=@name AND project_id=@projectId";
                    StoreCommand(CHECK_TASK_NAME, connection);
                    command.Parameters.AddWithValue("@projectId", GetProjectID(ProjectComboBox.Text));
                    command.Parameters.AddWithValue("@name", TaskNameTextbox.Text);

                    int matchRecord = Convert.ToInt32(command.ExecuteScalar());
                    if (matchRecord > 0)
                    {
                        MessageBox.Show("Task name already exists in the Project", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        command.Parameters.Clear();
                        string INSERT_TASK = "INSERT INTO tasks (project_id, name, description, due_date, status) VALUES (@projectId, @name, @description, @dueDate, @status)";
                        StoreCommand(INSERT_TASK, connection);
                        command.Parameters.AddWithValue("@projectId", GetProjectID(ProjectComboBox.Text));
                        command.Parameters.AddWithValue("@name", TaskNameTextbox.Text);
                        command.Parameters.AddWithValue("@description", TaskDescriptionTextbox.Text);
                        command.Parameters.AddWithValue("@dueDate", GetDueDate(ProjectComboBox.Text, "TO_DATABASE"));
                        command.Parameters.AddWithValue("@status", "Pending");

                        int rowsAffected = Convert.ToInt32(command.ExecuteNonQuery());
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show($"Task successfully added to Project {ProjectComboBox.Text}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AddNewTask();

                            int dashboardTaskCount = dashboardTab.GetProjectTotalTasks(projectId);
                            DashboardTab.Project dashboardProject = dashboardTab.projectList.Find(project => project.id == projectId);
                            dashboardProject.taskCount = dashboardTaskCount;
                            dashboardProject.progress = dashboardTab.GetProjectProgress(dashboardProject.taskCount, projectId);
                            dashboardTab.RefreshDashboardPanel();
                            dashboardTab.RefreshDashboardPanel();

                            int projectTaskCount = dashboardTab.GetProjectTotalTasks(projectId);
                            ProjectsTab.Project projectsProject = projectsTab.projectsList.Find(project => project.id == projectId);
                            projectsProject.totalTasks = projectTaskCount;
                            projectsProject.progress = dashboardTab.GetProjectProgress(dashboardProject.taskCount, projectId);
                            projectsTab.RefreshProjectsPanel();
                            projectsTab.RefreshProjectsPanel();
                        }

                        connection.Close();
                        Close();
                    }
                }
            }
        }

        string projectId;
        private void AddNewTask()
        {
            using (MySqlConnection connection = new MySqlConnection(databaseAddress))
            {
                connection.Open();
                string GET_ADDED_TASK_DATA = $"SELECT * FROM tasks WHERE name='{TaskNameTextbox.Text}' AND project_id='{GetProjectID(ProjectComboBox.Text)}'";
                using (MySqlCommand command = new MySqlCommand(GET_ADDED_TASK_DATA, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        reader.Read();
                        projectId = reader["project_id"].ToString();
                        string id = reader["id"].ToString();
                        string name = reader["name"].ToString();
                        string description = reader["description"].ToString();
                        DateTime startDate = tasksTab.GetTaskStartDate(projectId);
                        DateTime dueDate = (DateTime)reader["due_date"];
                        string status = reader["status"].ToString();

                        TasksTab.Task tasksTabtask = new TasksTab.Task(projectId, ProjectComboBox.Text, id, name, description, startDate, dueDate, status);
                        tasksTab.tasksList.Add(tasksTabtask);

                        //var projectToUpdate = dashboardTab.projectList.Find(project => project.id == projectId);
                        //if (projectToUpdate != null)
                        //{
                        //    projectToUpdate.taskCount++;  // Increment taskCount
                        //}

                        tasksTab.RefreshPanels();
                        connection.Close();
                    }
                }
            }
        }

        private string GetProjectID(string projectName)
        {
            using (MySqlConnection connection = new MySqlConnection(databaseAddress))
            {
                connection.Open();
                string GET_PROJECT_ID = "SELECT id FROM projects WHERE name=@name";
                using (MySqlCommand command = new MySqlCommand(GET_PROJECT_ID, connection))
                {
                    command.Parameters.AddWithValue("@name", projectName);

                    string id = command.ExecuteScalar().ToString();
                    return id;
                }
            }
        }

        private string GetDueDate(string projectName, string prompt)
        {

            if (prompt == "TO_DATABASE")
            {
                using (MySqlConnection connection = new MySqlConnection(databaseAddress))
                {
                    connection.Open();
                    string GET_PROJECT_DUE_DATE = "SELECT due_date FROM projects WHERE name=@name";
                    using (MySqlCommand command = new MySqlCommand(GET_PROJECT_DUE_DATE, connection))
                    {
                        command.Parameters.AddWithValue("@name", projectName);

                        DateTime dueDate = (DateTime)command.ExecuteScalar();
                        return dueDate.ToString("yyyy-MM-dd");
                    }
                }
            }

            else if (prompt == "TO_FORM")
            {
                using (MySqlConnection connection = new MySqlConnection(databaseAddress))
                {
                    connection.Open();
                    string GET_PROJECT_DUE_DATE = "SELECT due_date FROM projects WHERE name=@name";
                    using (MySqlCommand command = new MySqlCommand(GET_PROJECT_DUE_DATE, connection))
                    {
                        command.Parameters.AddWithValue("@name", projectName);

                        DateTime dueDate = (DateTime)command.ExecuteScalar();
                        return dueDate.ToString("MM-dd-yyyy");
                    }
                }
            }
            return null;
        }

        private void ProjectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DueDateButton.Text = GetDueDate(ProjectComboBox.Text, "TO_FORM");
        }
    }
}
