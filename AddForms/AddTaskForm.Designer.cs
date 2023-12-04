namespace Community_Task_Management_System
{
    partial class AddTaskForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTaskForm));
            this.AddNewTaskButton = new Guna.UI2.WinForms.Guna2Button();
            this.TaskDescriptionLabel = new Guna.UI.WinForms.GunaLabel();
            this.DueDateLabel = new Guna.UI.WinForms.GunaLabel();
            this.TaskNameTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.TaskManagementSystemLabel = new System.Windows.Forms.Label();
            this.AddTaskLabel = new Guna.UI.WinForms.GunaLabel();
            this.TaskNameLabel = new Guna.UI.WinForms.GunaLabel();
            this.DueDateButton = new Guna.UI2.WinForms.Guna2Button();
            this.TextCountLabel = new Guna.UI.WinForms.GunaLabel();
            this.TaskDescriptionTextbox = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.ProjectLabel = new Guna.UI.WinForms.GunaLabel();
            this.ProjectComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
            // 
            // AddNewTaskButton
            // 
            this.AddNewTaskButton.Animated = true;
            this.AddNewTaskButton.BackColor = System.Drawing.Color.Transparent;
            this.AddNewTaskButton.BorderRadius = 15;
            this.AddNewTaskButton.CheckedState.Parent = this.AddNewTaskButton;
            this.AddNewTaskButton.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AddNewTaskButton.CustomImages.ImageOffset = new System.Drawing.Point(0, -5);
            this.AddNewTaskButton.CustomImages.ImageSize = new System.Drawing.Size(50, 50);
            this.AddNewTaskButton.CustomImages.Parent = this.AddNewTaskButton;
            this.AddNewTaskButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(101)))), ((int)(((byte)(253)))));
            this.AddNewTaskButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNewTaskButton.ForeColor = System.Drawing.Color.White;
            this.AddNewTaskButton.HoverState.Parent = this.AddNewTaskButton;
            this.AddNewTaskButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AddNewTaskButton.Location = new System.Drawing.Point(726, 447);
            this.AddNewTaskButton.Name = "AddNewTaskButton";
            this.AddNewTaskButton.ShadowDecoration.Parent = this.AddNewTaskButton;
            this.AddNewTaskButton.Size = new System.Drawing.Size(249, 67);
            this.AddNewTaskButton.TabIndex = 49;
            this.AddNewTaskButton.Text = "Add New Task";
            this.AddNewTaskButton.Click += new System.EventHandler(this.AddNewTaskButton_Click);
            // 
            // TaskDescriptionLabel
            // 
            this.TaskDescriptionLabel.AutoSize = true;
            this.TaskDescriptionLabel.BackColor = System.Drawing.Color.Transparent;
            this.TaskDescriptionLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskDescriptionLabel.Location = new System.Drawing.Point(385, 170);
            this.TaskDescriptionLabel.Name = "TaskDescriptionLabel";
            this.TaskDescriptionLabel.Size = new System.Drawing.Size(234, 24);
            this.TaskDescriptionLabel.TabIndex = 48;
            this.TaskDescriptionLabel.Text = "Description (Optional)";
            // 
            // DueDateLabel
            // 
            this.DueDateLabel.AutoSize = true;
            this.DueDateLabel.BackColor = System.Drawing.Color.Transparent;
            this.DueDateLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DueDateLabel.Location = new System.Drawing.Point(39, 330);
            this.DueDateLabel.Name = "DueDateLabel";
            this.DueDateLabel.Size = new System.Drawing.Size(103, 24);
            this.DueDateLabel.TabIndex = 47;
            this.DueDateLabel.Text = "Due Date";
            // 
            // TaskNameTextbox
            // 
            this.TaskNameTextbox.Animated = true;
            this.TaskNameTextbox.BackColor = System.Drawing.Color.Transparent;
            this.TaskNameTextbox.BorderColor = System.Drawing.Color.Gray;
            this.TaskNameTextbox.BorderRadius = 5;
            this.TaskNameTextbox.BorderThickness = 2;
            this.TaskNameTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TaskNameTextbox.DefaultText = "";
            this.TaskNameTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TaskNameTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TaskNameTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TaskNameTextbox.DisabledState.Parent = this.TaskNameTextbox;
            this.TaskNameTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TaskNameTextbox.FillColor = System.Drawing.SystemColors.ControlLightLight;
            this.TaskNameTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TaskNameTextbox.FocusedState.Parent = this.TaskNameTextbox;
            this.TaskNameTextbox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskNameTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TaskNameTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TaskNameTextbox.HoverState.Parent = this.TaskNameTextbox;
            this.TaskNameTextbox.Location = new System.Drawing.Point(43, 198);
            this.TaskNameTextbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TaskNameTextbox.Name = "TaskNameTextbox";
            this.TaskNameTextbox.PasswordChar = '\0';
            this.TaskNameTextbox.PlaceholderText = "";
            this.TaskNameTextbox.SelectedText = "";
            this.TaskNameTextbox.ShadowDecoration.Parent = this.TaskNameTextbox;
            this.TaskNameTextbox.Size = new System.Drawing.Size(325, 36);
            this.TaskNameTextbox.TabIndex = 46;
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
            this.TaskManagementSystemLabel.TabIndex = 45;
            this.TaskManagementSystemLabel.Text = "Task Management System";
            this.TaskManagementSystemLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AddTaskLabel
            // 
            this.AddTaskLabel.AutoSize = true;
            this.AddTaskLabel.BackColor = System.Drawing.Color.Transparent;
            this.AddTaskLabel.Font = new System.Drawing.Font("Prompt SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTaskLabel.Location = new System.Drawing.Point(25, 101);
            this.AddTaskLabel.Name = "AddTaskLabel";
            this.AddTaskLabel.Size = new System.Drawing.Size(248, 49);
            this.AddTaskLabel.TabIndex = 44;
            this.AddTaskLabel.Text = "Add New Task";
            // 
            // TaskNameLabel
            // 
            this.TaskNameLabel.AutoSize = true;
            this.TaskNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.TaskNameLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskNameLabel.Location = new System.Drawing.Point(39, 170);
            this.TaskNameLabel.Name = "TaskNameLabel";
            this.TaskNameLabel.Size = new System.Drawing.Size(122, 24);
            this.TaskNameLabel.TabIndex = 43;
            this.TaskNameLabel.Text = "Task Name";
            // 
            // DueDateButton
            // 
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
            this.DueDateButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DueDateButton.Location = new System.Drawing.Point(43, 358);
            this.DueDateButton.Name = "DueDateButton";
            this.DueDateButton.PressedColor = System.Drawing.SystemColors.ControlLightLight;
            this.DueDateButton.PressedDepth = 0;
            this.DueDateButton.ShadowDecoration.Parent = this.DueDateButton;
            this.DueDateButton.Size = new System.Drawing.Size(325, 36);
            this.DueDateButton.TabIndex = 54;
            this.DueDateButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.TextCountLabel.TabIndex = 53;
            this.TextCountLabel.Text = "0/300";
            // 
            // TaskDescriptionTextbox
            // 
            this.TaskDescriptionTextbox.Location = new System.Drawing.Point(389, 198);
            this.TaskDescriptionTextbox.MaxLength = 300;
            this.TaskDescriptionTextbox.Name = "TaskDescriptionTextbox";
            this.TaskDescriptionTextbox.Size = new System.Drawing.Size(557, 224);
            this.TaskDescriptionTextbox.StateCommon.Border.Color1 = System.Drawing.Color.Gray;
            this.TaskDescriptionTextbox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.TaskDescriptionTextbox.StateCommon.Border.Rounding = 10;
            this.TaskDescriptionTextbox.StateCommon.Border.Width = 2;
            this.TaskDescriptionTextbox.StateCommon.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TaskDescriptionTextbox.StateCommon.Content.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskDescriptionTextbox.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, 5, -1, -1);
            this.TaskDescriptionTextbox.TabIndex = 52;
            this.TaskDescriptionTextbox.Text = "";
            this.TaskDescriptionTextbox.TextChanged += new System.EventHandler(this.TaskDescriptionTextbox_TextChanged);
            // 
            // ProjectLabel
            // 
            this.ProjectLabel.AutoSize = true;
            this.ProjectLabel.BackColor = System.Drawing.Color.Transparent;
            this.ProjectLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectLabel.Location = new System.Drawing.Point(39, 250);
            this.ProjectLabel.Name = "ProjectLabel";
            this.ProjectLabel.Size = new System.Drawing.Size(83, 24);
            this.ProjectLabel.TabIndex = 55;
            this.ProjectLabel.Text = "Project";
            // 
            // ProjectComboBox
            // 
            this.ProjectComboBox.BackColor = System.Drawing.Color.Transparent;
            this.ProjectComboBox.BorderColor = System.Drawing.Color.Gray;
            this.ProjectComboBox.BorderRadius = 5;
            this.ProjectComboBox.BorderThickness = 2;
            this.ProjectComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ProjectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProjectComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.ProjectComboBox.FocusedState.Parent = this.ProjectComboBox;
            this.ProjectComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ProjectComboBox.FormattingEnabled = true;
            this.ProjectComboBox.HoverState.Parent = this.ProjectComboBox;
            this.ProjectComboBox.ItemHeight = 30;
            this.ProjectComboBox.ItemsAppearance.Parent = this.ProjectComboBox;
            this.ProjectComboBox.Location = new System.Drawing.Point(43, 278);
            this.ProjectComboBox.Name = "ProjectComboBox";
            this.ProjectComboBox.ShadowDecoration.Parent = this.ProjectComboBox;
            this.ProjectComboBox.Size = new System.Drawing.Size(325, 36);
            this.ProjectComboBox.TabIndex = 56;
            this.ProjectComboBox.SelectedIndexChanged += new System.EventHandler(this.ProjectComboBox_SelectedIndexChanged);
            // 
            // AddTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 537);
            this.Controls.Add(this.ProjectComboBox);
            this.Controls.Add(this.ProjectLabel);
            this.Controls.Add(this.AddNewTaskButton);
            this.Controls.Add(this.TaskDescriptionLabel);
            this.Controls.Add(this.DueDateLabel);
            this.Controls.Add(this.TaskNameTextbox);
            this.Controls.Add(this.TaskManagementSystemLabel);
            this.Controls.Add(this.AddTaskLabel);
            this.Controls.Add(this.TaskNameLabel);
            this.Controls.Add(this.DueDateButton);
            this.Controls.Add(this.TextCountLabel);
            this.Controls.Add(this.TaskDescriptionTextbox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddTaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddTaskForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button AddNewTaskButton;
        private Guna.UI.WinForms.GunaLabel TaskDescriptionLabel;
        private Guna.UI.WinForms.GunaLabel DueDateLabel;
        private Guna.UI2.WinForms.Guna2TextBox TaskNameTextbox;
        private System.Windows.Forms.Label TaskManagementSystemLabel;
        private Guna.UI.WinForms.GunaLabel AddTaskLabel;
        private Guna.UI.WinForms.GunaLabel TaskNameLabel;
        private Guna.UI2.WinForms.Guna2Button DueDateButton;
        private Guna.UI.WinForms.GunaLabel TextCountLabel;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox TaskDescriptionTextbox;
        private Guna.UI.WinForms.GunaLabel ProjectLabel;
        private Guna.UI2.WinForms.Guna2ComboBox ProjectComboBox;
    }
}