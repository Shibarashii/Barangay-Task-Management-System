using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ComponentFactory.Krypton.Toolkit;
using Guna.UI2.WinForms;

namespace Community_Task_Management_System
{
    public partial class LoginPage : KryptonForm
    {
        /*
                Name Case Legend

            SAMPLE_TEXT = SQL Queries
            sampleText = variables
        */
        MySqlCommand Command;
        MySqlDataReader Reader;
        string databaseAddress = "server=localhost; database=barangay_task_management_system; username=root; password=;";
        public LoginPage()
        {
            InitializeComponent();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(databaseAddress))
                {
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            FormClosing += MainForm_FormClosing;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) // Method for closing all forms to avoid the Task Manager Error
        {
            Application.ExitThread();
        }

        private void StoreCommand(string query, MySqlConnection connection)
        {
            Command = new MySqlCommand(query, connection);
        }



        #region Signing In
        string CHECK_ACCOUNT = "SELECT id, is_superuser FROM users WHERE email=@email AND password=@password";
        private void SignInButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(databaseAddress))
            {
                connection.Open();
                StoreCommand(CHECK_ACCOUNT, connection);
                Command.Parameters.AddWithValue("@email", EmailTextbox.Text);
                Command.Parameters.AddWithValue("@password", PasswordTextbox.Text);

                // Check if input is empty
                if (string.IsNullOrWhiteSpace(EmailTextbox.Text) || string.IsNullOrWhiteSpace(PasswordTextbox.Text))
                {
                    MessageBox.Show("Please fill up all fields");
                }
                else
                {
                    // Check if there is a match in the record
                    int matchRecord = Convert.ToInt32(Command.ExecuteScalar()); // Execute the query CHECK_ACCOUNT
                    if (matchRecord > 0) // matchRecord being greater than 0 means there is a match in the database
                    {
                        Reader = Command.ExecuteReader();
                        if (Reader.Read())
                        {
                            string id = Reader["id"].ToString(); // Read ID

                            SuperUserPage homePage = new SuperUserPage(id);
                            Hide();
                            homePage.Show();
                        }
                    }
                    else
                    {
                        NotFoundLabel.Visible = true;
                    }
                }
            }
        }
        #endregion
        //
        //
        //
        //
        //
        #region Textboxes
        private void EmailTextbox_TextChanged(object sender, EventArgs e)
        {
            NotFoundLabel.Visible = false;
        }
        private void PasswordTextbox_TextChanged(object sender, EventArgs e)
        {
            NotFoundLabel.Visible = false;
        }


        private void EmailTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter) // Check if key is "Enter"
            {
                if (string.IsNullOrEmpty(EmailTextbox.Text))
                {
                    MessageBox.Show("Please enter your email");
                }

                else
                {
                    e.Handled = true;

                    // Move focus to the next control in the tab order
                    SelectNextControl((Control)sender, true, true, true, true);
                }
            }
        }

        private void PasswordTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) // Check if key is "Enter"
            {
                e.Handled = true;

                SignInButton.PerformClick(); // Automatically clicks Sign In Button
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
        #endregion

    }
}
