namespace TechStore.Admin_Forms
{
    partial class AddProductForm
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
            txtCategory = new TextBox();
            txtQuantity = new TextBox();
            txtPrice = new TextBox();
            txtDescription = new TextBox();
            txtName = new TextBox();
            lblDescription = new Label();
            lblPrice = new Label();
            lblQuantity = new Label();
            lblCategory = new Label();
            lblName = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(433, 375);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 25;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(314, 375);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 24;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(423, 307);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(100, 23);
            txtCategory.TabIndex = 23;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(423, 265);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(100, 23);
            txtQuantity.TabIndex = 22;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(423, 225);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 21;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(423, 186);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(100, 23);
            txtDescription.TabIndex = 20;
            // 
            // txtName
            // 
            txtName.Location = new Point(423, 149);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 19;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 14F);
            lblDescription.Location = new Point(277, 184);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(112, 25);
            lblDescription.TabIndex = 18;
            lblDescription.Text = "Description:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 14F);
            lblPrice.Location = new Point(277, 223);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(58, 25);
            lblPrice.TabIndex = 17;
            lblPrice.Text = "Price:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 14F);
            lblQuantity.Location = new Point(277, 263);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(88, 25);
            lblQuantity.TabIndex = 16;
            lblQuantity.Text = "Quantity:";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 14F);
            lblCategory.Location = new Point(277, 305);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(110, 25);
            lblCategory.TabIndex = 15;
            lblCategory.Text = "CategoryID:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 14F);
            lblName.Location = new Point(277, 147);
            lblName.Name = "lblName";
            lblName.Size = new Size(66, 25);
            lblName.TabIndex = 14;
            lblName.Text = "Name:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(282, 53);
            label1.Name = "label1";
            label1.Size = new Size(226, 37);
            label1.TabIndex = 13;
            label1.Text = "Add New Product";
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtCategory);
            Controls.Add(txtQuantity);
            Controls.Add(txtPrice);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(lblDescription);
            Controls.Add(lblPrice);
            Controls.Add(lblQuantity);
            Controls.Add(lblCategory);
            Controls.Add(lblName);
            Controls.Add(label1);
            Name = "AddProductForm";
            Text = "AddProductForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private TextBox txtCategory;
        private TextBox txtQuantity;
        private TextBox txtPrice;
        private TextBox txtDescription;
        private TextBox txtName;
        private Label lblDescription;
        private Label lblPrice;
        private Label lblQuantity;
        private Label lblCategory;
        private Label lblName;
        private Label label1;
    }
}