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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManagementForm));
            btnClose = new Button();
            btnDeleteUser = new Button();
            btnAddUser = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            label1 = new Label();
            dataGridViewUsers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(46, 250);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 13;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.Location = new Point(4, 186);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(169, 31);
            btnDeleteUser.TabIndex = 11;
            btnDeleteUser.Text = "Delete User";
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(4, 157);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(169, 31);
            btnAddUser.TabIndex = 10;
            btnAddUser.Text = "Add User";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(4, 103);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(169, 31);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(4, 74);
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
            // dataGridViewUsers
            // 
            dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUsers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Location = new Point(179, 74);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.Size = new Size(609, 364);
            dataGridViewUsers.TabIndex = 14;
            // 
            // UserManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewUsers);
            Controls.Add(btnClose);
            Controls.Add(btnDeleteUser);
            Controls.Add(btnAddUser);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "UserManagementForm";
            Text = "UserManagementForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Button btnDeleteUser;
        private Button btnAddUser;
        private Button btnSearch;
        private TextBox txtSearch;
        private Label label1;
        private DataGridView dataGridViewUsers;
    }
}