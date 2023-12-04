using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Community_Task_Management_System
{
    public partial class ProjectActionControl : UserControl
    {
        string databaseConnection = "server=localhost; database=barangay_task_management_system; username=root; password=;";
        bool isSuperUser;
        string id;
        ProjectsTab projectsTab;
        ProjectsTab.Project project;
        DashboardTab dashboardTab;
        TasksTab taskTab;
        MySqlCommand command;
        public ProjectActionControl(bool isSuperUser, string id, ProjectsTab projectsTab, ProjectsTab.Project project, DashboardTab dashboardTab, TasksTab taskTab)
        {
            InitializeComponent();
            this.id = id;
            this.isSuperUser = isSuperUser;
            this.project = project;
            this.dashboardTab = dashboardTab;
            this.projectsTab = projectsTab;
            this.taskTab = taskTab;
            if (!isSuperUser)
            {
                EditButton.Visible = false;
                DeleteButton.Visible = false;
            }
        }

        private void StoreCommand(string query, MySqlConnection connection)
        {
            command = new MySqlCommand(query, connection);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This will permanently deleted the project. Continue?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                using (MySqlConnection connection = new MySqlConnection(databaseConnection))
                {
                    connection.Open();
                    string deleteQuery = $"DELETE FROM projects WHERE id='{id}'";

                    StoreCommand(deleteQuery, connection);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Project deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ProjectsTab.Project deletingProject = projectsTab.projectsList.Find(project => project.id == id);
                        if (deletingProject != null)
                        {
                            projectsTab.projectsList.Remove(deletingProject);
                        }
                        projectsTab.RefreshProjectsPanel();

                        DashboardTab.Project deletingProject2 = dashboardTab.projectList.Find(project => project.id == id);
                        if (deletingProject2 != null)
                        {
                            dashboardTab.projectList.Remove(deletingProject2);
                        }
                        dashboardTab.RefreshDashboardPanel();

                        taskTab.tasksList.RemoveAll(tasks => tasks.projectId == id);
                        taskTab.RefreshPanels();
                    }
                }
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            AddProjectForm addProjectForm = new AddProjectForm(projectsTab, dashboardTab, taskTab, true, project);
            addProjectForm.ShowDialog();
        }
    }
}
