using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;

namespace Community_Task_Management_System
{
    public partial class AddUserForm : KryptonForm
    {
        string databaseAddress = "server=localhost; database=barangay_task_management_system; username=root; password=;";
        MySqlCommand command;
        SuperUserPage superUserPage;
        SuperUserPage.User user;
        bool forEditing;
        bool isSuperUser;

        string firstName;
        string middleName;
        string lastName;
        string email;
        string password;
        string id;
        public AddUserForm(SuperUserPage superUserPage, bool forEditing, bool isSuperUser, SuperUserPage.User user = null, bool forUpdatingProfile = false)
        {
            InitializeComponent();
            this.superUserPage = superUserPage;
            this.user = user;
            this.forEditing = forEditing;
            this.isSuperUser = isSuperUser;
            if (forEditing)
            {
                AccessLevelComboBox.Enabled = false;
                AddNewUserButton.Text = "Update User";
                if (forUpdatingProfile)
                {
                    AddNewUserButton.Text = "Update Profile";
                }
                AddUserLabel.Text = "Your Profile";
                if (isSuperUser)
                {
                    AccessLevelComboBox.SelectedIndex = 1;
                }
                else
                {
                    AccessLevelComboBox.SelectedIndex = 0;
                }
                
                using (MySqlConnection connection = new MySqlConnection(databaseAddress))
                {
                    connection.Open();
                    string GET_USER_DATA = $"SELECT * FROM users WHERE id='{user.id}'";
                    using (MySqlCommand command = new MySqlCommand(GET_USER_DATA, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            reader.Read();
                            id = reader["id"].ToString();
                            firstName = reader["first_name"].ToString();
                            middleName = reader["middle_name"].ToString();
                            lastName = reader["last_name"].ToString();
                            email = reader["email"].ToString();
                            password = reader["password"].ToString();

                            FirstNameTextbox.Text = firstName;
                            MiddleNameTextbox.Text = middleName;
                            LastNameTextbox.Text = lastName;
                            EmailTextbox.Text = email;
                            PasswordTextbox.Text = password;
                            ConfirmPasswordTextbox.Text = password;
                        }
                    }
                    connection.Close();
                }
            }
        }

        private void StoreCommand(string query, MySqlConnection connection)
        {
            command = new MySqlCommand(query, connection);
        }

        string CHECK_USER_NAME = "SELECT * FROM users WHERE first_name=@firstName AND middle_name=@middleName AND last_name=@lastName";
        string INSERT_USER = "INSERT INTO users (first_name, middle_name, last_name, email, password, date, is_superuser) VALUES (@firstName, @middleName, @lastName, @email, @password, @date, @isSuperuser) ";
        private void AddUserButtonn_Click(object sender, EventArgs e)
        {
            if (forEditing)
            {
                using (MySqlConnection connection = new MySqlConnection(databaseAddress))
                {
                    connection.Open();
                    string UPDATE_USER = $"UPDATE users SET first_name=@firstName, middle_name=@middleName, last_name=@lastName, email=@email, password=@password WHERE id='{user.id}'";
                    if (string.IsNullOrWhiteSpace(FirstNameTextbox.Text) ||
                        string.IsNullOrWhiteSpace(MiddleNameTextbox.Text) ||
                        string.IsNullOrWhiteSpace(LastNameTextbox.Text) ||
                        string.IsNullOrWhiteSpace(AccessLevelComboBox.Text) ||
                        string.IsNullOrWhiteSpace(EmailTextbox.Text) ||
                        string.IsNullOrWhiteSpace(PasswordTextbox.Text) ||
                        string.IsNullOrWhiteSpace(ConfirmPasswordTextbox.Text))
                    {
                        MessageBox.Show("Please fill up all fields", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!emailIsAvailable && email != user.email)
                    {
                        MessageBox.Show("Email is already taken", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!EmailTextbox.Text.Contains("@gmail.com"))
                    {
                        MessageBox.Show("Please enter a valid email", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!passwordMatches)
                    {
                        MessageBox.Show("Passwords do not match", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DateTime date = DateTime.Now;

                        StoreCommand(UPDATE_USER, connection);
                        command.Parameters.AddWithValue("@firstName", FirstNameTextbox.Text);
                        command.Parameters.AddWithValue("@middleName", MiddleNameTextbox.Text);
                        command.Parameters.AddWithValue("@lastName", LastNameTextbox.Text);
                        command.Parameters.AddWithValue("@email", EmailTextbox.Text);
                        command.Parameters.AddWithValue("@password", PasswordTextbox.Text);

                        int rowsAffected = Convert.ToInt32(command.ExecuteNonQuery());
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User successfully updated!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            SuperUserPage.User superUserPageUser = superUserPage.usersList.Find(user => user.id == id);
                            superUserPageUser.firstName = FirstNameTextbox.Text;
                            superUserPageUser.middleName = MiddleNameTextbox.Text;
                            superUserPageUser.lastName = LastNameTextbox.Text;
                            superUserPageUser.email = EmailTextbox.Text;
                            superUserPageUser.password = PasswordTextbox.Text;
                            superUserPage.RefreshUsersFlowPanel();

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
                StoreCommand(CHECK_USER_NAME, connection);
                command.Parameters.AddWithValue("@firstName", FirstNameTextbox.Text);
                command.Parameters.AddWithValue("@middleName", MiddleNameTextbox.Text);
                command.Parameters.AddWithValue("@lastName", LastNameTextbox.Text);

                int matchRecord = Convert.ToInt32(command.ExecuteScalar());
                if (string.IsNullOrWhiteSpace(FirstNameTextbox.Text) ||
                    string.IsNullOrWhiteSpace(MiddleNameTextbox.Text) ||
                    string.IsNullOrWhiteSpace(LastNameTextbox.Text) ||
                    string.IsNullOrWhiteSpace(AccessLevelComboBox.Text) ||
                    string.IsNullOrWhiteSpace(EmailTextbox.Text) ||
                    string.IsNullOrWhiteSpace(PasswordTextbox.Text) ||
                    string.IsNullOrWhiteSpace(ConfirmPasswordTextbox.Text))
                {
                    MessageBox.Show("Please fill up all fields", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!emailIsAvailable)
                {
                    MessageBox.Show("Email is already taken", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!EmailTextbox.Text.Contains("@gmail.com"))
                {
                    MessageBox.Show("Please enter a valid email", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (!passwordMatches)
                {
                    MessageBox.Show("Passwords do not match", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (matchRecord > 0)
                {
                    MessageBox.Show($"Account already with the name {FirstNameTextbox.Text} {MiddleNameTextbox.Text} {LastNameTextbox.Text}", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DateTime date = DateTime.Now;
                    bool isSuperuser;

                    if (AccessLevelComboBox.SelectedIndex == 1)
                    {
                        isSuperuser = true;
                    }
                    else
                    {
                        isSuperuser = false;
                    }

                    StoreCommand(INSERT_USER, connection);
                    command.Parameters.AddWithValue("@firstName", FirstNameTextbox.Text);
                    command.Parameters.AddWithValue("@middleName", MiddleNameTextbox.Text);
                    command.Parameters.AddWithValue("@lastName", LastNameTextbox.Text);
                    command.Parameters.AddWithValue("@email", EmailTextbox.Text);
                    command.Parameters.AddWithValue("@password", PasswordTextbox.Text);
                    command.Parameters.AddWithValue("@date", date);
                    command.Parameters.AddWithValue("isSuperuser", isSuperuser);

                    int rowsAffected = Convert.ToInt32(command.ExecuteNonQuery());
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // For refreshing
                        string GET_ADDED_USER_DATA = "SELECT * FROM users WHERE email=@email";
                        StoreCommand(GET_ADDED_USER_DATA, connection);
                        command.Parameters.AddWithValue("@email", EmailTextbox.Text);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            reader.Read();
                            string id = reader["id"].ToString();
                            string firstName = reader["first_name"].ToString();
                            string middleName = reader["middle_name"].ToString();
                            string lastName = reader["last_name"].ToString() ;
                            string email = reader["email"].ToString();
                            string password = reader["password"].ToString();
                            DateTime dateOnly = (DateTime)reader["date"];
                            bool isSuperUser = (bool)reader["is_superuser"];

                            SuperUserPage.User newUser = new SuperUserPage.User(id, firstName, middleName, lastName, email, password, dateOnly, isSuperUser);
                            superUserPage.usersList.Add(newUser);
                            superUserPage.RefreshUsersFlowPanel();
                        }
                        connection.Close();
                        Close();
                    }
                }
            }
        }

        bool emailIsAvailable;
        private void EmailTextbox_TextChanged(object sender, EventArgs e)
        {
            if (forEditing)
            {
                string CHECK_EMAIL1 = "SELECT * FROM users WHERE email=@email";
                using (MySqlConnection connection = new MySqlConnection(databaseAddress))
                {
                    connection.Open();
                    StoreCommand(CHECK_EMAIL1, connection);
                    command.Parameters.AddWithValue("@email", EmailTextbox.Text);
                    int matchRecord = Convert.ToInt32(command.ExecuteScalar());
                    if (matchRecord > 0 && email != EmailTextbox.Text)
                    {
                        EmailTakenLabel.Visible = true;
                        emailIsAvailable = false;
                    }
                    else
                    {
                        EmailTakenLabel.Visible = false;
                        emailIsAvailable = true;
                    }
                }
                return;
            }
            string CHECK_EMAIL = "SELECT * FROM users WHERE email=@email";
            using(MySqlConnection connection = new MySqlConnection(databaseAddress))
            {
                connection.Open();
                StoreCommand(CHECK_EMAIL, connection);
                command.Parameters.AddWithValue("@email", EmailTextbox.Text);
                int matchRecord = Convert.ToInt32(command.ExecuteScalar());
                if (matchRecord > 0)
                {
                    EmailTakenLabel.Visible = true;
                    emailIsAvailable = false;
                }
                else
                {
                    EmailTakenLabel.Visible = false;
                    emailIsAvailable = true;
                }
            }
        }

        bool passwordMatches;
        private void ConfirmPasswordTextbox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PasswordTextbox.Text) || string.IsNullOrWhiteSpace(ConfirmPasswordTextbox.Text))
            { 
                PasswordCheckLabel.Visible = false; 
            }

            else if (PasswordTextbox.Text != ConfirmPasswordTextbox.Text)
            {
                PasswordCheckLabel.Visible = true;
                PasswordCheckLabel.Text = "Passwords do not match";
                PasswordCheckLabel.ForeColor = Color.Red;
                passwordMatches = false;
            }
            else if (PasswordTextbox.Text ==  ConfirmPasswordTextbox.Text)
            {
                PasswordCheckLabel.Visible = true;
                PasswordCheckLabel.Text = "Password matches";
                PasswordCheckLabel.ForeColor = Color.Green;
                passwordMatches = true;
            }
        }

        private void PasswordTextbox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PasswordTextbox.Text) || string.IsNullOrWhiteSpace(ConfirmPasswordTextbox.Text))
            {
                PasswordCheckLabel.Visible = false;
            }

            else if (PasswordTextbox.Text != ConfirmPasswordTextbox.Text)
            {
                PasswordCheckLabel.Visible = true;
                PasswordCheckLabel.Text = "Passwords do not match";
                PasswordCheckLabel.ForeColor = Color.Red;
                passwordMatches = false;
            }
            else if (PasswordTextbox.Text == ConfirmPasswordTextbox.Text)
            {
                PasswordCheckLabel.Visible = true;
                PasswordCheckLabel.Text = "Password matches";
                PasswordCheckLabel.ForeColor = Color.Green;
                passwordMatches = true;
            }
        }

        private void ShowPasswordImageCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPasswordImageCheckbox.Checked)
            {
                PasswordTextbox.PasswordChar = '\0';
            }
            else if (!ShowPasswordImageCheckbox.Checked)
            {
                PasswordTextbox.PasswordChar = '●';
            }
        }

        private void ShowConfirmPasswordImageCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowConfirmPasswordImageCheckbox.Checked)
            {
                ConfirmPasswordTextbox.PasswordChar = '\0';
            }
            else if (!ShowConfirmPasswordImageCheckbox.Checked)
            {
                ConfirmPasswordTextbox.PasswordChar = '●';
            }
        }
    }
}
