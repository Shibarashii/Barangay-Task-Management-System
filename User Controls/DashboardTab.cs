using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Drawing;
using Guna.UI2.WinForms;

namespace Community_Task_Management_System
{
    public partial class DashboardTab : UserControl
    {
        string databaseAddress = "server=localhost; database=barangay_task_management_system; username=root; password=;";
        MySqlCommand command;
        public DashboardTab()
        {
            InitializeComponent();
            SetProjectTaskCount();
            SetCountLabels();
            using (MySqlConnection connection = new MySqlConnection(databaseAddress))
            {
                connection.Open();
                string GET_PROJECT_DATA = "SELECT * FROM projects";
                StoreCommand(GET_PROJECT_DATA, connection);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string projectId = reader["id"].ToString();
                        int totalTasks = (int)reader["total_tasks"];
                        string projectName = reader["name"].ToString();
                        string projectStatus = reader["status"].ToString();
                        int projectProgress = GetProjectProgress(totalTasks, projectId);
                        DateTime projectDueDate = (DateTime)reader["due_date"];

                        Project project = new Project(projectId, totalTasks, projectName, projectStatus, projectProgress, projectDueDate);
                        projectList.Add(project);

                    }
                }
                FilterAndDisplay();
                connection.Close();
            }
        }

        #region SET LABEL VALUES

        public void SetCountLabels()
        {
            // Total Projects
            //
            using (MySqlConnection connection = new MySqlConnection(databaseAddress))
            {
                connection.Open();
                string GET_TOTAL_PROJECTS_COUNT = "SELECT COUNT(*) FROM projects";
                using (MySqlCommand command = new MySqlCommand(GET_TOTAL_PROJECTS_COUNT, connection))
                {
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    TotalProjectsCountLabel.Text = count.ToString();
                }
                connection.Clone();
            }
            //
            // Projects Finished
            //
            using (MySqlConnection connection = new MySqlConnection(databaseAddress))
            {
                connection.Open();
                string GET_FINISHED_PROJECTS_COUNT = "SELECT COUNT(*) FROM projects WHERE status='Finished'";
                using (MySqlCommand command = new MySqlCommand(GET_FINISHED_PROJECTS_COUNT, connection))
                {
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    ProjectsFinishedCountLabel.Text = count.ToString();
                }
                connection.Clone();
            }
            //
            // Total Tasks
            //
            using (MySqlConnection connection = new MySqlConnection(databaseAddress))
            {
                connection.Open();
                string GET_TOTAL_TASKS_COUNT = "SELECT COUNT(*) FROM tasks";
                using (MySqlCommand command = new MySqlCommand(GET_TOTAL_TASKS_COUNT, connection))
                {
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    TotalTasksCountLabel.Text = count.ToString();
                }
                connection.Clone();
            }
            //
            // Tasks Finished
            using (MySqlConnection connection = new MySqlConnection(databaseAddress))
            {
                connection.Open();
                string GET_FINISHED_TASKS_COUNT = "SELECT COUNT(*) FROM tasks WHERE status='Finished'";
                using (MySqlCommand command = new MySqlCommand(GET_FINISHED_TASKS_COUNT, connection))
                {
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    TasksFinishedCountLabel.Text = count.ToString();
                }
                connection.Clone();
            }
            //
        }
        #endregion

        public int GetProjectProgress(int? totalTasks, string projectId)
        {
            if (totalTasks == 0 || totalTasks == null)
            {
                return 0;
            }

            using (MySqlConnection connection = new MySqlConnection(databaseAddress))
            {
                connection.Open();
                string GET_TOTAL_TASKS_FINISHED = "SELECT COUNT(*) FROM tasks WHERE project_id=@projectId AND status=@status";
                using (MySqlCommand command = new MySqlCommand(GET_TOTAL_TASKS_FINISHED, connection))
                {
                    command.Parameters.AddWithValue("@projectId", projectId);
                    command.Parameters.AddWithValue("@status", "Finished");

                    int finishedTasksCount = Convert.ToInt32(command.ExecuteScalar());
                    double projectProgress = (double)finishedTasksCount / Convert.ToInt32(totalTasks) * 100;

                    connection.Close();
                    return (int)projectProgress;
                }
            }
        }

        public string SetProjectStatus(string projectId, int progress, DateTime dueDate, string status)
        {
            using (MySqlConnection connection = new MySqlConnection(databaseAddress))
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

        public void SetProjectTaskCount()
        {
            using (MySqlConnection connection = new MySqlConnection(databaseAddress))
            {
                // SET PROJECT'S TOTAL TASKS
                connection.Open();
                string SET_PROJECT_TOTAL_TASKS = "UPDATE projects SET total_tasks = (SELECT COUNT(*) FROM tasks WHERE project_id=projects.id)";
                using (MySqlCommand command = new MySqlCommand(SET_PROJECT_TOTAL_TASKS, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        } 

        public int GetProjectTotalTasks(string projectId)
        {
            using (MySqlConnection connection = new MySqlConnection(databaseAddress))
            {
                // SET PROJECT'S TOTAL TASKS
                connection.Open();
                string SET_PROJECT_TOTAL_TASKS = $"SELECT COUNT(*) FROM tasks WHERE project_id={projectId}";
                using (MySqlCommand command = new MySqlCommand(SET_PROJECT_TOTAL_TASKS, connection))
                {
                    int taskCount = Convert.ToInt32(command.ExecuteScalar());
                    return taskCount;
                }
            }
        }

        private void StoreCommand(string query, MySqlConnection connection)
        {
            command = new MySqlCommand(query, connection);
        }

      
        public void RefreshDashboardPanel()
        {
            SetProjectTaskCount();
            SetCountLabels();
            FilterAndDisplay();
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

        #region DASHBOARD PANEL
        private void FilterAndDisplay()
        {
            DashboardFlowPanel.Controls.Clear();

            var numberLabel = CreateLabel("#", new Font("Arial MT Rounded", 12, FontStyle.Bold), Color.Black, new Point (20, 25));
            var nameLabel = CreateLabel("Project Name", new Font("Arial MT Rounded", 12, FontStyle.Bold), Color.Black, new Point (numberLabel.Right - 75, 25));
            var progressLabel = CreateLabel("Progress", new Font("Arial MT Rounded", 12, FontStyle.Bold), Color.Black, new Point (nameLabel.Right + 110, 25));
            var statusLabel = CreateLabel("Status", new Font("Arial MT Rounded", 12, FontStyle.Bold), Color.Black, new Point (progressLabel.Right + 90, 25));
            var dueDate = CreateLabel("Due Date", new Font("Arial MT Rounded", 12, FontStyle.Bold), Color.Black, new Point (statusLabel.Right + 20, 25));

            Guna2ShadowPanel columnsPanel = new Guna2ShadowPanel()
            {
                ShadowDepth = 50,
                Size = new Size(DashboardFlowPanel.Width - 20, 70),
                Margin = new Padding(0, 0, 0, 0)
            };

            columnsPanel.Controls.Add(numberLabel);
            columnsPanel.Controls.Add(nameLabel);
            columnsPanel.Controls.Add(progressLabel);
            columnsPanel.Controls.Add(dueDate);
            columnsPanel.Controls.Add(statusLabel);
            DashboardFlowPanel.Controls.Add(columnsPanel);

            int projectCount = 0;
            foreach (Project project in projectList)
            {
                projectCount++;
                Guna2ShadowPanel separatorPanel = new Guna2ShadowPanel()
                {
                    ShadowDepth = 50,
                    Size = new Size(DashboardFlowPanel.Width - 20, 120),
                    Margin = new Padding(0, 0, 0, 0)
                };

                var projectNumber = CreateLabel(projectCount.ToString(), new Font("Arial MT Rounded", 10), Color.Black, new Point(numberLabel.Location.X, 50));
                var projectName = CreateLabel(project.name, new Font("Arial MT Rounded", 10), Color.Black, new Point(nameLabel.Location.X, 50), false, true, new Size(180, 40));
                var projectProgressBar = new Guna2ProgressBar
                {
                    Maximum = 100,
                    Value = project.progress,
                    Location = new Point(progressLabel.Location.X, 25),
                    Size = new Size(140, 15)
                };
                var projectTotalTasks = CreateLabel($"Total tasks: {GetProjectTotalTasks(project.id)}", new Font("Arial MT Rounded", 10), Color.Black, new Point(progressLabel.Location.X - 1, projectProgressBar.Bottom + 10));
                var projectProgressPercent = CreateLabel($"{project.progress}% Completed", new Font("Arial MT Rounded", 10), Color.Black, new Point(progressLabel.Location.X - 1, projectTotalTasks.Bottom));

                project.status = SetProjectStatus(project.id, project.progress, project.dueDate, project.status);
                Guna2Button projectStatusLabel = new Guna2Button
                {
                    Text = project.status,
                    BackColor = Color.Transparent,
                    ForeColor = Color.White,
                    Font = new Font("Arial Rounded MT", 10, FontStyle.Bold),
                    Size = new Size(70, 30),
                    Location = new Point(statusLabel.Location.X, 40),
                    BorderRadius = 8
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

                var projectDueDate = CreateLabel(project.dueDate.ToString("MM-dd-yyyy"), new Font("Arial MT Rounded", 10), Color.Black, new Point(dueDate.Location.X, 50));

                separatorPanel.Controls.Add(projectNumber);
                separatorPanel.Controls.Add(projectName);
                separatorPanel.Controls.Add(projectProgressBar);
                separatorPanel.Controls.Add(projectProgressPercent);
                separatorPanel.Controls.Add(projectTotalTasks);
                separatorPanel.Controls.Add(projectStatusLabel);
                separatorPanel.Controls.Add(projectDueDate);
               
                DashboardFlowPanel.Controls.Add(separatorPanel);
            }

        }

        public List<Project> projectList = new List<Project>();
        public class Project
        {
            public string id;
            public int? taskCount;
            public string name;
            public string status;
            public int progress;
            public DateTime dueDate;

            public Project(string id, int? taskCount, string name, string status, int progress, DateTime dueDate)
            {
                this.id = id;
                this.taskCount = taskCount;
                this.name = name;
                this.status = status;
                this.progress = progress;
                this.dueDate = dueDate;
            }
        } 
        #endregion
    }
}
