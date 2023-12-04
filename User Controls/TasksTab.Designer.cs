namespace Community_Task_Management_System
{
    partial class TasksTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TasksTab));
            this.TasksLabel = new Guna.UI.WinForms.GunaLabel();
            this.TasksShadowPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.AddTaskButton = new Guna.UI2.WinForms.Guna2Button();
            this.ProjectsSearchPicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.TasksSearchTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.TasksSearchLabel = new Guna.UI.WinForms.GunaLabel();
            this.TasksFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.TasksShadowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectsSearchPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // TasksLabel
            // 
            this.TasksLabel.AutoSize = true;
            this.TasksLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TasksLabel.Location = new System.Drawing.Point(24, 34);
            this.TasksLabel.Name = "TasksLabel";
            this.TasksLabel.Size = new System.Drawing.Size(108, 37);
            this.TasksLabel.TabIndex = 10;
            this.TasksLabel.Text = "Tasks";
            // 
            // TasksShadowPanel
            // 
            this.TasksShadowPanel.AutoScroll = true;
            this.TasksShadowPanel.BackColor = System.Drawing.Color.Transparent;
            this.TasksShadowPanel.Controls.Add(this.AddTaskButton);
            this.TasksShadowPanel.Controls.Add(this.ProjectsSearchPicture);
            this.TasksShadowPanel.Controls.Add(this.TasksSearchTextbox);
            this.TasksShadowPanel.Controls.Add(this.TasksSearchLabel);
            this.TasksShadowPanel.Controls.Add(this.TasksFlowPanel);
            this.TasksShadowPanel.EdgeWidth = 2;
            this.TasksShadowPanel.FillColor = System.Drawing.Color.White;
            this.TasksShadowPanel.Location = new System.Drawing.Point(16, 98);
            this.TasksShadowPanel.Name = "TasksShadowPanel";
            this.TasksShadowPanel.ShadowColor = System.Drawing.Color.Black;
            this.TasksShadowPanel.Size = new System.Drawing.Size(996, 451);
            this.TasksShadowPanel.TabIndex = 9;
            // 
            // AddTaskButton
            // 
            this.AddTaskButton.Animated = true;
            this.AddTaskButton.BorderRadius = 5;
            this.AddTaskButton.CheckedState.Parent = this.AddTaskButton;
            this.AddTaskButton.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AddTaskButton.CustomImages.ImageOffset = new System.Drawing.Point(0, -5);
            this.AddTaskButton.CustomImages.ImageSize = new System.Drawing.Size(50, 50);
            this.AddTaskButton.CustomImages.Parent = this.AddTaskButton;
            this.AddTaskButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(101)))), ((int)(((byte)(253)))));
            this.AddTaskButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTaskButton.ForeColor = System.Drawing.Color.White;
            this.AddTaskButton.HoverState.Parent = this.AddTaskButton;
            this.AddTaskButton.Image = ((System.Drawing.Image)(resources.GetObject("AddTaskButton.Image")));
            this.AddTaskButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AddTaskButton.Location = new System.Drawing.Point(767, 27);
            this.AddTaskButton.Name = "AddTaskButton";
            this.AddTaskButton.ShadowDecoration.Parent = this.AddTaskButton;
            this.AddTaskButton.Size = new System.Drawing.Size(209, 53);
            this.AddTaskButton.TabIndex = 4;
            this.AddTaskButton.Text = "Add New Task";
            this.AddTaskButton.Click += new System.EventHandler(this.AddTaskButton_Click);
            // 
            // ProjectsSearchPicture
            // 
            this.ProjectsSearchPicture.BackColor = System.Drawing.Color.Transparent;
            this.ProjectsSearchPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProjectsSearchPicture.BackgroundImage")));
            this.ProjectsSearchPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ProjectsSearchPicture.Location = new System.Drawing.Point(285, 42);
            this.ProjectsSearchPicture.Name = "ProjectsSearchPicture";
            this.ProjectsSearchPicture.ShadowDecoration.Parent = this.ProjectsSearchPicture;
            this.ProjectsSearchPicture.Size = new System.Drawing.Size(20, 20);
            this.ProjectsSearchPicture.TabIndex = 3;
            this.ProjectsSearchPicture.TabStop = false;
            // 
            // TasksSearchTextbox
            // 
            this.TasksSearchTextbox.BorderColor = System.Drawing.Color.Black;
            this.TasksSearchTextbox.BorderRadius = 5;
            this.TasksSearchTextbox.BorderThickness = 2;
            this.TasksSearchTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TasksSearchTextbox.DefaultText = "";
            this.TasksSearchTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TasksSearchTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TasksSearchTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TasksSearchTextbox.DisabledState.Parent = this.TasksSearchTextbox;
            this.TasksSearchTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TasksSearchTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TasksSearchTextbox.FocusedState.Parent = this.TasksSearchTextbox;
            this.TasksSearchTextbox.ForeColor = System.Drawing.Color.Black;
            this.TasksSearchTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TasksSearchTextbox.HoverState.Parent = this.TasksSearchTextbox;
            this.TasksSearchTextbox.Location = new System.Drawing.Point(102, 36);
            this.TasksSearchTextbox.Name = "TasksSearchTextbox";
            this.TasksSearchTextbox.PasswordChar = '\0';
            this.TasksSearchTextbox.PlaceholderText = "";
            this.TasksSearchTextbox.SelectedText = "";
            this.TasksSearchTextbox.ShadowDecoration.Parent = this.TasksSearchTextbox;
            this.TasksSearchTextbox.Size = new System.Drawing.Size(212, 35);
            this.TasksSearchTextbox.TabIndex = 2;
            this.TasksSearchTextbox.TextChanged += new System.EventHandler(this.TasksSearchTextbox_TextChanged);
            // 
            // TasksSearchLabel
            // 
            this.TasksSearchLabel.AutoSize = true;
            this.TasksSearchLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TasksSearchLabel.Location = new System.Drawing.Point(14, 42);
            this.TasksSearchLabel.Name = "TasksSearchLabel";
            this.TasksSearchLabel.Size = new System.Drawing.Size(82, 24);
            this.TasksSearchLabel.TabIndex = 1;
            this.TasksSearchLabel.Text = "Search";
            // 
            // TasksFlowPanel
            // 
            this.TasksFlowPanel.AutoScroll = true;
            this.TasksFlowPanel.Location = new System.Drawing.Point(8, 95);
            this.TasksFlowPanel.Name = "TasksFlowPanel";
            this.TasksFlowPanel.Size = new System.Drawing.Size(988, 346);
            this.TasksFlowPanel.TabIndex = 0;
            // 
            // TasksTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.TasksLabel);
            this.Controls.Add(this.TasksShadowPanel);
            this.Name = "TasksTab";
            this.Size = new System.Drawing.Size(1023, 564);
            this.TasksShadowPanel.ResumeLayout(false);
            this.TasksShadowPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectsSearchPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel TasksLabel;
        private Guna.UI2.WinForms.Guna2ShadowPanel TasksShadowPanel;
        private Guna.UI2.WinForms.Guna2Button AddTaskButton;
        private Guna.UI2.WinForms.Guna2PictureBox ProjectsSearchPicture;
        private Guna.UI2.WinForms.Guna2TextBox TasksSearchTextbox;
        private Guna.UI.WinForms.GunaLabel TasksSearchLabel;
        private System.Windows.Forms.FlowLayoutPanel TasksFlowPanel;
    }
}
