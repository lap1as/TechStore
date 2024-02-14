namespace TechStore
{
    partial class MainForm
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
            label1 = new Label();
            Button_CategoryManagement = new Button();
            Button_OrderManagement = new Button();
            Button_ProductManagement = new Button();
            Button_UserManagement = new Button();
            label_Statistics = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(246, 9);
            label1.Name = "label1";
            label1.Size = new Size(295, 37);
            label1.TabIndex = 0;
            label1.Text = "TechStore Management";
            // 
            // Button_CategoryManagement
            // 
            Button_CategoryManagement.Location = new Point(269, 84);
            Button_CategoryManagement.Name = "Button_CategoryManagement";
            Button_CategoryManagement.Size = new Size(249, 40);
            Button_CategoryManagement.TabIndex = 1;
            Button_CategoryManagement.Text = "Category Management";
            Button_CategoryManagement.UseVisualStyleBackColor = true;
            Button_CategoryManagement.Click += btnCategoryManagement_Click;
            // 
            // Button_OrderManagement
            // 
            Button_OrderManagement.Location = new Point(270, 130);
            Button_OrderManagement.Name = "Button_OrderManagement";
            Button_OrderManagement.Size = new Size(249, 40);
            Button_OrderManagement.TabIndex = 2;
            Button_OrderManagement.Text = "Order Management";
            Button_OrderManagement.UseVisualStyleBackColor = true;
            Button_OrderManagement.Click += btnOrderManagement_Click;
            // 
            // Button_ProductManagement
            // 
            Button_ProductManagement.Location = new Point(270, 176);
            Button_ProductManagement.Name = "Button_ProductManagement";
            Button_ProductManagement.Size = new Size(249, 40);
            Button_ProductManagement.TabIndex = 3;
            Button_ProductManagement.Text = "Product Management";
            Button_ProductManagement.UseVisualStyleBackColor = true;
            Button_ProductManagement.Click += btnProductManagement_Click;
            // 
            // Button_UserManagement
            // 
            Button_UserManagement.Location = new Point(270, 222);
            Button_UserManagement.Name = "Button_UserManagement";
            Button_UserManagement.Size = new Size(249, 40);
            Button_UserManagement.TabIndex = 4;
            Button_UserManagement.Text = "User Management";
            Button_UserManagement.UseVisualStyleBackColor = true;
            Button_UserManagement.Click += btnUserManagement_Click;
            // 
            // label_Statistics
            // 
            label_Statistics.AutoSize = true;
            label_Statistics.Font = new Font("Segoe UI", 14F);
            label_Statistics.Location = new Point(265, 382);
            label_Statistics.Name = "label_Statistics";
            label_Statistics.Size = new Size(43, 25);
            label_Statistics.TabIndex = 5;
            label_Statistics.Text = "Stat";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label_Statistics);
            Controls.Add(Button_UserManagement);
            Controls.Add(Button_ProductManagement);
            Controls.Add(Button_OrderManagement);
            Controls.Add(Button_CategoryManagement);
            Controls.Add(label1);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Button_CategoryManagement;
        private Button Button_OrderManagement;
        private Button Button_ProductManagement;
        private Button Button_UserManagement;
        private Label label_Statistics;
    }
}