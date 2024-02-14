namespace TechStore.Admin_Forms
{
    partial class UserManagementForm
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
            btnClose = new Button();
            listBoxUsers = new ListBox();
            btnDeleteUser = new Button();
            btnAddUser = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(364, 416);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 13;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // listBoxUsers
            // 
            listBoxUsers.FormattingEnabled = true;
            listBoxUsers.ItemHeight = 15;
            listBoxUsers.Location = new Point(137, 166);
            listBoxUsers.Name = "listBoxUsers";
            listBoxUsers.Size = new Size(528, 244);
            listBoxUsers.TabIndex = 12;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(406, 137);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(114, 23);
            btnDeleteUser.TabIndex = 11;
            btnDeleteUser.Text = "Delete User";
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(270, 137);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(114, 23);
            btnAddUser.TabIndex = 10;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(445, 69);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(270, 69);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(169, 23);
            txtSearch.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(270, 9);
            label1.Name = "label1";
            label1.Size = new Size(235, 37);
            label1.TabIndex = 7;
            label1.Text = "User Management";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // UserManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(listBoxUsers);
            Controls.Add(btnDeleteUser);
            Controls.Add(btnAddUser);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Name = "UserManagementForm";
            Text = "UserManagementForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private ListBox listBoxUsers;
        private Button btnDeleteUser;
        private Button btnAddUser;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label1;
    }
}