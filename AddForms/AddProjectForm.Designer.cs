namespace Community_Task_Management_System
{
    partial class AddProjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProjectForm));
            this.AddNewProjectButton = new Guna.UI2.WinForms.Guna2Button();
            this.ProjectDescriptionLabel = new Guna.UI.WinForms.GunaLabel();
            this.ProjectDueDateLabel = new Guna.UI.WinForms.GunaLabel();
            this.ProjectNameTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.TaskManagementSystemLabel = new System.Windows.Forms.Label();
            this.AddProjectLabel = new Guna.UI.WinForms.GunaLabel();
            this.ProjectNameLabel = new Guna.UI.WinForms.GunaLabel();
            this.ProjectStartDateLabel = new Guna.UI.WinForms.GunaLabel();
            this.DateNowLabel = new Guna.UI.WinForms.GunaLabel();
            this.DateTimeTimer = new System.Windows.Forms.Timer(this.components);
            this.ProjectDescriptionTextbox = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.TextCountLabel = new Guna.UI.WinForms.GunaLabel();
            this.DueDateButton = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // AddNewProjectButton
            // 
            this.AddNewProjectButton.Animated = true;
            this.AddNewProjectButton.BackColor = System.Drawing.Color.Transparent;
            this.AddNewProjectButton.BorderRadius = 15;
            this.AddNewProjectButton.CheckedState.Parent = this.AddNewProjectButton;
            this.AddNewProjectButton.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AddNewProjectButton.CustomImages.ImageOffset = new System.Drawing.Point(0, -5);
            this.AddNewProjectButton.CustomImages.ImageSize = new System.Drawing.Size(50, 50);
            this.AddNewProjectButton.CustomImages.Parent = this.AddNewProjectButton;
            this.AddNewProjectButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(101)))), ((int)(((byte)(253)))));
            this.AddNewProjectButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewProjectButton.ForeColor = System.Drawing.Color.White;
            this.AddNewProjectButton.HoverState.Parent = this.AddNewProjectButton;
            this.AddNewProjectButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AddNewProjectButton.Location = new System.Drawing.Point(726, 447);
            this.AddNewProjectButton.Name = "AddNewProjectButton";
            this.AddNewProjectButton.ShadowDecoration.Parent = this.AddNewProjectButton;
            this.AddNewProjectButton.Size = new System.Drawing.Size(249, 67);
            this.AddNewProjectButton.TabIndex = 37;
            this.AddNewProjectButton.Text = "Add New Project";
            this.AddNewProjectButton.Click += new System.EventHandler(this.AddNewProjectButton_Click);
            // 
            // ProjectDescriptionLabel
            // 
            this.ProjectDescriptionLabel.AutoSize = true;
            this.ProjectDescriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.ProjectDescriptionLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectDescriptionLabel.Location = new System.Drawing.Point(385, 170);
            this.ProjectDescriptionLabel.Name = "ProjectDescriptionLabel";
            this.ProjectDescriptionLabel.Size = new System.Drawing.Size(128, 24);
            this.ProjectDescriptionLabel.TabIndex = 28;
            this.ProjectDescriptionLabel.Text = "Description";
            // 
            // ProjectDueDateLabel
            // 
            this.ProjectDueDateLabel.AutoSize = true;
            this.ProjectDueDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.ProjectDueDateLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectDueDateLabel.Location = new System.Drawing.Point(39, 250);
            this.ProjectDueDateLabel.Name = "ProjectDueDateLabel";
            this.ProjectDueDateLabel.Size = new System.Drawing.Size(103, 24);
            this.ProjectDueDateLabel.TabIndex = 24;
            this.ProjectDueDateLabel.Text = "Due Date";
            // 
            // ProjectNameTextbox
            // 
            this.ProjectNameTextbox.Animated = true;
            this.ProjectNameTextbox.BackColor = System.Drawing.Color.Transparent;
            this.ProjectNameTextbox.BorderColor = System.Drawing.Color.Gray;
            this.ProjectNameTextbox.BorderRadius = 5;
            this.ProjectNameTextbox.BorderThickness = 2;
            this.ProjectNameTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProjectNameTextbox.DefaultText = "";
            this.ProjectNameTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ProjectNameTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ProjectNameTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProjectNameTextbox.DisabledState.Parent = this.ProjectNameTextbox;
            this.ProjectNameTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProjectNameTextbox.FillColor = System.Drawing.SystemColors.ControlLightLight;
            this.ProjectNameTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProjectNameTextbox.FocusedState.Parent = this.ProjectNameTextbox;
            this.ProjectNameTextbox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectNameTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProjectNameTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProjectNameTextbox.HoverState.Parent = this.ProjectNameTextbox;
            this.ProjectNameTextbox.Location = new System.Drawing.Point(43, 198);
            this.ProjectNameTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProjectNameTextbox.Name = "ProjectNameTextbox";
            this.ProjectNameTextbox.PasswordChar = '\0';
            this.ProjectNameTextbox.PlaceholderText = "";
            this.ProjectNameTextbox.SelectedText = "";
            this.ProjectNameTextbox.ShadowDecoration.Parent = this.ProjectNameTextbox;
            this.ProjectNameTextbox.Size = new System.Drawing.Size(325, 36);
            this.ProjectNameTextbox.TabIndex = 23;
            // 
            // TaskManagementSystemLabel
            // 
            this.TaskManagementSystemLabel.AutoSize = true;
            this.TaskManagementSystemLabel.BackColor = System.Drawing.Color.Transparent;
            this.TaskManagementSystemLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskManagementSystemLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TaskManagementSystemLabel.Location = new System.Drawing.Point(276, 32);
            this.TaskManagementSystemLabel.Name = "TaskManagementSystemLabel";
            this.TaskManagementSystemLabel.Size = new System.Drawing.Size(420, 37);
            this.TaskManagementSystemLabel.TabIndex = 22;
            this.TaskManagementSystemLabel.Text = "Task Management System";
            this.TaskManagementSystemLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AddProjectLabel
            // 
            this.AddProjectLabel.AutoSize = true;
            this.AddProjectLabel.BackColor = System.Drawing.Color.Transparent;
            this.AddProjectLabel.Font = new System.Drawing.Font("Prompt SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProjectLabel.Location = new System.Drawing.Point(25, 101);
            this.AddProjectLabel.Name = "AddProjectLabel";
            this.AddProjectLabel.Size = new System.Drawing.Size(289, 49);
            this.AddProjectLabel.TabIndex = 21;
            this.AddProjectLabel.Text = "Add New Project";
            // 
            // ProjectNameLabel
            // 
            this.ProjectNameLabel.AutoSize = true;
            this.ProjectNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.ProjectNameLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectNameLabel.Location = new System.Drawing.Point(39, 170);
            this.ProjectNameLabel.Name = "ProjectNameLabel";
            this.ProjectNameLabel.Size = new System.Drawing.Size(147, 24);
            this.ProjectNameLabel.TabIndex = 20;
            this.ProjectNameLabel.Text = "Project Name";
            // 
            // ProjectStartDateLabel
            // 
            this.ProjectStartDateLabel.AutoSize = true;
            this.ProjectStartDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.ProjectStartDateLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectStartDateLabel.Location = new System.Drawing.Point(39, 330);
            this.ProjectStartDateLabel.Name = "ProjectStartDateLabel";
            this.ProjectStartDateLabel.Size = new System.Drawing.Size(111, 24);
            this.ProjectStartDateLabel.TabIndex = 38;
            this.ProjectStartDateLabel.Text = "Start Date";
            // 
            // DateNowLabel
            // 
            this.DateNowLabel.AutoSize = true;
            this.DateNowLabel.BackColor = System.Drawing.Color.Transparent;
            this.DateNowLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateNowLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.DateNowLabel.Location = new System.Drawing.Point(39, 368);
            this.DateNowLabel.Name = "DateNowLabel";
            this.DateNowLabel.Size = new System.Drawing.Size(112, 24);
            this.DateNowLabel.TabIndex = 39;
            this.DateNowLabel.Text = "xxxx-xx-xx";
            // 
            // DateTimeTimer
            // 
            this.DateTimeTimer.Tick += new System.EventHandler(this.DateTimeTimer_Tick);
            // 
            // ProjectDescriptionTextbox
            // 
            this.ProjectDescriptionTextbox.Location = new System.Drawing.Point(389, 198);
            this.ProjectDescriptionTextbox.MaxLength = 300;
            this.ProjectDescriptionTextbox.Name = "ProjectDescriptionTextbox";
            this.ProjectDescriptionTextbox.Size = new System.Drawing.Size(557, 224);
            this.ProjectDescriptionTextbox.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.ProjectDescriptionTextbox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ProjectDescriptionTextbox.StateCommon.Border.Rounding = 10;
            this.ProjectDescriptionTextbox.StateCommon.Border.Width = 2;
            this.ProjectDescriptionTextbox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProjectDescriptionTextbox.StateCommon.Content.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectDescriptionTextbox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 5, -1, -1);
            this.ProjectDescriptionTextbox.TabIndex = 40;
            this.ProjectDescriptionTextbox.Text = "";
            this.ProjectDescriptionTextbox.TextChanged += new System.EventHandler(this.DescriptionTextbox_TextChanged);
            // 
            // TextCountLabel
            // 
            this.TextCountLabel.AutoSize = true;
            this.TextCountLabel.BackColor = System.Drawing.Color.Transparent;
            this.TextCountLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextCountLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.TextCountLabel.Location = new System.Drawing.Point(848, 378);
            this.TextCountLabel.Name = "TextCountLabel";
            this.TextCountLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TextCountLabel.Size = new System.Drawing.Size(64, 24);
            this.TextCountLabel.TabIndex = 41;
            this.TextCountLabel.Text = "0/300";
            // 
            // DueDateButton
            // 
            this.DueDateButton.Animated = true;
            this.DueDateButton.BackColor = System.Drawing.Color.Transparent;
            this.DueDateButton.BorderColor = System.Drawing.Color.Gray;
            this.DueDateButton.BorderRadius = 5;
            this.DueDateButton.BorderThickness = 2;
            this.DueDateButton.CheckedState.Parent = this.DueDateButton;
            this.DueDateButton.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DueDateButton.CustomImages.ImageOffset = new System.Drawing.Point(0, -5);
            this.DueDateButton.CustomImages.ImageSize = new System.Drawing.Size(50, 50);
            this.DueDateButton.CustomImages.Parent = this.DueDateButton;
            this.DueDateButton.FillColor = System.Drawing.SystemColors.ControlLightLight;
            this.DueDateButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DueDateButton.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.DueDateButton.HoverState.FillColor = System.Drawing.SystemColors.ControlLightLight;
            this.DueDateButton.HoverState.Parent = this.DueDateButton;
            this.DueDateButton.Image = ((System.Drawing.Image)(resources.GetObject("DueDateButton.Image")));
            this.DueDateButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DueDateButton.ImageSize = new System.Drawing.Size(25, 25);
            this.DueDateButton.Location = new System.Drawing.Point(43, 278);
            this.DueDateButton.Name = "DueDateButton";
            this.DueDateButton.PressedColor = System.Drawing.SystemColors.ControlLightLight;
            this.DueDateButton.ShadowDecoration.Parent = this.DueDateButton;
            this.DueDateButton.Size = new System.Drawing.Size(325, 36);
            this.DueDateButton.TabIndex = 42;
            this.DueDateButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DueDateButton.Click += new System.EventHandler(this.DueDateButton_Click);
            // 
            // AddProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.DueDateButton);
            this.Controls.Add(this.TextCountLabel);
            this.Controls.Add(this.ProjectDescriptionTextbox);
            this.Controls.Add(this.DateNowLabel);
            this.Controls.Add(this.ProjectStartDateLabel);
            this.Controls.Add(this.AddNewProjectButton);
            this.Controls.Add(this.ProjectDescriptionLabel);
            this.Controls.Add(this.ProjectDueDateLabel);
            this.Controls.Add(this.ProjectNameTextbox);
            this.Controls.Add(this.TaskManagementSystemLabel);
            this.Controls.Add(this.AddProjectLabel);
            this.Controls.Add(this.ProjectNameLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddProjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProjectForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button AddNewProjectButton;
        private Guna.UI.WinForms.GunaLabel ProjectDescriptionLabel;
        private Guna.UI.WinForms.GunaLabel ProjectDueDateLabel;
        private Guna.UI2.WinForms.Guna2TextBox ProjectNameTextbox;
        private System.Windows.Forms.Label TaskManagementSystemLabel;
        private Guna.UI.WinForms.GunaLabel AddProjectLabel;
        private Guna.UI.WinForms.GunaLabel ProjectNameLabel;
        private Guna.UI.WinForms.GunaLabel ProjectStartDateLabel;
        private Guna.UI.WinForms.GunaLabel DateNowLabel;
        private System.Windows.Forms.Timer DateTimeTimer;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox ProjectDescriptionTextbox;
        private Guna.UI.WinForms.GunaLabel TextCountLabel;
        private Guna.UI2.WinForms.Guna2Button DueDateButton;
    }
}