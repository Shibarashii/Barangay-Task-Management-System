using System;
using System.Windows.Forms;
using System.Drawing;
using ComponentFactory.Krypton.Toolkit;
using MySql.Data.MySqlClient;

namespace Community_Task_Management_System
{
    public partial class AddProjectForm : KryptonForm
    {
        string databaseAddress = "server=localhost; database=barangay_task_management_system; username=root; password=;";
        MySqlCommand command;
        ProjectsTab projectsTab;
        DashboardTab dashboardTab;
        TasksTab tasksTab;
        bool forEditing;
        ProjectsTab.Project project;

        string name;
        string description;
        DateTime dueDate;
        DateTime startDate;
        
        public AddProjectForm(ProjectsTab projectsTab, DashboardTab dashboardTab, TasksTab tasksTab, bool forEditing, ProjectsTab.Project project = null)
        {
            InitializeComponent();
            DateTimeTimer.Start();
            this.projectsTab = projectsTab;
            this.dashboardTab = dashboardTab;
            this.tasksTab = tasksTab;
            this.forEditing = forEditing;
            this.project = project;

            if (forEditing)
            {
                AddNewProjectButton.Text = "Update Project";
                AddProjectLabel.Text = "Edit Project";
                DateTimeTimer.Enabled = false;
                using (MySqlConnection connection = new MySqlConnection(databaseAddress))
                {
                    connection.Open();
                    string GET_PROJECT_DATA = $"SELECT * FROM projects WHERE id='{project.id}'";
                    using (MySqlCommand command = new MySqlCommand(GET_PROJECT_DATA, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            reader.Read();
                            
                            name = reader["name"].ToString();
                            description = reader["description"].ToString();
                            dueDate = (DateTime)reader["due_date"];
                            startDate = (DateTime)reader["start_date"];

                            ProjectNameTextbox.Text = name;
                            ProjectDescriptionTextbox.Text = description;
                            DueDateButton.Text = dueDate.ToString("MM-dd-yyyy");
                            DateNowLabel.Text = startDate.ToString("MM-dd-yyyy");
                        }
                    }
                }
            }
        }
        
        #region GENERAL CODE

        private void StoreCommand(string query, MySqlConnection connection)
        {
            command =new MySqlCommand(query, connection);
        }
        #endregion
        //
        //
        //
        //
        //
        #region CALENDAR AND DATES
        private void DateTimeTimer_Tick(object sender, EventArgs e)
        {
            DateNowLabel.Text = DateTime.Now.ToString("MM-dd-yyyy                       HH:mm:ss");
        }

        private void DescriptionTextbox_TextChanged(object sender, EventArgs e)
        {
            TextCountLabel.Text = $"{ProjectDescriptionTextbox.Text.Length}/300";
        }

        MonthCalendar monthCalendar;

        private void MonthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            // Handle the selected date if needed
        }

        private void DueDateButton_Click(object sender, EventArgs e)
        {
            // Create the MonthCalendar control
            monthCalendar = new MonthCalendar
            {
                MaxSelectionCount = 1 // Allow only single date selection
            };

            // Attach an event handler for date selection change
            monthCalendar.DateSelected += MonthCalendar_DateSelected;

            // Show the MonthCalendar in a pop-up style
            using (Form calendarForm = new Form())
            {
                calendarForm.Text = "Select date";
                calendarForm.Size = new Size(240, 225);
                calendarForm.FormBorderStyle = FormBorderStyle.FixedSingle;
                calendarForm.StartPosition = FormStartPosition.CenterParent;
                calendarForm.ShowIcon = false;
                calendarForm.MinimizeBox = false;
                calendarForm.MaximizeBox = false;

                Button calendarButtonOK = new Button
                {
                    Text = "OK",
                    AutoSize = true,
                    Location = new Point(150, 163)
                };
                calendarButtonOK.Click += CalendarButtonOK_Click;
                calendarForm.Controls.Add(monthCalendar);
                calendarForm.Controls.Add(calendarButtonOK);

                // Show the form as a dialog
                calendarForm.ShowDialog();

            }
        }

        private void CalendarButtonOK_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = monthCalendar.SelectionStart;
            if (selectedDate < DateTime.Today)
            {
                MessageBox.Show("Please select a date in the future.");
                // Reset the selection to the current date
                monthCalendar.SetDate(DateTime.Today);
            }
            else
            {
                // Use the selected date as needed
                DueDateButton.Text = selectedDate.ToString("MM-dd-yyyy");
                ((Button)sender).FindForm().Close(); // Closes the calendar dialog
            }
        }
        #endregion

        private void AddNewProjectButton_Click(object sender, EventArgs e)
        {
            if (forEditing)
            {
                using (MySqlConnection connection = new MySqlConnection(databaseAddress))
                {
                    connection.Open();
                    string UPDATE_PROJECT = $"UPDATE projects SET name='{ProjectNameTextbox.Text}', due_date=@dueDate, description='{ProjectDescriptionTextbox.Text}' WHERE id={project.id}";
                    StoreCommand(UPDATE_PROJECT, connection);
                    command.Parameters.AddWithValue("@dueDate", DateTime.Parse(DueDateButton.Text));

                    if (string.IsNullOrWhiteSpace(ProjectNameTextbox.Text) ||
                        string.IsNullOrWhiteSpace(DueDateButton.Text) ||
                        string.IsNullOrWhiteSpace(ProjectDescriptionTextbox.Text))
                    {
                        MessageBox.Show("Please fill up all fields", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                   
                    else
                    {
                        int rowsAffected = Convert.ToInt32(command.ExecuteNonQuery());
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Project successfully updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ProjectsTab.Project projectsProject = projectsTab.projectsList.Find(project => project.id == this.project.id);
                            projectsProject.name = ProjectNameTextbox.Text;
                            projectsProject.description = ProjectDescriptionTextbox.Text;
                            projectsProject.dueDate = DateTime.Parse(DueDateButton.Text);
                            projectsTab.RefreshProjectsPanel();

                            DashboardTab.Project dashboardProject = dashboardTab.projectList.Find(project2 => project2.id == project.id);
                            dashboardProject.name = ProjectNameTextbox.Text;
                            dashboardProject.dueDate = DateTime.Parse(DueDateButton.Text);
                            dashboardTab.RefreshDashboardPanel();

                            TasksTab.Task tasksTask = tasksTab.tasksList.Find(task => task.projectId == project.id);
                            tasksTask.dueDate = DateTime.Parse(DueDateButton.Text);
                            tasksTab.RefreshPanels();
                            connection.Close();
                            Close();
                        }
                    }
                }
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(databaseAddress))
            {
                connection.Open();
                string CHECK_PROJECT_NAME = "SELECT * FROM projects WHERE name=@name";
                StoreCommand (CHECK_PROJECT_NAME, connection);
                command.Parameters.AddWithValue("@name", ProjectNameTextbox.Text);

                int matchRecord = Convert.ToInt32(command.ExecuteScalar());
                if (string.IsNullOrWhiteSpace(ProjectNameTextbox.Text) ||
                    string.IsNullOrWhiteSpace(DueDateButton.Text) ||
                    string.IsNullOrWhiteSpace(ProjectDescriptionTextbox.Text))
                {
                    MessageBox.Show("Please fill up all fields", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (matchRecord > 0)
                {
                    MessageBox.Show("Project name already exists", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string INSERT_PROJECT = "INSERT INTO projects (name, description, start_date, due_date, status) VALUES (@name, @description, @startDate, @dueDate, @status)";
                    StoreCommand(INSERT_PROJECT, connection);
                    command.Parameters.AddWithValue("@name", ProjectNameTextbox.Text);
                    command.Parameters.AddWithValue("@description", ProjectDescriptionTextbox.Text);
                    command.Parameters.AddWithValue("@startDate", DateTime.Parse(DateNowLabel.Text));
                    command.Parameters.AddWithValue("@dueDate", DateTime.Parse(DueDateButton.Text));
                    command.Parameters.AddWithValue("@status", "Started");

                    int rowsAffected = Convert.ToInt32(command.ExecuteNonQuery());
                    if (rowsAffected > 0)
                    {
                        string GET_ADDED_PROJECT_DATA = $"SELECT * FROM projects WHERE name='{ProjectNameTextbox.Text}'";
                        StoreCommand(GET_ADDED_PROJECT_DATA, connection);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            reader.Read();
                            string id = reader["id"].ToString();
                            string name = reader["name"].ToString();
                            string description = reader["description"].ToString();
                            DateTime startDate = reader["start_date"] == DBNull.Value ? DateTime.MinValue : (DateTime)reader["start_date"];
                            DateTime dueDate = reader["due_date"] == DBNull.Value ? DateTime.MinValue : (DateTime)reader["due_date"];
                            int? taskCount = reader["total_tasks"] == DBNull.Value ? 0 : (int?)reader["total_tasks"];
                            string status = reader["status"].ToString();
                      
                            ProjectsTab.Project projectsTabProject = new ProjectsTab.Project(id, name, 0, 0, description, startDate, dueDate, status);
                            projectsTab.projectsList.Add(projectsTabProject);
                            projectsTab.RefreshProjectsPanel();

                            DashboardTab.Project dashboardTabProject = new DashboardTab.Project(id, taskCount, name, status, 0, dueDate);
                            dashboardTab.projectList.Add(dashboardTabProject);
                            dashboardTab.RefreshDashboardPanel();

                            DialogResult result = MessageBox.Show("Project successfully added! Do you want to add a task?", "Success", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                            if (result == DialogResult.Yes)
                            {
                                AddTaskForm addTaskForm = new AddTaskForm(tasksTab, dashboardTab, false, projectsTab);
                                addTaskForm.ShowDialog();
                            }
                        }
                        connection.Close();
                        Close();
                    }
                }
            }
        }
    }
}
