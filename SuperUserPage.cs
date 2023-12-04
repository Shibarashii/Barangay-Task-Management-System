using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ComponentFactory.Krypton.Toolkit;
using System.Collections.Generic;
using Guna.UI2.WinForms;
using System.Diagnostics;
using System.Threading.Tasks;
using Org.BouncyCastle.Asn1.Crmf;

namespace Community_Task_Management_System
{
    public partial class SuperUserPage : KryptonForm
    {
        //
        //
        //  THIS FORM IS DESGINED FOR THE SUPERUSER
        //  However, it also detects if the Access Level is "user"
        //
        //  If that's the case, I created methods and functions just to hide    
        //  the buttons and panels that are only meant for the superuser
        //
        //  It is found in this form's constructor
        //

        MySqlCommand Command;
        string databaseAddress = "server=localhost; database=barangay_task_management_system; username=root; password=;";

        string firstName;
        string middleName;
        string lastName;
        string email;
        string password;
        string id;
        bool thisSuperUser; // Checks if this form is used by a superuser
        DashboardTab DashboardPanel;
        ProjectsTab ProjectsPanel;
        TasksTab TasksPanel;

        public SuperUserPage(string id)
        {
            InitializeComponent();

            using (MySqlConnection connection = new MySqlConnection(databaseAddress))
            {
                connection.Open();
                // Read Data
                //
                // Reads the data using the query GET_USER_DATA
                // Sets the read data to this form's variables (firstName, middleName, lastName, email, password, id)
                //
                string GET_USER_DATA = "SELECT * FROM users WHERE id=@id";
                StoreCommand(GET_USER_DATA, connection);
                Command.Parameters.AddWithValue("@id", id);
                using (MySqlDataReader Reader = Command.ExecuteReader())
                {
                    Reader.Read();
                    this.id = id;
                    firstName = Reader["first_name"].ToString();
                    middleName = Reader["middle_name"].ToString();
                    lastName = Reader["last_name"].ToString();
                    email = Reader["email"].ToString();
                    password = Reader["password"].ToString();
                    thisSuperUser = (bool)Reader["is_superuser"];

                    Reader.Close();
                }
                //
                // Initialize controls properties
                //
                if (!thisSuperUser)
                {
                    UserTypeLabel.Text = "User";
                    UserTypeLabel.Location = new Point(75, 31);
                    UsersButton.Hide();
                }
                DropDownButton.Text = firstName;
                WelcomeLabel.Text = $"Welcome, {firstName}";
                DropDownPanel.Size = new Size(255, 55);
                //
                // Dashboard Panel
                //
                DashboardPanel = new DashboardTab();
                DashboardPanel.Location = new Point(240, 105);
                Controls.Add(DashboardPanel);
                //
                // Tasks Panel
                // 
                TasksPanel = new TasksTab(thisSuperUser, DashboardPanel);
                TasksPanel.Location = new Point(240, 105);
                TasksPanel.Visible = false;
                Controls.Add(TasksPanel);
                //
                // Project Panel
                // 
                ProjectsPanel = new ProjectsTab(thisSuperUser, DashboardPanel, TasksPanel); // Pass Access Level to ProjectsTab
                ProjectsPanel.Location = new Point(240, 105);
                ProjectsPanel.Visible = false;
                Controls.Add(ProjectsPanel);

                TasksPanel.GetProjectsPanel(ProjectsPanel);
                //
                // Users Panel
                // 
                AddToUserList();
                FilterAndDisplayUsers(SearchTextbox.Text);
                connection.Close();
            }


            FormClosing += MainForm_FormClosing; // To close all of the hidden forms when X button is clicked
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e) // Method for closing all forms to avoid the Task Manager Error
        {
            Application.ExitThread();
        }


        #region GENERAL CODE
        private void StoreCommand(string query, MySqlConnection connection)
        {
            Command = new MySqlCommand(query, connection);
        }
        #endregion

        #region DROP DOWN PANEL
        //
        // For animating DropDownPanel
        //
        //
        bool droppedDown = false;
        private void DropDownTimer_Tick(object sender, EventArgs e)
        {
            int minimumHeight = 60;
            int maximumHeight = 156;
            if (!droppedDown)
            {
                DropDownPanel.Height += 10;

                if (DropDownPanel.Height >= maximumHeight)
                {
                    DropDownTimer.Stop();
                    droppedDown = true;
                    DropDownButton.Enabled = true;
                }
            }

            else if (droppedDown)
            {
                DropDownPanel.Height -= 10;
                if (DropDownPanel.Height <= minimumHeight)
                {
                    DropDownTimer.Stop();
                    droppedDown = false;
                    DropDownButton.Enabled = true;
                }
            }
        }

        private void DropDownButton_Click(object sender, EventArgs e)
        {
            if (!DropDownTimer.Enabled)
            {
                DropDownTimer.Start();
            }
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            Hide();
            loginPage.Show();
        }
        #endregion

        #region DASHBOARD TAB
        private void DashboardButton_CheckedChanged(object sender, EventArgs e)
        {
            if (DashboardButton.Checked)
            {
                DashboardPanel.Visible = true;
            }
            else
            {
                DashboardPanel.Visible = false;
            }
        }
        #endregion

        #region PROJECTS TAB
        private void ProjectsButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ProjectsButton.Checked)
            {
                ProjectsPanel.Visible = true;
            }
            else
            {
                ProjectsPanel.Visible = false;
            }
        }
        #endregion

        #region TASKS TAB
        private void TasksButton_CheckedChanged(object sender, EventArgs e)
        {
            if (TasksButton.Checked)
            {
                TasksPanel.Visible = true;
            }
            else
            {
                TasksPanel.Visible = false;
            }
        }
        #endregion

        #region USERS TAB
        private void UsersButton_CheckedChanged(object sender, EventArgs e)
        {
            if (UsersButton.Checked)
            {
                UsersPanel.Visible = true;
            }
            else
            {
                UsersPanel.Visible = false;
            }
        }

        private void AddToUserList()
        {
            string GET_ALL_USER_DATA = "SELECT * FROM users";
            using (MySqlConnection connection = new MySqlConnection(databaseAddress))
            {
                connection.Open();
                StoreCommand(GET_ALL_USER_DATA, connection);
                using (MySqlDataReader reader = Command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string id = reader["id"].ToString();
                        string firstName = reader["first_name"].ToString();
                        string middleName = reader["middle_name"].ToString();
                        string lastName = reader["last_name"].ToString();
                        string email = reader["email"].ToString();
                        string password = reader["password"].ToString();
                        DateTime date = (DateTime)reader["date"];
                        bool isSuperuser = (bool)reader["is_superuser"];

                        User user = new User(id, firstName, middleName, lastName, email, password, date, isSuperuser);
                        usersList.Add(user);
                    }
                    reader.Close();
                }
                connection.Close();
            }
        }


        private void FilterAndDisplayUsers(string searchText)
        {
            LoadingForm loading = new LoadingForm();

            UsersFlowPanel.Controls.Clear(); // Clear existing controls

            Guna2ShadowPanel columnsPanel = new Guna2ShadowPanel()
            {
                ShadowDepth = 50,
                Size = new Size(UsersFlowPanel.Width - 20, 70),
                Margin = new Padding(0, 0, 0, 0)
            };

            // 
            // Labels for Columns Panel
            // 
            Label countLabel = new Label
            {
                Text = "#",
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
                Location = new Point(countLabel.Right - 30, 20)
            };

            Label emailLabel = new Label
            {
                Text = "Email",
                ForeColor = Color.Black,
                Font = new Font("Arial Rounded MT", 12, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(nameLabel.Right + 180, 20)
            };

            Label dateLabel = new Label
            {
                Text = "Date",
                ForeColor = Color.Black,
                Font = new Font("Arial Rounded MT", 12, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(emailLabel.Right + 100, 20)
            };

            Label actionsLabel = new Label
            {
                Text = "Actions",
                ForeColor = Color.Black,
                Font = new Font("Arial Rounded MT", 12, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(dateLabel.Right + 60, 20)
            };

            columnsPanel.Controls.Add(countLabel);
            columnsPanel.Controls.Add(nameLabel);
            columnsPanel.Controls.Add(emailLabel);
            columnsPanel.Controls.Add(dateLabel);
            columnsPanel.Controls.Add(actionsLabel);
            UsersFlowPanel.Controls.Add(columnsPanel);

            int userCount = 0;
            //
            // Display Superusers Only
            //
            if (SuperuserToggle.Checked)
            {
                loading.Show();
                foreach (User user in usersList)
                {
                    userCount++;
                    if (user.isSuperuser)
                    {
                        // Check if the search text matches any part of the user's information
                        if (user.firstName.ToLower().Contains(searchText.ToLower()) ||
                            user.middleName.ToLower().Contains(searchText.ToLower()) ||
                            user.lastName.ToLower().Contains(searchText.ToLower()) ||
                            user.email.ToLower().Contains(searchText.ToLower()) ||
                            user.date.ToString().Contains(searchText.ToLower()))
                        {
                            Guna2ShadowPanel separatorPanel = new Guna2ShadowPanel()
                            {
                                ShadowDepth = 50,
                                Size = new Size(UsersFlowPanel.Width - 20, 70),
                                Margin = new Padding(0, 0, 0, 0)
                            };

                            Label userIdLabel = new Label
                            {
                                Text = userCount.ToString(),
                                ForeColor = Color.Green,
                                Font = new Font("Arial Rounded MT", 12),
                                AutoSize = true,
                                Location = new Point(30, 20)
                            };

                            Label userNameLabel = new Label
                            {
                                Text = $"{user.firstName} {user.middleName} {user.lastName}",
                                ForeColor = Color.Green,
                                Font = new Font("Arial Rounded MT", 12),
                                AutoSize = true,
                                Location = new Point(userIdLabel.Right - 30, 20)
                            };

                            Label userEmailLabel = new Label
                            {
                                Text = user.email,
                                ForeColor = Color.Green,
                                Font = new Font("Arial Rounded MT", 12),
                                AutoSize = true,
                                Location = new Point(userNameLabel.Right + 180, 20)
                            };

                            Label userDateLabel = new Label
                            {
                                Text = user.date.ToString("MM-dd-yyyy"),
                                ForeColor = Color.Green,
                                Font = new Font("Arial Rounded MT", 12),
                                AutoSize = true,
                                Location = new Point(userEmailLabel.Right + 100, 20)
                            };

                            ActionControl actionControl = new ActionControl(user.id, usersList, this, user)
                            {
                                Location = new Point(userDateLabel.Right + 50, 15),
                            };

                            separatorPanel.Controls.Add(userIdLabel);
                            separatorPanel.Controls.Add(userNameLabel);
                            separatorPanel.Controls.Add(userEmailLabel);
                            separatorPanel.Controls.Add(userDateLabel);
                            separatorPanel.Controls.Add(actionControl);
                            UsersFlowPanel.Controls.Add(separatorPanel);
                        }
                    }
                }
            }

            //
            // Display Users Only
            //
            else if (UserToggle.Checked)
            {
                loading.Show();
                foreach (User user in usersList)
                {
                    userCount++;
                    if (!user.isSuperuser)
                    {
                        // Check if the search text matches any part of the user's information
                        if (user.firstName.ToLower().Contains(searchText.ToLower()) ||
                            user.middleName.ToLower().Contains(searchText.ToLower()) ||
                            user.lastName.ToLower().Contains(searchText.ToLower()) ||
                            user.email.ToLower().Contains(searchText.ToLower()) ||
                            user.date.ToString().Contains(searchText.ToLower()))
                        {
                            // If there is a match, create and add controls to display the user
                            Guna2ShadowPanel separatorPanel = new Guna2ShadowPanel()
                            {
                                ShadowDepth = 50,
                                Size = new Size(UsersFlowPanel.Width - 20, 70),
                                Margin = new Padding(0, 0, 0, 0)
                            };

                            // Add controls for user details and actions (similar to your existing code)

                            Label userIdLabel = new Label
                            {
                                Text = userCount.ToString(),
                                ForeColor = Color.Black,
                                Font = new Font("Arial Rounded MT", 12),
                                AutoSize = true,
                                Location = new Point(30, 20)
                            };

                            Label userNameLabel = new Label
                            {
                                Text = $"{user.firstName} {user.middleName} {user.lastName}",
                                ForeColor = Color.Black,
                                Font = new Font("Arial Rounded MT", 12),
                                AutoSize = true,
                                Location = new Point(userIdLabel.Right - 30, 20)
                            };

                            Label userEmailLabel = new Label
                            {
                                Text = user.email,
                                ForeColor = Color.Black,
                                Font = new Font("Arial Rounded MT", 12),
                                AutoSize = true,
                                Location = new Point(userNameLabel.Right + 180, 20)
                            };

                            Label userDateLabel = new Label
                            {
                                Text = user.date.ToString("MM-dd-yyyy"),
                                ForeColor = Color.Black,
                                Font = new Font("Arial Rounded MT", 12),
                                AutoSize = true,
                                Location = new Point(userEmailLabel.Right + 100, 20)
                            };

                            ActionControl actionControl = new ActionControl(user.id, usersList, this, user)
                            {
                                Location = new Point(userDateLabel.Right + 50, 15),
                            };

                            if (user.isSuperuser)
                            {
                                userIdLabel.ForeColor = Color.Green;
                                userNameLabel.ForeColor = Color.Green;
                                userEmailLabel.ForeColor = Color.Green;
                                userDateLabel.ForeColor = Color.Green;
                            }

                            separatorPanel.Controls.Add(userIdLabel);
                            separatorPanel.Controls.Add(userNameLabel);
                            separatorPanel.Controls.Add(userEmailLabel);
                            separatorPanel.Controls.Add(userDateLabel);
                            separatorPanel.Controls.Add(actionControl);
                            UsersFlowPanel.Controls.Add(separatorPanel);
                        }
                    }
                }
            }
            //
            // Display All Users
            //
            else
            {
                foreach (User user in usersList)
                {
                    userCount++;
                    // Check if the search text matches any part of the user's information
                    if (user.firstName.ToLower().Contains(searchText.ToLower()) ||
                        user.middleName.ToLower().Contains(searchText.ToLower()) ||
                        user.lastName.ToLower().Contains(searchText.ToLower()) ||
                        user.email.ToLower().Contains(searchText.ToLower()) ||
                        user.date.ToString().Contains(searchText.ToLower()))
                    {
                        Debug.WriteLine("SSSS");
                        // If there is a match, create and add controls to display the user
                        Guna2ShadowPanel separatorPanel = new Guna2ShadowPanel()
                        {
                            ShadowDepth = 50,
                            Size = new Size(UsersFlowPanel.Width - 20, 70),
                            Margin = new Padding(0, 0, 0, 0)
                        };

                        // Add controls for user details and actions (similar to your existing code)

                        Label userIdLabel = new Label
                        {
                            Text = userCount.ToString(),
                            ForeColor = Color.Black,
                            Font = new Font("Arial Rounded MT", 12),
                            AutoSize = true,
                            Location = new Point(30, 20)
                        };

                        Label userNameLabel = new Label
                        {
                            Text = $"{user.firstName} {user.middleName} {user.lastName}",
                            ForeColor = Color.Black,
                            Font = new Font("Arial Rounded MT", 12),
                            AutoSize = true,
                            AutoEllipsis = true,
                            Location = new Point(userIdLabel.Right - 30, 20)
                        };

                        Label userEmailLabel = new Label
                        {
                            Text = user.email,
                            ForeColor = Color.Black,
                            Font = new Font("Arial Rounded MT", 12),
                            AutoSize = true,
                            AutoEllipsis = true,
                            Location = new Point(userNameLabel.Right + 180, 20)
                        };

                        Label userDateLabel = new Label
                        {
                            Text = user.date.ToString("MM-dd-yyyy"),
                            ForeColor = Color.Black,
                            Font = new Font("Arial Rounded MT", 12),
                            AutoSize = true,
                            Location = new Point(userEmailLabel.Right + 100, 20)
                        };

                        ActionControl actionControl = new ActionControl(user.id, usersList, this, user)
                        {
                            Location = new Point(userDateLabel.Right + 50, 15),
                        };

                        if (user.isSuperuser)
                        {
                            userIdLabel.ForeColor = Color.Green;
                            userNameLabel.ForeColor = Color.Green;
                            userEmailLabel.ForeColor = Color.Green;
                            userDateLabel.ForeColor = Color.Green;
                        }

                        separatorPanel.Controls.Add(userIdLabel);
                        separatorPanel.Controls.Add(userNameLabel);
                        separatorPanel.Controls.Add(userEmailLabel);
                        separatorPanel.Controls.Add(userDateLabel);
                        separatorPanel.Controls.Add(actionControl);
                        UsersFlowPanel.Controls.Add(separatorPanel);
                    }
                }
            }
            loading.Close();
        }

        public void RefreshUsersFlowPanel()
        {
            FilterAndDisplayUsers(string.Empty);
        }

        #region USER CONTROLS

        private void SearchTextbox_TextChanged(object sender, EventArgs e)
        {
            FilterAndDisplayUsers(SearchTextbox.Text);
        }

        private void SuperuserToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (SuperuserToggle.Checked)
            {
                FilterAndDisplayUsers(SearchTextbox.Text);
                UserToggle.Enabled = false;
            }
            else if (!SuperuserToggle.Checked)
            {
                FilterAndDisplayUsers(SearchTextbox.Text);
                UserToggle.Enabled = true;
            }
        }

        private void UserToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (UserToggle.Checked)
            {
                FilterAndDisplayUsers(SearchTextbox.Text);
                SuperuserToggle.Enabled = false;
            }
            else if (!UserToggle.Checked)
            {
                FilterAndDisplayUsers(SearchTextbox.Text);
                SuperuserToggle.Enabled = true;
            }
        }

        private void AddUserButtonn_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm(this, false, thisSuperUser);
            addUserForm.ShowDialog();
        }
        #endregion

        public List<User> usersList = new List<User>();

        public class User
        {
            public string id;
            public string firstName;
            public string middleName;
            public string lastName;
            public string email;
            public string password;
            public DateTime date;
            public bool isSuperuser;

            public User(string id, string firstName, string middleName, string lastName, string email, string password, DateTime date, bool isSuperuser)
            {
                this.id = id;
                this.firstName = firstName;
                this.middleName = middleName;
                this.lastName = lastName;
                this.email = email;
                this.password = password;
                this.date = date;
                this.isSuperuser = isSuperuser;
            }
        }

        #endregion

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            User userToTransfer = usersList.Find(user => user.id == id);
            AddUserForm addUserForm = new AddUserForm(this, true, thisSuperUser, userToTransfer, true);
            addUserForm.ShowDialog();
        }
    }
}
