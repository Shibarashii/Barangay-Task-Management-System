namespace Community_Task_Management_System
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.SignInButton = new Guna.UI2.WinForms.Guna2Button();
            this.EmailTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.PasswordTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.NotFoundLabel = new System.Windows.Forms.Label();
            this.ShowPasswordImageCheckbox = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.SuspendLayout();
            // 
            // SignInButton
            // 
            this.SignInButton.Animated = true;
            this.SignInButton.BackColor = System.Drawing.Color.Transparent;
            this.SignInButton.BorderColor = System.Drawing.Color.Transparent;
            this.SignInButton.BorderRadius = 15;
            this.SignInButton.BorderThickness = 2;
            this.SignInButton.CheckedState.Parent = this.SignInButton;
            this.SignInButton.CustomImages.Parent = this.SignInButton;
            this.SignInButton.FillColor = System.Drawing.Color.DodgerBlue;
            this.SignInButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignInButton.ForeColor = System.Drawing.SystemColors.Window;
            this.SignInButton.HoverState.BorderColor = System.Drawing.Color.Cyan;
            this.SignInButton.HoverState.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.SignInButton.HoverState.Parent = this.SignInButton;
            this.SignInButton.Location = new System.Drawing.Point(796, 499);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.PressedColor = System.Drawing.Color.Blue;
            this.SignInButton.ShadowDecoration.Parent = this.SignInButton;
            this.SignInButton.Size = new System.Drawing.Size(213, 76);
            this.SignInButton.TabIndex = 3;
            this.SignInButton.Text = "Sign in";
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // EmailTextbox
            // 
            this.EmailTextbox.BackColor = System.Drawing.Color.Transparent;
            this.EmailTextbox.BorderColor = System.Drawing.Color.Gray;
            this.EmailTextbox.BorderRadius = 15;
            this.EmailTextbox.BorderThickness = 5;
            this.EmailTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailTextbox.DefaultText = "";
            this.EmailTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmailTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmailTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailTextbox.DisabledState.Parent = this.EmailTextbox;
            this.EmailTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmailTextbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.EmailTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailTextbox.FocusedState.Parent = this.EmailTextbox;
            this.EmailTextbox.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTextbox.ForeColor = System.Drawing.Color.Black;
            this.EmailTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmailTextbox.HoverState.Parent = this.EmailTextbox;
            this.EmailTextbox.Location = new System.Drawing.Point(270, 245);
            this.EmailTextbox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.EmailTextbox.Name = "EmailTextbox";
            this.EmailTextbox.PasswordChar = '\0';
            this.EmailTextbox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.EmailTextbox.PlaceholderText = "Email";
            this.EmailTextbox.SelectedText = "";
            this.EmailTextbox.ShadowDecoration.Parent = this.EmailTextbox;
            this.EmailTextbox.Size = new System.Drawing.Size(739, 106);
            this.EmailTextbox.TabIndex = 1;
            this.EmailTextbox.TextOffset = new System.Drawing.Point(15, 0);
            this.EmailTextbox.TextChanged += new System.EventHandler(this.EmailTextbox_TextChanged);
            this.EmailTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmailTextbox_KeyPress);
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.BackColor = System.Drawing.Color.Transparent;
            this.PasswordTextbox.BorderColor = System.Drawing.Color.Gray;
            this.PasswordTextbox.BorderRadius = 15;
            this.PasswordTextbox.BorderThickness = 5;
            this.PasswordTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTextbox.DefaultText = "";
            this.PasswordTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PasswordTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PasswordTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTextbox.DisabledState.Parent = this.PasswordTextbox;
            this.PasswordTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PasswordTextbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PasswordTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTextbox.FocusedState.Parent = this.PasswordTextbox;
            this.PasswordTextbox.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTextbox.ForeColor = System.Drawing.Color.Black;
            this.PasswordTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PasswordTextbox.HoverState.Parent = this.PasswordTextbox;
            this.PasswordTextbox.Location = new System.Drawing.Point(270, 377);
            this.PasswordTextbox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.PasswordChar = '●';
            this.PasswordTextbox.PlaceholderForeColor = System.Drawing.Color.Yellow;
            this.PasswordTextbox.PlaceholderText = "Password";
            this.PasswordTextbox.SelectedText = "";
            this.PasswordTextbox.ShadowDecoration.Parent = this.PasswordTextbox;
            this.PasswordTextbox.Size = new System.Drawing.Size(739, 106);
            this.PasswordTextbox.TabIndex = 2;
            this.PasswordTextbox.TextOffset = new System.Drawing.Point(15, 0);
            this.PasswordTextbox.TextChanged += new System.EventHandler(this.PasswordTextbox_TextChanged);
            this.PasswordTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordTextbox_KeyPress);
            // 
            // NotFoundLabel
            // 
            this.NotFoundLabel.AutoSize = true;
            this.NotFoundLabel.BackColor = System.Drawing.Color.Transparent;
            this.NotFoundLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotFoundLabel.ForeColor = System.Drawing.Color.Red;
            this.NotFoundLabel.Location = new System.Drawing.Point(479, 522);
            this.NotFoundLabel.Name = "NotFoundLabel";
            this.NotFoundLabel.Size = new System.Drawing.Size(299, 37);
            this.NotFoundLabel.TabIndex = 4;
            this.NotFoundLabel.Text = "Account not found";
            this.NotFoundLabel.Visible = false;
            // 
            // ShowPasswordImageCheckbox
            // 
            this.ShowPasswordImageCheckbox.BackColor = System.Drawing.Color.Transparent;
            this.ShowPasswordImageCheckbox.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("ShowPasswordImageCheckbox.CheckedState.Image")));
            this.ShowPasswordImageCheckbox.CheckedState.ImageSize = new System.Drawing.Size(50, 50);
            this.ShowPasswordImageCheckbox.CheckedState.Parent = this.ShowPasswordImageCheckbox;
            this.ShowPasswordImageCheckbox.HoverState.ImageSize = new System.Drawing.Size(50, 50);
            this.ShowPasswordImageCheckbox.HoverState.Parent = this.ShowPasswordImageCheckbox;
            this.ShowPasswordImageCheckbox.Image = ((System.Drawing.Image)(resources.GetObject("ShowPasswordImageCheckbox.Image")));
            this.ShowPasswordImageCheckbox.ImageSize = new System.Drawing.Size(50, 50);
            this.ShowPasswordImageCheckbox.Location = new System.Drawing.Point(922, 406);
            this.ShowPasswordImageCheckbox.Name = "ShowPasswordImageCheckbox";
            this.ShowPasswordImageCheckbox.PressedState.ImageSize = new System.Drawing.Size(50, 50);
            this.ShowPasswordImageCheckbox.PressedState.Parent = this.ShowPasswordImageCheckbox;
            this.ShowPasswordImageCheckbox.Size = new System.Drawing.Size(50, 50);
            this.ShowPasswordImageCheckbox.TabIndex = 5;
            this.ShowPasswordImageCheckbox.UseTransparentBackground = true;
            this.ShowPasswordImageCheckbox.CheckedChanged += new System.EventHandler(this.ShowPasswordImageCheckbox_CheckedChanged);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.ShowPasswordImageCheckbox);
            this.Controls.Add(this.NotFoundLabel);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.EmailTextbox);
            this.Controls.Add(this.SignInButton);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button SignInButton;
        private Guna.UI2.WinForms.Guna2TextBox EmailTextbox;
        private Guna.UI2.WinForms.Guna2TextBox PasswordTextbox;
        private System.Windows.Forms.Label NotFoundLabel;
        private Guna.UI2.WinForms.Guna2ImageCheckBox ShowPasswordImageCheckbox;
    }
}

