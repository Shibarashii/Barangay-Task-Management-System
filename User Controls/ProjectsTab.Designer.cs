namespace Community_Task_Management_System
{
    partial class ProjectsTab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectsTab));
            this.ProjectsShadowPanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.AddProjectButton = new Guna.UI2.WinForms.Guna2Button();
            this.ProjectsSearchPicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ProjectsSearchTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.ProjectsSearchLabel = new Guna.UI.WinForms.GunaLabel();
            this.ProjectsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ProjectsLabel = new Guna.UI.WinForms.GunaLabel();
            this.ProjectsShadowPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectsSearchPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // ProjectsShadowPanel
            // 
            this.ProjectsShadowPanel.AutoScroll = true;
            this.ProjectsShadowPanel.BackColor = System.Drawing.Color.Transparent;
            this.ProjectsShadowPanel.Controls.Add(this.AddProjectButton);
            this.ProjectsShadowPanel.Controls.Add(this.ProjectsSearchPicture);
            this.ProjectsShadowPanel.Controls.Add(this.ProjectsSearchTextbox);
            this.ProjectsShadowPanel.Controls.Add(this.ProjectsSearchLabel);
            this.ProjectsShadowPanel.Controls.Add(this.ProjectsFlowPanel);
            this.ProjectsShadowPanel.EdgeWidth = 2;
            this.ProjectsShadowPanel.FillColor = System.Drawing.Color.White;
            this.ProjectsShadowPanel.Location = new System.Drawing.Point(16, 98);
            this.ProjectsShadowPanel.Name = "ProjectsShadowPanel";
            this.ProjectsShadowPanel.ShadowColor = System.Drawing.Color.Black;
            this.ProjectsShadowPanel.Size = new System.Drawing.Size(996, 451);
            this.ProjectsShadowPanel.TabIndex = 7;
            // 
            // AddProjectButton
            // 
            this.AddProjectButton.Animated = true;
            this.AddProjectButton.BorderRadius = 5;
            this.AddProjectButton.CheckedState.Parent = this.AddProjectButton;
            this.AddProjectButton.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AddProjectButton.CustomImages.ImageOffset = new System.Drawing.Point(0, -5);
            this.AddProjectButton.CustomImages.ImageSize = new System.Drawing.Size(50, 50);
            this.AddProjectButton.CustomImages.Parent = this.AddProjectButton;
            this.AddProjectButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(101)))), ((int)(((byte)(253)))));
            this.AddProjectButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProjectButton.ForeColor = System.Drawing.Color.White;
            this.AddProjectButton.HoverState.Parent = this.AddProjectButton;
            this.AddProjectButton.Image = ((System.Drawing.Image)(resources.GetObject("AddProjectButton.Image")));
            this.AddProjectButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AddProjectButton.Location = new System.Drawing.Point(767, 27);
            this.AddProjectButton.Name = "AddProjectButton";
            this.AddProjectButton.ShadowDecoration.Parent = this.AddProjectButton;
            this.AddProjectButton.Size = new System.Drawing.Size(209, 53);
            this.AddProjectButton.TabIndex = 4;
            this.AddProjectButton.Text = "Add New Project";
            this.AddProjectButton.Click += new System.EventHandler(this.AddProjectButton_Click);
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
            // ProjectsSearchTextbox
            // 
            this.ProjectsSearchTextbox.BorderColor = System.Drawing.Color.Black;
            this.ProjectsSearchTextbox.BorderRadius = 5;
            this.ProjectsSearchTextbox.BorderThickness = 2;
            this.ProjectsSearchTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProjectsSearchTextbox.DefaultText = "";
            this.ProjectsSearchTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ProjectsSearchTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ProjectsSearchTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProjectsSearchTextbox.DisabledState.Parent = this.ProjectsSearchTextbox;
            this.ProjectsSearchTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProjectsSearchTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProjectsSearchTextbox.FocusedState.Parent = this.ProjectsSearchTextbox;
            this.ProjectsSearchTextbox.ForeColor = System.Drawing.Color.Black;
            this.ProjectsSearchTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProjectsSearchTextbox.HoverState.Parent = this.ProjectsSearchTextbox;
            this.ProjectsSearchTextbox.Location = new System.Drawing.Point(102, 36);
            this.ProjectsSearchTextbox.Name = "ProjectsSearchTextbox";
            this.ProjectsSearchTextbox.PasswordChar = '\0';
            this.ProjectsSearchTextbox.PlaceholderText = "";
            this.ProjectsSearchTextbox.SelectedText = "";
            this.ProjectsSearchTextbox.ShadowDecoration.Parent = this.ProjectsSearchTextbox;
            this.ProjectsSearchTextbox.Size = new System.Drawing.Size(212, 35);
            this.ProjectsSearchTextbox.TabIndex = 2;
            this.ProjectsSearchTextbox.TextChanged += new System.EventHandler(this.ProjectsSearchTextbox_TextChanged);
            // 
            // ProjectsSearchLabel
            // 
            this.ProjectsSearchLabel.AutoSize = true;
            this.ProjectsSearchLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectsSearchLabel.Location = new System.Drawing.Point(14, 42);
            this.ProjectsSearchLabel.Name = "ProjectsSearchLabel";
            this.ProjectsSearchLabel.Size = new System.Drawing.Size(82, 24);
            this.ProjectsSearchLabel.TabIndex = 1;
            this.ProjectsSearchLabel.Text = "Search";
            // 
            // ProjectsFlowPanel
            // 
            this.ProjectsFlowPanel.AutoScroll = true;
            this.ProjectsFlowPanel.Location = new System.Drawing.Point(8, 95);
            this.ProjectsFlowPanel.Name = "ProjectsFlowPanel";
            this.ProjectsFlowPanel.Size = new System.Drawing.Size(988, 346);
            this.ProjectsFlowPanel.TabIndex = 0;
            // 
            // ProjectsLabel
            // 
            this.ProjectsLabel.AutoSize = true;
            this.ProjectsLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectsLabel.Location = new System.Drawing.Point(24, 34);
            this.ProjectsLabel.Name = "ProjectsLabel";
            this.ProjectsLabel.Size = new System.Drawing.Size(146, 37);
            this.ProjectsLabel.TabIndex = 8;
            this.ProjectsLabel.Text = "Projects";
            // 
            // ProjectsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.ProjectsLabel);
            this.Controls.Add(this.ProjectsShadowPanel);
            this.Name = "ProjectsTab";
            this.Size = new System.Drawing.Size(1023, 564);
            this.ProjectsShadowPanel.ResumeLayout(false);
            this.ProjectsShadowPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectsSearchPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel ProjectsShadowPanel;
        private Guna.UI.WinForms.GunaLabel ProjectsLabel;
        private System.Windows.Forms.FlowLayoutPanel ProjectsFlowPanel;
        private Guna.UI2.WinForms.Guna2Button AddProjectButton;
        private Guna.UI2.WinForms.Guna2PictureBox ProjectsSearchPicture;
        private Guna.UI2.WinForms.Guna2TextBox ProjectsSearchTextbox;
        private Guna.UI.WinForms.GunaLabel ProjectsSearchLabel;
    }
}
