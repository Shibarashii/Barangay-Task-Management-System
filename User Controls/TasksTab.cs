using System;
using System.Windows.Forms;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Drawing;
using Guna.UI2.WinForms;
namespace Community_Task_Management_System
{
    public partial class TasksTab : UserControl
    {
        string databaseConnection = "server=localhost; database=barangay_task_management_system; username=root; password=;";
        MySqlCommand command;
        DashboardTab dashboardTab;
        bool thisSuperUser;
        ProjectsTab projectsTab;
        public TasksTab(bool thisSuperUser, DashboardTab dashboardTab)
        {
            InitializeComponent();
            this.thisSuperUser = thisSuperUser;
            if (!thisSuperUser)
            {
                AddTaskButton.Hide();
            }
            
            this.dashboardTab = dashboardTab;
            using (MySqlConnection connection = new MySqlConnection(databaseConnection))
            {
                connection.Open();
                string GET_TASK_DATA = "SELECT * FROM tasks";
                StoreCommand(GET_TASK_DATA, connection);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string projectId = reader["project_id"].ToString();
                        string projectName = GetProjectName(projectId);
                        string id = reader["id"].ToString();
                        string name = reader["name"].ToString();
                        string description = reader["description"].ToString();
                        DateTime startDate = GetTaskStartDate(projectId);
                        DateTime dueDate = (DateTime)reader["due_date"];
                        string status = reader["status"].ToString();

                        Task task = new Task(projectId, projectName, id, name, description, startDate, dueDate, status);
                        tasksList.Add(task);
                    }
                }
            }
            FilterAndDisplay(string.Empty);
        }

        public void GetProjectsPanel(ProjectsTab projectsTab)
        {
            this.projectsTab = projectsTab;
        }

        private void StoreCommand(string query, MySqlConnection connection)
        {
            command = new MySqlCommand(query, connection);
        }

        public DateTime GetTaskStartDate(string projectId)
        {
            using (MySqlConnection connection = new MySqlConnection(databaseConnection))
            {
                connection.Open();
                string GET_PROJECT_START_DATE = $"SELECT due_date FROM projects WHERE id='{projectId}'";
                using (MySqlCommand command = new MySqlCommand(GET_PROJECT_START_DATE, connection))
                {
                    DateTime startDate = (DateTime)command.ExecuteScalar();
                    connection.Close();
                    return startDate;
                }
            }
        }
        private string GetProjectName(string projectId)
        {
            using (MySqlConnection connection = new MySqlConnection(databaseConnection))
            {
                connection.Open();
                string GET_PROJECT_NAME = "SELECT name FROM projects WHERE id=@id";
                StoreCommand(GET_PROJECT_NAME, connection);
                command.Parameters.AddWithValue("@id", projectId);
                string projectName = command.ExecuteScalar().ToString();

                return projectName;

            }
        }

        private Label CreateLabel(string text, Font font, Color foreColor, Point location, bool autoSize = true, bool autoEllipsis = true, Size? size = null)
        {
            var label = new Label
            {
                Text = text,
                Font = font,
                ForeColor = foreColor,
                AutoSize = autoSize,
                Location = location,
                AutoEllipsis = autoEllipsis
            };

            if (size.HasValue)
            {
                label.Size = size.Value;
            }

            return label;
        }

        private void FilterAndDisplay(string searchText)
        {
            TasksFlowPanel.Controls.Clear();
            Guna2ShadowPanel columnsPanel = new Guna2ShadowPanel()
            {
                ShadowDepth = 50,
                Size = new Size(TasksFlowPanel.Width - 20, 70),
                Margin = new Padding(0, 0, 0, 0)
            };

            Label idLabel = CreateLabel("#", new Font("Arial MT Rounded", 12, FontStyle.Bold), Color.Black, new Point(30, 20), true);
            Label projectNameLabel = CreateLabel("Project", new Font("Arial MT Rounded", 12, FontStyle.Bold), Color.Black, new Point(idLabel.Right - 30, 20));
            Label nameLabel = CreateLabel("Name", new Font("Arial MT Rounded", 12, FontStyle.Bold), Color.Black, new Point(projectNameLabel.Right + 100, 20));
            Label dueDateLabel = CreateLabel("Due Date", new Font("Arial MT Rounded", 12, FontStyle.Bold), Color.Black, new Point(nameLabel.Right + 170, 20));
            Label statusLabel = CreateLabel("Status", new Font("Arial MT Rounded", 12, FontStyle.Bold), Color.Black, new Point(dueDateLabel.Right + 30, 20));
            Label actionsLabel = CreateLabel("Actions", new Font("Arial MT Rounded", 12, FontStyle.Bold), Color.Black, new Point(statusLabel.Right + 30, 20));

            columnsPanel.Controls.Add(idLabel);
            columnsPanel.Controls.Add(projectNameLabel);
            columnsPanel.Controls.Add(nameLabel);
            columnsPanel.Controls.Add(dueDateLabel);
            columnsPanel.Controls.Add(statusLabel);
            columnsPanel.Controls.Add(actionsLabel);
            TasksFlowPanel.Controls.Add(columnsPanel);

            int taskCount = 0;
            foreach (Task task in tasksList)
            {
                taskCount++;
                if (task.projectName.ToLower().Contains(searchText.ToLower()) ||
                    task.name.ToLower().Contains(searchText.ToLower()) ||
                    task.description.ToLower().Contains(searchText.ToLower()) ||
                    task.status.ToLower().Contains(searchText.ToLower()))
                {

                }
                Guna2ShadowPanel separatorPanel = new Guna2ShadowPanel()
                {
                    ShadowDepth = 50,
                    Size = new Size(TasksFlowPanel.Width - 20, 200),
                    Margin = new Padding(0, 0, 0, 0)
                };

                Label taskIdLabel = CreateLabel(taskCount.ToString(), new Font("Arial MT Rounded", 12, FontStyle.Bold), Color.Black, new Point(idLabel.Location.X, separatorPanel.Height / 2 - 10), true);
                Label taskProjectNameLabel = CreateLabel(task.projectName, new Font("Arial MT Rounded", 12, FontStyle.Bold), Color.Black, new Point(projectNameLabel.Location.X, separatorPanel.Height / 2 - 10), false, true, new Size(175, 70));
                Label taskNameLabel = CreateLabel(task.name, new Font("Arial MT Rounded", 12, FontStyle.Bold), Color.Black, new Point(nameLabel.Location.X, separatorPanel.Height / 2 - 10), false, true, new Size(250, 50));
                Label taskDescriptionLabel = CreateLabel(task.description, new Font("Arial MT Rounded", 10), Color.Black, new Point(nameLabel.Location.X, taskNameLabel.Bottom), false, true, new Size(200, 30));
                Label taskDueDateLabel = CreateLabel(task.dueDate.ToString("MM-dd-yyyy"), new Font("Arial MT Rounded", 12), Color.Black, new Point(dueDateLabel.Location.X, separatorPanel.Height / 2 - 10));

                Guna2ComboBox taskStatusLabel = new Guna2ComboBox()
                {
                    Text = task.status,
                    BackColor = Color.Transparent,
                    ForeColor = Color.White,
                    Font = new Font("Arial Rounded MT", 10, FontStyle.Bold),
                    Size = new Size(110, 40),
                    Location = new Point(statusLabel.Location.X, separatorPanel.Height / 2 - 20),
                    BorderRadius = 10
                };
                taskStatusLabel.Items.Add("Pending");
                taskStatusLabel.Items.Add("Finished");
                taskStatusLabel.Items.Add("Missed");

                if (DateTime.Now > task.dueDate && task.status == "Pending")
                {
                    task.status = "Missed";
                }

                taskStatusLabel.SelectedIndex = GetSelectedIndex(task.status);

                //
                // Change Color depending on the Task Status
                //
                // HoverState.FillColor and PressedColor set to its own Fill Color so that
                // the button seems not Clickable since it the color is not changing when
                // you hover over it or press it
                //
                taskStatusLabel.SelectedIndexChanged += (sender, e) => SelectedIndex_Changed(sender, e, taskStatusLabel, task.id, task.projectId);

                // Manually call the event handler for the initial value

                switch (taskStatusLabel.Text)
                {
                    case "Pending":
                        taskStatusLabel.FillColor = Color.DarkGray;
                        break;
                    case "Finished":
                        taskStatusLabel.FillColor = Color.Green;
                        break;
                    case "Missed":
                        taskStatusLabel.FillColor = Color.Red;
                        break;
                }

                TaskActionControl taskActionControl = new TaskActionControl(thisSuperUser, task.id, this, dashboardTab, projectsTab, task)
                {
                    Location = new Point(actionsLabel.Location.X, separatorPanel.Height / 2 - 40)
                };

                separatorPanel.Controls.Add(taskIdLabel);
                separatorPanel.Controls.Add(taskProjectNameLabel);
                separatorPanel.Controls.Add(taskNameLabel);
                separatorPanel.Controls.Add(taskDescriptionLabel);
                separatorPanel.Controls.Add(taskDueDateLabel);
                separatorPanel.Controls.Add(taskStatusLabel);
                separatorPanel.Controls.Add(taskActionControl);

                TasksFlowPanel.Controls.Add(separatorPanel);
                if (!thisSuperUser)
                {
                    actionsLabel.Hide();
                }
            }
        }

        private int GetSelectedIndex(string status)
        {
            switch (status)
            {
                case "Pending":
                    return 0;
                case "Finished":
                    return 1;
                case "Missed":
                    return 2;
            }
            return -1;
        }

        private void SelectedIndex_Changed(object sender, EventArgs e, Guna2ComboBox taskStatusLabel, string id, string projectId)
        {
            string newStatus = taskStatusLabel.Text;

            switch (newStatus)
            {
                case "Pending":
                    taskStatusLabel.FillColor = Color.DarkGray;
                    break;
                case "Finished":
                    taskStatusLabel.FillColor = Color.Green;
                    break;
                case "Missed":
                    taskStatusLabel.FillColor = Color.Red;
                    break;
            }
            using (MySqlConnection connection = new MySqlConnection(databaseConnection))
            {
                connection.Open();
                string UPDATE_TASK_STATUS = $"UPDATE tasks SET status ='{newStatus}' WHERE id='{id}'";
                StoreCommand(UPDATE_TASK_STATUS, connection);
                command.ExecuteNonQuery();

                // To refresh the contents of the DashboardTab
                int dashboardTaskCount = dashboardTab.GetProjectTotalTasks(projectId);
                DashboardTab.Project dashboardProject = dashboardTab.projectList.Find(project => project.id == projectId);
                dashboardProject.progress = dashboardTab.GetProjectProgress(dashboardTaskCount, projectId);
                dashboardTab.RefreshDashboardPanel();
                dashboardTab.RefreshDashboardPanel();

                int projectsTaskCount = dashboardTab.GetProjectTotalTasks(projectId);
                ProjectsTab.Project projectsProject = projectsTab.projectsList.Find(project => project.id == projectId);
                projectsProject.progress = dashboardTab.GetProjectProgress(dashboardTaskCount, projectId);
                projectsTab.RefreshProjectsPanel();
                projectsTab.RefreshProjectsPanel();
            }
        }

        public List<Task> tasksList = new List<Task>(); // dito nilalagay yung lahat ng tasks
        public class Task
        {
            public string projectId;
            public string projectName;
            public string id; // Task ID
            public string name;
            public string description;
            public DateTime startDate;
            public DateTime dueDate;
            public string status;

            public Task(string projectId, string projectName, string id, string name, string description, DateTime startDate, DateTime dueDate, string status)
            {
                this.projectId = projectId;
                this.projectName = projectName;
                this.id = id;
                this.name = name;
                this.description = description;
                this.dueDate = dueDate;
                this.status = status;
                this.startDate = startDate;
            }
        }


        public void RefreshPanels()
        {
            FilterAndDisplay(string.Empty);
        }

        private void AddTaskButton_Click(object sender, EventArgs e)
        {
            AddTaskForm addTaskForm = new AddTaskForm(this, dashboardTab, false, projectsTab);
            addTaskForm.ShowDialog();
        }

        private void TasksSearchTextbox_TextChanged(object sender, EventArgs e)
        {
            FilterAndDisplay(TasksSearchTextbox.Text);
        }
    }
}
