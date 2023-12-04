using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Security.AccessControl;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Community_Task_Management_System
{
    public partial class TaskActionControl : UserControl
    {
        string id;
        string projectId;
        string databaseConnection = "server=localhost; database=barangay_task_management_system; username=root; password=;";
        TasksTab tasksTab;
        TasksTab.Task task;
        MySqlCommand command;
        DashboardTab dashboardTab;
        ProjectsTab projectsTab;
        public TaskActionControl(bool isSuperUser, string id, TasksTab tasksTab, DashboardTab dashboardTab, ProjectsTab projectsTab, TasksTab.Task task)
        {
            InitializeComponent();
            this.id = id;
            this.tasksTab = tasksTab;
            this.dashboardTab = dashboardTab;
            this.projectsTab = projectsTab;
            this.task = task;
            if (!isSuperUser )
            {
                EditButton.Visible = false;
                DeleteButton.Visible = false;
            }

            using (MySqlConnection connection = new MySqlConnection(databaseConnection))
            {
                connection.Open();
                string GET_PROJECT_ID = $"SELECT project_id FROM tasks WHERE id={id}";
                StoreCommand(GET_PROJECT_ID, connection);
                projectId = command.ExecuteScalar().ToString();
                connection.Close();
            }
        }

        private void StoreCommand(string query, MySqlConnection connection)
        {
            command = new MySqlCommand(query, connection);    
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This will permanently delete the task. Continue?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                using (MySqlConnection connection = new MySqlConnection(databaseConnection))
                {

                    connection.Open();
                    string deleteQuery = $"DELETE FROM tasks WHERE id='{id}'";

                    StoreCommand(deleteQuery, connection);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Task deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Delete the user from the UserList in the SuperUserPage
                        TasksTab.Task deletingUser = tasksTab.tasksList.Find(user => user.id == id);
                        {
                            if (deletingUser != null)
                            {
                                tasksTab.tasksList.Remove(deletingUser);
                            }
                        }
                        // Refresh the UsersFlowPanel by calling the method from SuperUserPage
                        tasksTab.RefreshPanels();

                        int dashboardTaskCount = dashboardTab.GetProjectTotalTasks(projectId);
                        DashboardTab.Project dashboardProject = dashboardTab.projectList.Find(project => project.id == projectId);
                        dashboardProject.progress = dashboardTab.GetProjectProgress(dashboardTaskCount, projectId);
                        dashboardTab.RefreshDashboardPanel();

                        int projectsTaskCount = dashboardTab.GetProjectTotalTasks(projectId);
                        ProjectsTab.Project projectsProject = projectsTab.projectsList.Find(project => project.id == projectId);
                        projectsProject.progress = dashboardTab.GetProjectProgress(projectsTaskCount, projectId);
                        projectsTab.RefreshProjectsPanel();
                    }
                }
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            AddTaskForm addTaskForm = new AddTaskForm(tasksTab, dashboardTab, true, projectsTab, task);
            addTaskForm.ShowDialog();
        }
    }
}
