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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrderForm));
            btnCancel = new Button();
            btnSave = new Button();
            txtQuantity = new TextBox();
            txtOrderDate = new TextBox();
            txtCustomerID = new TextBox();
            txtOrderID = new TextBox();
            lblDescription = new Label();
            lblPrice = new Label();
            lblQuantity = new Label();
            lblName = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtTotalAmount = new TextBox();
            comboBoxProducts = new ComboBox();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(436, 355);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 38;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(317, 355);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 37;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(429, 218);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(100, 23);
            txtQuantity.TabIndex = 35;
            // 
            // txtOrderDate
            // 
            txtOrderDate.Location = new Point(429, 178);
            txtOrderDate.Name = "txtOrderDate";
            txtOrderDate.Size = new Size(100, 23);
            txtOrderDate.TabIndex = 34;
            // 
            // txtCustomerID
            // 
            txtCustomerID.Location = new Point(429, 139);
            txtCustomerID.Name = "txtCustomerID";
            txtCustomerID.Size = new Size(100, 23);
            txtCustomerID.TabIndex = 33;
            // 
            // txtOrderID
            // 
            txtOrderID.Location = new Point(429, 102);
            txtOrderID.Name = "txtOrderID";
            txtOrderID.Size = new Size(100, 23);
            txtOrderID.TabIndex = 32;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 14F);
            lblDescription.Location = new Point(283, 137);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(120, 25);
            lblDescription.TabIndex = 31;
            lblDescription.Text = "Customer ID:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 14F);
            lblPrice.Location = new Point(283, 176);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(109, 25);
            lblPrice.TabIndex = 30;
            lblPrice.Text = "Order Date:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 14F);
            lblQuantity.Location = new Point(283, 216);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(88, 25);
            lblQuantity.TabIndex = 29;
            lblQuantity.Text = "Quantity:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 14F);
            lblName.Location = new Point(283, 100);
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(283, 301);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 39;
            label2.Text = "Product:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(283, 255);
            label3.Name = "label3";
            label3.Size = new Size(128, 25);
            label3.TabIndex = 41;
            label3.Text = "Total Amount:";
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Location = new Point(429, 260);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.Size = new Size(100, 23);
            txtTotalAmount.TabIndex = 42;
            // 
            // comboBoxProducts
            // 
            comboBoxProducts.FormattingEnabled = true;
            comboBoxProducts.Location = new Point(429, 306);
            comboBoxProducts.Name = "comboBoxProducts";
            comboBoxProducts.Size = new Size(100, 23);
            comboBoxProducts.TabIndex = 43;
            // 
            // AddOrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxProducts);
            Controls.Add(txtTotalAmount);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtQuantity);
            Controls.Add(txtOrderDate);
            Controls.Add(txtCustomerID);
            Controls.Add(txtOrderID);
            Controls.Add(lblDescription);
            Controls.Add(lblPrice);
            Controls.Add(lblQuantity);
            Controls.Add(lblName);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddOrderForm";
            Text = "AddOrderForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private TextBox txtQuantity;
        private TextBox txtOrderDate;
        private TextBox txtCustomerID;
        private TextBox txtOrderID;
        private Label lblDescription;
        private Label lblPrice;
        private Label lblQuantity;
        private Label lblName;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTotalAmount;
        private ComboBox comboBoxProducts;
    }
}