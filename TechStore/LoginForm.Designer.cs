namespace TechStore
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            btn_login = new Button();
            lab_username = new Label();
            lab_password = new Label();
            CheckConnectionButton = new Button();
            SuspendLayout();
            // 
            // usernameTextBox
            // 
            usernameTextBox.Anchor = AnchorStyles.None;
            usernameTextBox.Location = new Point(358, 138);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(100, 23);
            usernameTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(358, 167);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(100, 23);
            passwordTextBox.TabIndex = 1;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // btn_login
            // 
            btn_login.Location = new Point(371, 207);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(75, 23);
            btn_login.TabIndex = 2;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // lab_username
            // 
            lab_username.AutoSize = true;
            lab_username.Font = new Font("Segoe UI", 10F);
            lab_username.Location = new Point(284, 139);
            lab_username.Name = "lab_username";
            lab_username.Size = new Size(74, 19);
            lab_username.TabIndex = 3;
            lab_username.Text = "Username:";
            // 
            // lab_password
            // 
            lab_password.AutoSize = true;
            lab_password.Font = new Font("Segoe UI", 10F);
            lab_password.Location = new Point(288, 168);
            lab_password.Name = "lab_password";
            lab_password.Size = new Size(70, 19);
            lab_password.TabIndex = 4;
            lab_password.Text = "Password:";
            // 
            // CheckConnectionButton
            // 
            CheckConnectionButton.Location = new Point(350, 248);
            CheckConnectionButton.Name = "CheckConnectionButton";
            CheckConnectionButton.Size = new Size(116, 23);
            CheckConnectionButton.TabIndex = 5;
            CheckConnectionButton.Text = "Check Connection";
            CheckConnectionButton.UseVisualStyleBackColor = true;
            CheckConnectionButton.Click += CheckConnectionButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CheckConnectionButton);
            Controls.Add(lab_password);
            Controls.Add(lab_username);
            Controls.Add(btn_login);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Button btn_login;
        private Label lab_username;
        private Label lab_password;
        private Button CheckConnectionButton;
    }
}