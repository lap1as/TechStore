namespace TechStore.Admin_Forms
{
    partial class AddOrderForm
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
            btnCancel = new Button();
            btnSave = new Button();
            txtTotalAmount = new TextBox();
            txtOrderDate = new TextBox();
            txtCustomerID = new TextBox();
            txtOrderID = new TextBox();
            lblDescription = new Label();
            lblPrice = new Label();
            lblQuantity = new Label();
            lblName = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(436, 342);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 38;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(317, 342);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 37;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Location = new Point(429, 260);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.Size = new Size(100, 23);
            txtTotalAmount.TabIndex = 35;
            // 
            // txtOrderDate
            // 
            txtOrderDate.Location = new Point(429, 220);
            txtOrderDate.Name = "txtOrderDate";
            txtOrderDate.Size = new Size(100, 23);
            txtOrderDate.TabIndex = 34;
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(429, 181);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(100, 23);
            txtCustomerID.TabIndex = 33;
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new Point(429, 144);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(100, 23);
            txtOrderID.TabIndex = 32;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 14F);
            lblDescription.Location = new Point(283, 179);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(120, 25);
            lblDescription.TabIndex = 31;
            lblDescription.Text = "Customer ID:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 14F);
            lblPrice.Location = new Point(283, 218);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(109, 25);
            lblPrice.TabIndex = 30;
            lblPrice.Text = "Order Date:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 14F);
            lblQuantity.Location = new Point(283, 258);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(128, 25);
            lblQuantity.TabIndex = 29;
            lblQuantity.Text = "Total Amount:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 14F);
            lblName.Location = new Point(283, 142);
            lblName.Name = "lblName";
            lblName.Size = new Size(88, 25);
            lblName.TabIndex = 27;
            lblName.Text = "Order ID:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(342, 51);
            label1.Name = "label1";
            label1.Size = new Size(141, 37);
            label1.TabIndex = 26;
            label1.Text = "Add Order";
            // 
            // AddOrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtTotalAmount);
            Controls.Add(txtOrderDate);
            Controls.Add(txtCustomerID);
            Controls.Add(txtOrderID);
            Controls.Add(lblDescription);
            Controls.Add(lblPrice);
            Controls.Add(lblQuantity);
            Controls.Add(lblName);
            Controls.Add(label1);
            Name = "AddOrderForm";
            Text = "AddOrderForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private TextBox txtTotalAmount;
        private TextBox txtOrderDate;
        private TextBox txtCustomerID;
        private TextBox txtOrderID;
        private Label lblDescription;
        private Label lblPrice;
        private Label lblQuantity;
        private Label lblName;
        private Label label1;
    }
}