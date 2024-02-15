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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderManagementForm));
            label1 = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnAddOrder = new Button();
            btnDeleteOrder = new Button();
            btnClose = new Button();
            dataGridViewOrders = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).BeginInit();
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
            txtSearch.Location = new Point(12, 93);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(169, 23);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(12, 122);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(169, 34);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAddOrder
            // 
            btnAddOrder.Location = new Point(12, 183);
            btnAddOrder.Name = "btnAddOrder";
            btnAddOrder.Size = new Size(169, 34);
            btnAddOrder.TabIndex = 3;
            btnAddOrder.Text = "Add Order";
            btnAddOrder.UseVisualStyleBackColor = true;
            btnAddOrder.Click += btnAddOrder_Click;
            // 
            // btnDeleteOrder
            // 
            btnDeleteOrder.Location = new Point(12, 212);
            btnDeleteOrder.Name = "btnDeleteOrder";
            btnDeleteOrder.Size = new Size(169, 34);
            btnDeleteOrder.TabIndex = 4;
            btnDeleteOrder.Text = "Delete Order";
            btnDeleteOrder.UseVisualStyleBackColor = true;
            btnDeleteOrder.Click += btnDeleteOrder_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(64, 270);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 6;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dataGridViewOrders
            // 
            dataGridViewOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewOrders.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrders.Location = new Point(216, 93);
            dataGridViewOrders.Name = "dataGridViewOrders";
            dataGridViewOrders.Size = new Size(572, 345);
            dataGridViewOrders.TabIndex = 7;
            // 
            // OrderManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewOrders);
            Controls.Add(btnClose);
            Controls.Add(btnDeleteOrder);
            Controls.Add(btnAddOrder);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "OrderManagementForm";
            Text = "OrderManagementForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnAddOrder;
        private Button btnDeleteOrder;
        private Button btnClose;
        private DataGridView dataGridViewOrders;
    }
}