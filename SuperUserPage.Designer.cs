namespace Community_Task_Management_System
{
    partial class SuperUserPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuperUserPage));
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.UserTypeLabel = new System.Windows.Forms.Label();
            this.MenuPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.TasksButton = new Guna.UI2.WinForms.Guna2Button();
            this.UsersButton = new Guna.UI2.WinForms.Guna2Button();
            this.ProjectsButton = new Guna.UI2.WinForms.Guna2Button();
            this.DashboardButton = new Guna.UI2.WinForms.Guna2Button();
            this.DropDownButton = new Guna.UI2.WinForms.Guna2Button();
            this.SettingsButton = new Guna.UI2.WinForms.Guna2Button();
            this.LogoutButton = new Guna.UI2.WinForms.Guna2Button();
            this.DropDownTimer = new System.Windows.Forms.Timer(this.components);
            this.DropDownPanel = new System.Windows.Forms.Panel();
            this.UsersShadowPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.UsersOnlyLabel = new Guna.UI.WinForms.GunaLabel();
            this.UserToggle = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.SuperusersOnlyLabel = new Guna.UI.WinForms.GunaLabel();
            this.SuperuserToggle = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.AddUserButtonn = new Guna.UI2.WinForms.Guna2Button();
            this.SearchPicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.SearchTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.SearchLabel = new Guna.UI.WinForms.GunaLabel();
            this.UsersFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.UsersPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.UsersLabel = new Guna.UI.WinForms.GunaLabel();
            this.MenuPanel.SuspendLayout();
            this.DropDownPanel.SuspendLayout();
            this.UsersShadowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPicture)).BeginInit();
            this.UsersPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.WelcomeLabel.Location = new System.Drawing.Point(267, 36);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(268, 37);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Welcome, Name";
            // 
            // UserTypeLabel
            // 
            this.UserTypeLabel.AutoSize = true;
            this.UserTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.UserTypeLabel.Font = new System.Drawing.Font("Prompt", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserTypeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UserTypeLabel.Location = new System.Drawing.Point(54, 31);
            this.UserTypeLabel.Name = "UserTypeLabel";
            this.UserTypeLabel.Size = new System.Drawing.Size(127, 49);
            this.UserTypeLabel.TabIndex = 2;
            this.UserTypeLabel.Text = "ADMIN";
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.Transparent;
            this.MenuPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MenuPanel.Controls.Add(this.TasksButton);
            this.MenuPanel.Controls.Add(this.UsersButton);
            this.MenuPanel.Controls.Add(this.ProjectsButton);
            this.MenuPanel.Controls.Add(this.DashboardButton);
            this.MenuPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MenuPanel.Location = new System.Drawing.Point(0, 105);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.ShadowDecoration.Parent = this.MenuPanel;
            this.MenuPanel.Size = new System.Drawing.Size(235, 577);
            this.MenuPanel.TabIndex = 3;
            // 
            // TasksButton
            // 
            this.TasksButton.Animated = true;
            this.TasksButton.BorderColor = System.Drawing.Color.DimGray;
            this.TasksButton.BorderThickness = 1;
            this.TasksButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.TasksButton.CheckedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.TasksButton.CheckedState.Parent = this.TasksButton;
            this.TasksButton.CustomImages.Parent = this.TasksButton;
            this.TasksButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TasksButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TasksButton.ForeColor = System.Drawing.Color.White;
            this.TasksButton.HoverState.FillColor = System.Drawing.Color.Gray;
            this.TasksButton.HoverState.Parent = this.TasksButton;
            this.TasksButton.Location = new System.Drawing.Point(0, 219);
            this.TasksButton.Name = "TasksButton";
            this.TasksButton.PressedColor = System.Drawing.Color.DodgerBlue;
            this.TasksButton.ShadowDecoration.Parent = this.TasksButton;
            this.TasksButton.Size = new System.Drawing.Size(235, 112);
            this.TasksButton.TabIndex = 7;
            this.TasksButton.Text = "Tasks";
            this.TasksButton.CheckedChanged += new System.EventHandler(this.TasksButton_CheckedChanged);
            // 
            // UsersButton
            // 
            this.UsersButton.Animated = true;
            this.UsersButton.BorderColor = System.Drawing.Color.DimGray;
            this.UsersButton.BorderThickness = 1;
            this.UsersButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.UsersButton.CheckedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.UsersButton.CheckedState.Parent = this.UsersButton;
            this.UsersButton.CustomImages.Parent = this.UsersButton;
            this.UsersButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UsersButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersButton.ForeColor = System.Drawing.Color.White;
            this.UsersButton.HoverState.FillColor = System.Drawing.Color.Gray;
            this.UsersButton.HoverState.Parent = this.UsersButton;
            this.UsersButton.Location = new System.Drawing.Point(0, 330);
            this.UsersButton.Name = "UsersButton";
            this.UsersButton.PressedColor = System.Drawing.Color.DodgerBlue;
            this.UsersButton.ShadowDecoration.Parent = this.UsersButton;
            this.UsersButton.Size = new System.Drawing.Size(235, 112);
            this.UsersButton.TabIndex = 6;
            this.UsersButton.Text = "Users";
            this.UsersButton.CheckedChanged += new System.EventHandler(this.UsersButton_CheckedChanged);
            // 
            // ProjectsButton
            // 
            this.ProjectsButton.Animated = true;
            this.ProjectsButton.BorderColor = System.Drawing.Color.DimGray;
            this.ProjectsButton.BorderThickness = 1;
            this.ProjectsButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.ProjectsButton.CheckedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.ProjectsButton.CheckedState.Parent = this.ProjectsButton;
            this.ProjectsButton.CustomImages.Parent = this.ProjectsButton;
            this.ProjectsButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProjectsButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectsButton.ForeColor = System.Drawing.Color.White;
            this.ProjectsButton.HoverState.FillColor = System.Drawing.Color.Gray;
            this.ProjectsButton.HoverState.Parent = this.ProjectsButton;
            this.ProjectsButton.Location = new System.Drawing.Point(0, 110);
            this.ProjectsButton.Name = "ProjectsButton";
            this.ProjectsButton.PressedColor = System.Drawing.Color.DodgerBlue;
            this.ProjectsButton.ShadowDecoration.Parent = this.ProjectsButton;
            this.ProjectsButton.Size = new System.Drawing.Size(235, 112);
            this.ProjectsButton.TabIndex = 5;
            this.ProjectsButton.Text = "Projects";
            this.ProjectsButton.CheckedChanged += new System.EventHandler(this.ProjectsButton_CheckedChanged);
            // 
            // DashboardButton
            // 
            this.DashboardButton.Animated = true;
            this.DashboardButton.BorderColor = System.Drawing.Color.DimGray;
            this.DashboardButton.BorderThickness = 1;
            this.DashboardButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.DashboardButton.Checked = true;
            this.DashboardButton.CheckedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.DashboardButton.CheckedState.Parent = this.DashboardButton;
            this.DashboardButton.CustomImages.Parent = this.DashboardButton;
            this.DashboardButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DashboardButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DashboardButton.ForeColor = System.Drawing.Color.White;
            this.DashboardButton.HoverState.FillColor = System.Drawing.Color.Gray;
            this.DashboardButton.HoverState.Parent = this.DashboardButton;
            this.DashboardButton.Location = new System.Drawing.Point(0, 0);
            this.DashboardButton.Name = "DashboardButton";
            this.DashboardButton.PressedColor = System.Drawing.Color.DodgerBlue;
            this.DashboardButton.ShadowDecoration.Parent = this.DashboardButton;
            this.DashboardButton.Size = new System.Drawing.Size(235, 112);
            this.DashboardButton.TabIndex = 4;
            this.DashboardButton.Text = "Dashboard";
            this.DashboardButton.CheckedChanged += new System.EventHandler(this.DashboardButton_CheckedChanged);
            // 
            // DropDownButton
            // 
            this.DropDownButton.Animated = true;
            this.DropDownButton.BorderRadius = 10;
            this.DropDownButton.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.ToogleButton;
            this.DropDownButton.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("DropDownButton.CheckedState.Image")));
            this.DropDownButton.CheckedState.Parent = this.DropDownButton;
            this.DropDownButton.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("DropDownButton.CustomImages.Image")));
            this.DropDownButton.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DropDownButton.CustomImages.ImageOffset = new System.Drawing.Point(0, -5);
            this.DropDownButton.CustomImages.ImageSize = new System.Drawing.Size(50, 50);
            this.DropDownButton.CustomImages.Parent = this.DropDownButton;
            this.DropDownButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(101)))), ((int)(((byte)(253)))));
            this.DropDownButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DropDownButton.ForeColor = System.Drawing.Color.White;
            this.DropDownButton.HoverState.Parent = this.DropDownButton;
            this.DropDownButton.Image = ((System.Drawing.Image)(resources.GetObject("DropDownButton.Image")));
            this.DropDownButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DropDownButton.ImageOffset = new System.Drawing.Point(5, 0);
            this.DropDownButton.ImageSize = new System.Drawing.Size(30, 30);
            this.DropDownButton.Location = new System.Drawing.Point(3, 3);
            this.DropDownButton.Name = "DropDownButton";
            this.DropDownButton.ShadowDecoration.Parent = this.DropDownButton;
            this.DropDownButton.Size = new System.Drawing.Size(247, 50);
            this.DropDownButton.TabIndex = 0;
            this.DropDownButton.Text = "Name";
            this.DropDownButton.Click += new System.EventHandler(this.DropDownButton_Click);
            // 
            // SettingsButton
            // 
            this.SettingsButton.Animated = true;
            this.SettingsButton.BorderColor = System.Drawing.Color.Transparent;
            this.SettingsButton.BorderRadius = 10;
            this.SettingsButton.CheckedState.Parent = this.SettingsButton;
            this.SettingsButton.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("SettingsButton.CustomImages.Image")));
            this.SettingsButton.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SettingsButton.CustomImages.ImageOffset = new System.Drawing.Point(5, 0);
            this.SettingsButton.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.SettingsButton.CustomImages.Parent = this.SettingsButton;
            this.SettingsButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(101)))), ((int)(((byte)(253)))));
            this.SettingsButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsButton.ForeColor = System.Drawing.Color.White;
            this.SettingsButton.HoverState.Parent = this.SettingsButton;
            this.SettingsButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SettingsButton.ImageOffset = new System.Drawing.Point(0, -10);
            this.SettingsButton.ImageSize = new System.Drawing.Size(45, 45);
            this.SettingsButton.Location = new System.Drawing.Point(3, 52);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.ShadowDecoration.Parent = this.SettingsButton;
            this.SettingsButton.Size = new System.Drawing.Size(247, 50);
            this.SettingsButton.TabIndex = 1;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Animated = true;
            this.LogoutButton.BorderColor = System.Drawing.Color.Transparent;
            this.LogoutButton.BorderRadius = 10;
            this.LogoutButton.CheckedState.Parent = this.LogoutButton;
            this.LogoutButton.CustomImages.Image = ((System.Drawing.Image)(resources.GetObject("LogoutButton.CustomImages.Image")));
            this.LogoutButton.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.LogoutButton.CustomImages.ImageOffset = new System.Drawing.Point(5, 0);
            this.LogoutButton.CustomImages.ImageSize = new System.Drawing.Size(40, 40);
            this.LogoutButton.CustomImages.Parent = this.LogoutButton;
            this.LogoutButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(101)))), ((int)(((byte)(253)))));
            this.LogoutButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.ForeColor = System.Drawing.Color.White;
            this.LogoutButton.HoverState.Parent = this.LogoutButton;
            this.LogoutButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.LogoutButton.ImageOffset = new System.Drawing.Point(0, -10);
            this.LogoutButton.ImageSize = new System.Drawing.Size(45, 45);
            this.LogoutButton.Location = new System.Drawing.Point(3, 101);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.ShadowDecoration.Parent = this.LogoutButton;
            this.LogoutButton.Size = new System.Drawing.Size(247, 50);
            this.LogoutButton.TabIndex = 2;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // DropDownTimer
            // 
            this.DropDownTimer.Interval = 10;
            this.DropDownTimer.Tick += new System.EventHandler(this.DropDownTimer_Tick);
            // 
            // DropDownPanel
            // 
            this.DropDownPanel.BackColor = System.Drawing.Color.Transparent;
            this.DropDownPanel.Controls.Add(this.SettingsButton);
            this.DropDownPanel.Controls.Add(this.DropDownButton);
            this.DropDownPanel.Controls.Add(this.LogoutButton);
            this.DropDownPanel.Location = new System.Drawing.Point(987, 36);
            this.DropDownPanel.Name = "DropDownPanel";
            this.DropDownPanel.Size = new System.Drawing.Size(255, 156);
            this.DropDownPanel.TabIndex = 5;
            // 
            // UsersShadowPanel
            // 
            this.UsersShadowPanel.AutoScroll = true;
            this.UsersShadowPanel.BackColor = System.Drawing.Color.Transparent;
            this.UsersShadowPanel.Controls.Add(this.UsersOnlyLabel);
            this.UsersShadowPanel.Controls.Add(this.UserToggle);
            this.UsersShadowPanel.Controls.Add(this.SuperusersOnlyLabel);
            this.UsersShadowPanel.Controls.Add(this.SuperuserToggle);
            this.UsersShadowPanel.Controls.Add(this.AddUserButtonn);
            this.UsersShadowPanel.Controls.Add(this.SearchPicture);
            this.UsersShadowPanel.Controls.Add(this.SearchTextbox);
            this.UsersShadowPanel.Controls.Add(this.SearchLabel);
            this.UsersShadowPanel.Controls.Add(this.UsersFlowPanel);
            this.UsersShadowPanel.EdgeWidth = 2;
            this.UsersShadowPanel.FillColor = System.Drawing.Color.White;
            this.UsersShadowPanel.Location = new System.Drawing.Point(16, 98);
            this.UsersShadowPanel.Name = "UsersShadowPanel";
            this.UsersShadowPanel.ShadowColor = System.Drawing.Color.Black;
            this.UsersShadowPanel.Size = new System.Drawing.Size(996, 451);
            this.UsersShadowPanel.TabIndex = 6;
            // 
            // UsersOnlyLabel
            // 
            this.UsersOnlyLabel.AutoSize = true;
            this.UsersOnlyLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersOnlyLabel.Location = new System.Drawing.Point(597, 42);
            this.UsersOnlyLabel.Name = "UsersOnlyLabel";
            this.UsersOnlyLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.UsersOnlyLabel.Size = new System.Drawing.Size(121, 24);
            this.UsersOnlyLabel.TabIndex = 10;
            this.UsersOnlyLabel.Text = "Users Only";
            // 
            // UserToggle
            // 
            this.UserToggle.Animated = true;
            this.UserToggle.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserToggle.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UserToggle.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.UserToggle.CheckedState.InnerColor = System.Drawing.Color.White;
            this.UserToggle.CheckedState.Parent = this.UserToggle;
            this.UserToggle.Location = new System.Drawing.Point(724, 42);
            this.UserToggle.Name = "UserToggle";
            this.UserToggle.ShadowDecoration.Parent = this.UserToggle;
            this.UserToggle.Size = new System.Drawing.Size(50, 30);
            this.UserToggle.TabIndex = 9;
            this.UserToggle.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.UserToggle.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.UserToggle.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.UserToggle.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.UserToggle.UncheckedState.Parent = this.UserToggle;
            this.UserToggle.CheckedChanged += new System.EventHandler(this.UserToggle_CheckedChanged);
            // 
            // SuperusersOnlyLabel
            // 
            this.SuperusersOnlyLabel.AutoSize = true;
            this.SuperusersOnlyLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuperusersOnlyLabel.Location = new System.Drawing.Point(339, 42);
            this.SuperusersOnlyLabel.Name = "SuperusersOnlyLabel";
            this.SuperusersOnlyLabel.Size = new System.Drawing.Size(179, 24);
            this.SuperusersOnlyLabel.TabIndex = 8;
            this.SuperusersOnlyLabel.Text = "Superusers Only";
            // 
            // SuperuserToggle
            // 
            this.SuperuserToggle.Animated = true;
            this.SuperuserToggle.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SuperuserToggle.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SuperuserToggle.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.SuperuserToggle.CheckedState.InnerColor = System.Drawing.Color.White;
            this.SuperuserToggle.CheckedState.Parent = this.SuperuserToggle;
            this.SuperuserToggle.Location = new System.Drawing.Point(524, 42);
            this.SuperuserToggle.Name = "SuperuserToggle";
            this.SuperuserToggle.ShadowDecoration.Parent = this.SuperuserToggle;
            this.SuperuserToggle.Size = new System.Drawing.Size(50, 30);
            this.SuperuserToggle.TabIndex = 7;
            this.SuperuserToggle.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.SuperuserToggle.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.SuperuserToggle.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.SuperuserToggle.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.SuperuserToggle.UncheckedState.Parent = this.SuperuserToggle;
            this.SuperuserToggle.CheckedChanged += new System.EventHandler(this.SuperuserToggle_CheckedChanged);
            // 
            // AddUserButtonn
            // 
            this.AddUserButtonn.Animated = true;
            this.AddUserButtonn.BorderRadius = 5;
            this.AddUserButtonn.CheckedState.Parent = this.AddUserButtonn;
            this.AddUserButtonn.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AddUserButtonn.CustomImages.ImageOffset = new System.Drawing.Point(0, -5);
            this.AddUserButtonn.CustomImages.ImageSize = new System.Drawing.Size(50, 50);
            this.AddUserButtonn.CustomImages.Parent = this.AddUserButtonn;
            this.AddUserButtonn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(101)))), ((int)(((byte)(253)))));
            this.AddUserButtonn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUserButtonn.ForeColor = System.Drawing.Color.White;
            this.AddUserButtonn.HoverState.Parent = this.AddUserButtonn;
            this.AddUserButtonn.Image = ((System.Drawing.Image)(resources.GetObject("AddUserButtonn.Image")));
            this.AddUserButtonn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AddUserButtonn.Location = new System.Drawing.Point(795, 36);
            this.AddUserButtonn.Name = "AddUserButtonn";
            this.AddUserButtonn.ShadowDecoration.Parent = this.AddUserButtonn;
            this.AddUserButtonn.Size = new System.Drawing.Size(186, 41);
            this.AddUserButtonn.TabIndex = 4;
            this.AddUserButtonn.Text = "Add New User";
            this.AddUserButtonn.Click += new System.EventHandler(this.AddUserButtonn_Click);
            // 
            // SearchPicture
            // 
            this.SearchPicture.BackColor = System.Drawing.Color.Transparent;
            this.SearchPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SearchPicture.BackgroundImage")));
            this.SearchPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchPicture.Location = new System.Drawing.Point(285, 42);
            this.SearchPicture.Name = "SearchPicture";
            this.SearchPicture.ShadowDecoration.Parent = this.SearchPicture;
            this.SearchPicture.Size = new System.Drawing.Size(20, 20);
            this.SearchPicture.TabIndex = 3;
            this.SearchPicture.TabStop = false;
            // 
            // SearchTextbox
            // 
            this.SearchTextbox.BorderColor = System.Drawing.Color.Black;
            this.SearchTextbox.BorderRadius = 5;
            this.SearchTextbox.BorderThickness = 2;
            this.SearchTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchTextbox.DefaultText = "";
            this.SearchTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchTextbox.DisabledState.Parent = this.SearchTextbox;
            this.SearchTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchTextbox.FocusedState.Parent = this.SearchTextbox;
            this.SearchTextbox.ForeColor = System.Drawing.Color.Black;
            this.SearchTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchTextbox.HoverState.Parent = this.SearchTextbox;
            this.SearchTextbox.Location = new System.Drawing.Point(102, 36);
            this.SearchTextbox.Name = "SearchTextbox";
            this.SearchTextbox.PasswordChar = '\0';
            this.SearchTextbox.PlaceholderText = "";
            this.SearchTextbox.SelectedText = "";
            this.SearchTextbox.ShadowDecoration.Parent = this.SearchTextbox;
            this.SearchTextbox.Size = new System.Drawing.Size(212, 35);
            this.SearchTextbox.TabIndex = 2;
            this.SearchTextbox.TextChanged += new System.EventHandler(this.SearchTextbox_TextChanged);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLabel.Location = new System.Drawing.Point(14, 42);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(82, 24);
            this.SearchLabel.TabIndex = 1;
            this.SearchLabel.Text = "Search";
            // 
            // UsersFlowPanel
            // 
            this.UsersFlowPanel.AutoScroll = true;
            this.UsersFlowPanel.Location = new System.Drawing.Point(8, 95);
            this.UsersFlowPanel.Name = "UsersFlowPanel";
            this.UsersFlowPanel.Size = new System.Drawing.Size(988, 346);
            this.UsersFlowPanel.TabIndex = 0;
            // 
            // UsersPanel
            // 
            this.UsersPanel.BackColor = System.Drawing.Color.Transparent;
            this.UsersPanel.Controls.Add(this.UsersLabel);
            this.UsersPanel.Controls.Add(this.UsersShadowPanel);
            this.UsersPanel.Location = new System.Drawing.Point(240, 105);
            this.UsersPanel.Name = "UsersPanel";
            this.UsersPanel.ShadowDecoration.Parent = this.UsersPanel;
            this.UsersPanel.Size = new System.Drawing.Size(1023, 564);
            this.UsersPanel.TabIndex = 7;
            this.UsersPanel.Visible = false;
            // 
            // UsersLabel
            // 
            this.UsersLabel.AutoSize = true;
            this.UsersLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsersLabel.Location = new System.Drawing.Point(27, 34);
            this.UsersLabel.Name = "UsersLabel";
            this.UsersLabel.Size = new System.Drawing.Size(108, 37);
            this.UsersLabel.TabIndex = 0;
            this.UsersLabel.Text = "Users";
            // 
            // SuperUserPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.DropDownPanel);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.UserTypeLabel);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.UsersPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SuperUserPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Superuser Page";
            this.MenuPanel.ResumeLayout(false);
            this.DropDownPanel.ResumeLayout(false);
            this.UsersShadowPanel.ResumeLayout(false);
            this.UsersShadowPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchPicture)).EndInit();
            this.UsersPanel.ResumeLayout(false);
            this.UsersPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label UserTypeLabel;
        private Guna.UI2.WinForms.Guna2Panel MenuPanel;
        private Guna.UI2.WinForms.Guna2Button DashboardButton;
        private Guna.UI2.WinForms.Guna2Button TasksButton;
        private Guna.UI2.WinForms.Guna2Button UsersButton;
        private Guna.UI2.WinForms.Guna2Button ProjectsButton;
        private Guna.UI2.WinForms.Guna2Button DropDownButton;
        private Guna.UI2.WinForms.Guna2Button LogoutButton;
        private Guna.UI2.WinForms.Guna2Button SettingsButton;
        private System.Windows.Forms.Timer DropDownTimer;
        private System.Windows.Forms.Panel DropDownPanel;
        private Guna.UI2.WinForms.Guna2ShadowPanel UsersShadowPanel;
        private System.Windows.Forms.FlowLayoutPanel UsersFlowPanel;
        private Guna.UI2.WinForms.Guna2TextBox SearchTextbox;
        private Guna.UI.WinForms.GunaLabel SearchLabel;
        private Guna.UI2.WinForms.Guna2PictureBox SearchPicture;
        private Guna.UI2.WinForms.Guna2Button AddUserButtonn;
        private Guna.UI2.WinForms.Guna2ToggleSwitch SuperuserToggle;
        private Guna.UI2.WinForms.Guna2Panel UsersPanel;
        private Guna.UI.WinForms.GunaLabel UsersLabel;
        private Guna.UI.WinForms.GunaLabel SuperusersOnlyLabel;
        private Guna.UI.WinForms.GunaLabel UsersOnlyLabel;
        private Guna.UI2.WinForms.Guna2ToggleSwitch UserToggle;
    }
}