using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Community_Task_Management_System
{
    public partial class ActionControl : UserControl
    {
        string databaseConnection = "server=localhost; database=barangay_task_management_system; username=root; password=;";
        List<SuperUserPage.User> usersList = new List<SuperUserPage.User>();
        SuperUserPage superUserPage;
        SuperUserPage.User user;
        string id;

        public ActionControl(string id, List<SuperUserPage.User> usersList, SuperUserPage superUserPage, SuperUserPage.User user = null)
        {
            InitializeComponent();
            // Creating a constructor to pass on the data from SuperUserPage to this User Control
            this.id = id;
            this.usersList = usersList;
            this.superUserPage = superUserPage;
            this.user = user;
        }

        MySqlCommand command;
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this user?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                using (MySqlConnection connection = new MySqlConnection(databaseConnection))
                {

                    connection.Open();
                    string deleteQuery = "DELETE FROM users WHERE id=@id";

                    StoreCommand(deleteQuery, connection);
                    command.Parameters.AddWithValue("@id", id);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Delete the user from the UserList in the SuperUserPage
                        SuperUserPage.User deletingUser = usersList.Find(user => user.id == id);
                        {
                            if (deletingUser != null)
                            {
                                usersList.Remove(deletingUser);
                            }
                        }
                        // Refresh the UsersFlowPanel by calling the method from SuperUserPage
                        superUserPage.RefreshUsersFlowPanel();
                    }
                    else
                    {
                        MessageBox.Show("Unable to delete user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
        }

        private void StoreCommand(string query, MySqlConnection connection)
        {
            command = new MySqlCommand(query, connection);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm(superUserPage, true, user.isSuperuser, user);
            addUserForm.ShowDialog();
        }
    }
}
