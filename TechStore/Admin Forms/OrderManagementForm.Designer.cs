namespace TechStore.Admin_Forms
{
    partial class OrderManagementForm
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
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnAddOrder = new Button();
            btnDeleteOrder = new Button();
            listBoxOrders = new ListBox();
            btnClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(285, 9);
            label1.Name = "label1";
            label1.Size = new Size(250, 37);
            label1.TabIndex = 0;
            label1.Text = "Order Management";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(285, 67);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(169, 23);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(460, 67);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAddOrder
            // 
            btnAddOrder.Location = new Point(285, 135);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(114, 23);
            btnAddOrder.TabIndex = 3;
            btnAddOrder.Text = "Add Order";
            btnAddOrder.UseVisualStyleBackColor = true;
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // btnDeleteOrder
            // 
            btnDeleteOrder.Location = new Point(421, 135);
            btnDeleteOrder.Name = "btnDeleteOrder";
            btnDeleteOrder.Size = new Size(114, 23);
            btnDeleteOrder.TabIndex = 4;
            btnDeleteOrder.Text = "Delete Order";
            btnDeleteOrder.UseVisualStyleBackColor = true;
            btnDeleteOrder.Click += btnDeleteOrder_Click;
            // 
            // listBoxOrders
            // 
            listBoxOrders.FormattingEnabled = true;
            listBoxOrders.ItemHeight = 15;
            listBoxOrders.Location = new Point(157, 164);
            listBoxOrders.Name = "listBoxOrders";
            listBoxOrders.Size = new Size(517, 244);
            listBoxOrders.TabIndex = 5;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(379, 414);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // OrderManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClose);
            Controls.Add(listBoxOrders);
            Controls.Add(btnDeleteOrder);
            Controls.Add(btnAddOrder);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Name = "OrderManagementForm";
            Text = "OrderManagementForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnAddOrder;
        private Button btnDeleteOrder;
        private ListBox listBoxOrders;
        private Button btnClose;
    }
}