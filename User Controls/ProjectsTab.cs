using System;
using System.Windows.Forms;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Guna.UI2.WinForms;
using System.Drawing;

namespace Community_Task_Management_System
{
    public partial class ProjectsTab : UserControl
    {
        string databaseConnection = "server=localhost; database=barangay_task_management_system; username=root; password=;";
        MySqlCommand command;
        DashboardTab dashboardTab; // Get dashboard and pass it into AddProjectForm so that it refreshes whenever a new project is added
        TasksTab tasksTab;
        bool thisSuperUser;
        public ProjectsTab(bool thisSuperUser, DashboardTab dashboardTab, TasksTab tasksTab)
        {
            InitializeComponent();
            this.thisSuperUser = thisSuperUser;
            if (!thisSuperUser)
            {
                AddProjectButton.Hide();
            }

            this.dashboardTab = dashboardTab;
            this.tasksTab = tasksTab;
            
            using (MySqlConnection connection = new MySqlConnection(databaseConnection))
            {
                connection.Open();
                string GET_PROJECT_DATA = "SELECT * FROM projects";
                StoreCommand(GET_PROJECT_DATA, connection);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        try
                        {
                            string id = reader["id"].ToString();
                            string name = reader["name"].ToString();
                            int totalTasks = (int)reader["total_tasks"];
                            int progress = dashboardTab.GetProjectProgress(totalTasks, id);
                            string description = reader["description"].ToString();
                            DateTime dateStarted = (DateTime)reader["start_date"];
                            DateTime dueDate = (DateTime)reader["due_date"];
                            string status = reader["status"].ToString();

                            Project project = new Project(id, name, totalTasks, progress, description, dateStarted, dueDate, status);
                            projectsList.Add(project);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                RefreshProjectsPanel();
            }

        }

        #region General Code

        private void StoreCommand(string query, MySqlConnection connection)
        {
            command = new MySqlCommand(query, connection);
        }


        #endregion

        #region Projects Tab

        public void FilterAndDisplay(string searchText)
        {
            ProjectsFlowPanel.Controls.Clear(); // Clear existing controls

            Guna2ShadowPanel columnsPanel = new Guna2ShadowPanel()
            {
                ShadowDepth = 50,
                Size = new Size(ProjectsFlowPanel.Width - 20, 70),
                Margin = new Padding(0, 0, 0, 0)
            };

            //
            // Labels for Columns Panel
            // 
            Label idLabel = new Label
            {
                Text = "ID",
                ForeColor = Color.Black,
                Font = new Font("Arial Rounded MT", 12, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(30, 20)
            };

            Label nameLabel = new Label
            {
                Text = "Name",
                ForeColor = Color.Black,
                Font = new Font("Arial Rounded MT", 12, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(idLabel.Right - 30, 20)
            };

            Label startDateLabel = new Label
            {
                Text = "Date Started",
                ForeColor = Color.Black,
                Font = new Font("Arial Rounded MT", 12, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(nameLabel.Right + 200, 20)
            };

            Label dueDateLabel = new Label
            {
                Text = "Due Date",
                ForeColor = Color.Black,
                Font = new Font("Arial Rounded MT", 12, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(startDateLabel.Right + 60, 20)
            };

            Label statusLabel = new Label
            {
                Text = "Status",
                ForeColor = Color.Black,
                Font = new Font("Arial Rounded MT", 12, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(dueDateLabel.Right + 30, 20)
            };

            Label actionsLabel = new Label
            {
                Text = "Actions",
                ForeColor = Color.Black,
                Font = new Font("Arial Rounded MT", 12, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(statusLabel.Right + 30, 20)
            };

            columnsPanel.Controls.Add(idLabel);
            columnsPanel.Controls.Add(nameLabel);
            columnsPanel.Controls.Add(startDateLabel);
            columnsPanel.Controls.Add(dueDateLabel);
            columnsPanel.Controls.Add(statusLabel);
            columnsPanel.Controls.Add(actionsLabel);
            ProjectsFlowPanel.Controls.Add(columnsPanel);

            int projectCount = 0;

            foreach (Project project in projectsList)
            {
                projectCount++;
                if (project.name.ToLower().Contains(searchText.ToLower()) ||
                    project.dateStarted.ToString("MM-dd-yyyy").Contains(searchText.ToLower()) ||
                    project.dueDate.ToString("MM-dd-yyyy").Contains(searchText.ToLower()) ||
                    project.status.ToLower().Contains(searchText.ToLower()))
                {
                    Guna2ShadowPanel separatorPanel = new Guna2ShadowPanel()
                    {
                        ShadowDepth = 50,
                        Size = new Size(ProjectsFlowPanel.Width - 20, 200),
                        Margin = new Padding(0, 0, 0, 0)
                    };

                    Label projectCountLabel = new Label
                    {
                        Text = projectCount.ToString(),
                        ForeColor = Color.Black,
                        Font = new Font("Arial Rounded MT", 12, FontStyle.Bold),
                        AutoSize = true,
                        Location = new Point(30, separatorPanel.Height / 2 - 10)
                    };

                    Label projectNameLabel = new Label
                    {
                        Text = project.name,
                        ForeColor = Color.Black,
                        Font = new Font("Arial Rounded MT", 12, FontStyle.Bold),
                        AutoSize = false,
                        Size = new Size(250, 50),
                        AutoEllipsis = true,
                        Location = new Point(projectCountLabel.Right - 30, 45)
                    };

                    Label projectDescriptionLabel = new Label
                    {
                        Text = project.description,
                        ForeColor = Color.Black,
                        Font = new Font("Arial Rounded MT", 10),
                        AutoSize = false,
                        Size = new Size(250, separatorPanel.Height - 70),
                        AutoEllipsis = true,
                        Location = new Point(projectCountLabel.Right - 30, projectNameLabel.Bottom)
                    };

                    Label projectStartDateLabel = new Label
                    {
                        Text = project.dateStarted.ToString("MM-dd-yyyy"),
                        ForeColor = Color.Black,
                        Font = new Font("Arial Rounded MT", 12),
                        AutoSize = true,
                        Location = new Point(projectNameLabel.Right + 55, separatorPanel.Height / 2 - 10)
                    };

                    Label projectDueDateLabel = new Label
                    {
                        Text = project.dueDate.ToString("MM-dd-yyyy"),
                        ForeColor = Color.Black,
                        Font = new Font("Arial Rounded MT", 12),
                        AutoSize = true,
                        Location = new Point(projectStartDateLabel.Right + 60, separatorPanel.Height / 2 - 10)
                    };
                    
                    string currentStatus = project.status;
                    project.status = SetProjectStatus(project.id, project.progress, project.dueDate, currentStatus);
                    Guna2Button projectStatusLabel = new Guna2Button
                    {
                        Text = project.status,
                        BackColor = Color.Transparent,
                        ForeColor = Color.White,
                        Font = new Font("Arial Rounded MT", 10, FontStyle.Bold),
                        Size = new Size(110, 40),
                        Location = new Point(statusLabel.Location.X, separatorPanel.Height / 2 - 20),
                        BorderRadius = 10
                    };

                    switch (projectStatusLabel.Text)
                    {
                        case "Started":
                            projectStatusLabel.FillColor = Color.Blue;
                            projectStatusLabel.HoverState.FillColor = Color.Blue;
                            projectStatusLabel.PressedColor = Color.Blue;
                            break;
                        case "Ongoing":
                            projectStatusLabel.FillColor = Color.Orange;
                            projectStatusLabel.HoverState.FillColor = Color.Orange;
                            projectStatusLabel.PressedColor = Color.Orange;
                            break;
                        case "Finished":
                            projectStatusLabel.FillColor = Color.Green;
                            projectStatusLabel.HoverState.FillColor = Color.Green;
                            projectStatusLabel.PressedColor = Color.Green;
                            break;
                        case "Missed":
                            projectStatusLabel.FillColor = Color.Red;
                            projectStatusLabel.HoverState.FillColor = Color.Red;
                            projectStatusLabel.PressedColor = Color.Red;
                            break;
                    }

                    ProjectActionControl projectActionControl = new ProjectActionControl(thisSuperUser, project.id, this, project, dashboardTab, tasksTab)
                    {
                        Location = new Point(actionsLabel.Location.X, separatorPanel.Height / 2 - 40)
                    };

                    separatorPanel.Controls.Add(projectCountLabel);
                    separatorPanel.Controls.Add(projectNameLabel);
                    separatorPanel.Controls.Add(projectDescriptionLabel);
                    separatorPanel.Controls.Add(projectStartDateLabel);
                    separatorPanel.Controls.Add(projectDueDateLabel);
                    separatorPanel.Controls.Add(projectStatusLabel);
                    separatorPanel.Controls.Add(projectActionControl);

                    ProjectsFlowPanel.Controls.Add(separatorPanel);
                    if (!thisSuperUser)
                    {
                        actionsLabel.Hide();
                    }
                }
            }

        }

        public string SetProjectStatus(string projectId, int progress, DateTime dueDate, string status)
        {
            using (MySqlConnection connection = new MySqlConnection(databaseConnection))
            {
                connection.Open();
                string UPDATE_PROJECT_STATUS = $"UPDATE projects SET status=@status WHERE id='{projectId}'";
                if (progress == 100)
                {
                    using (MySqlCommand command = new MySqlCommand(UPDATE_PROJECT_STATUS, connection))
                    {
                        command.Parameters.AddWithValue("@status", "Finished");
                        command.ExecuteNonQuery();
                    }
                    return "Finished";
                }
                else if (DateTime.Now >= dueDate && status != "Finished")
                {
                    using (MySqlCommand command = new MySqlCommand(UPDATE_PROJECT_STATUS, connection))
                    {
                        command.Parameters.AddWithValue("@status", "Missed");
                        command.ExecuteNonQuery();
                    }
                    return "Missed";
                }
                else 
                {
                    if (progress == 0)
                    {
                        using (MySqlCommand command = new MySqlCommand(UPDATE_PROJECT_STATUS, connection))
                        {
                            command.Parameters.AddWithValue("@status", "Started");
                            command.ExecuteNonQuery();
                        }
                        return "Started";
                    }
                    else if (progress > 0 && progress < 100)
                    {
                        using (MySqlCommand command = new MySqlCommand(UPDATE_PROJECT_STATUS, connection))
                        {
                            command.Parameters.AddWithValue("@status", "Ongoing");
                            command.ExecuteNonQuery();
                        }
                        return "Ongoing";
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }

        public void RefreshProjectsPanel()
        {
            FilterAndDisplay(string.Empty);
        }

        private void ProjectsSearchTextbox_TextChanged(object sender, EventArgs e)
        {
            FilterAndDisplay(ProjectsSearchTextbox.Text);
        }

        public List<Project> projectsList = new List<Project>();

        public class Project
        {
            public string id;
            public string name;
            public int totalTasks;
            public int progress;
            public string description;
            public DateTime dateStarted;
            public DateTime dueDate;
            public string status;

            public Project(string id, string name, int totalTasks, int progress, string description, DateTime dateStarted, DateTime dueDate, string status)
            {
                this.id = id;
                this.totalTasks = totalTasks;
                this.progress = progress;
                this.name = name;
                this.description = description;
                this.dateStarted = dateStarted;
                this.dueDate = dueDate;
                this.status = status;
            }
        }
        #endregion

        private void AddProjectButton_Click(object sender, EventArgs e)
        {
            AddProjectForm addProjectForm = new AddProjectForm(this, dashboardTab, tasksTab, false);
            addProjectForm.ShowDialog();
        }
    }
}
