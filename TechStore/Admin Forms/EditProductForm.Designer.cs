namespace TechStore.Admin_Forms
{
    partial class EditProductForm
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
            lblNameEdit = new Label();
            lblDescriptionEdit = new Label();
            lblPriceEdit = new Label();
            lblQuantityEdit = new Label();
            lblCategoryEdit = new Label();
            txtName = new TextBox();
            txtDescription = new TextBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            txtCategory = new TextBox();
            btnSaveEdit = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(268, 34);
            label1.Name = "label1";
            label1.Size = new Size(250, 37);
            label1.TabIndex = 0;
            label1.Text = "Edit Product Details";
            // 
            // lblNameEdit
            // 
            lblNameEdit.AutoSize = true;
            lblNameEdit.Font = new Font("Segoe UI", 14F);
            lblNameEdit.Location = new Point(262, 105);
            lblNameEdit.Name = "lblNameEdit";
            lblNameEdit.Size = new Size(66, 25);
            lblNameEdit.TabIndex = 1;
            lblNameEdit.Text = "Name:";
            // 
            // lblDescriptionEdit
            // 
            lblDescriptionEdit.AutoSize = true;
            lblDescriptionEdit.Font = new Font("Segoe UI", 14F);
            lblDescriptionEdit.Location = new Point(262, 144);
            lblDescriptionEdit.Name = "lblDescriptionEdit";
            lblDescriptionEdit.Size = new Size(112, 25);
            lblDescriptionEdit.TabIndex = 2;
            lblDescriptionEdit.Text = "Description:";
            // 
            // lblPriceEdit
            // 
            lblPriceEdit.AutoSize = true;
            lblPriceEdit.Font = new Font("Segoe UI", 14F);
            lblPriceEdit.Location = new Point(262, 181);
            lblPriceEdit.Name = "lblPriceEdit";
            lblPriceEdit.Size = new Size(58, 25);
            lblPriceEdit.TabIndex = 3;
            lblPriceEdit.Text = "Price:";
            // 
            // lblQuantityEdit
            // 
            lblQuantityEdit.AutoSize = true;
            lblQuantityEdit.Font = new Font("Segoe UI", 14F);
            lblQuantityEdit.Location = new Point(262, 220);
            lblQuantityEdit.Name = "lblQuantityEdit";
            lblQuantityEdit.Size = new Size(88, 25);
            lblQuantityEdit.TabIndex = 4;
            lblQuantityEdit.Text = "Quantity:";
            // 
            // lblCategoryEdit
            // 
            lblCategoryEdit.AutoSize = true;
            lblCategoryEdit.Font = new Font("Segoe UI", 14F);
            lblCategoryEdit.Location = new Point(262, 259);
            lblCategoryEdit.Name = "lblCategoryEdit";
            lblCategoryEdit.Size = new Size(92, 25);
            lblCategoryEdit.TabIndex = 5;
            lblCategoryEdit.Text = "Category:";
            // 
            // txtName
            // 
            txtName.Location = new Point(418, 110);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 6;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(418, 149);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(100, 23);
            txtDescription.TabIndex = 7;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(418, 186);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 8;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(418, 225);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(100, 23);
            txtQuantity.TabIndex = 9;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(418, 264);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(100, 23);
            txtCategory.TabIndex = 10;
            // 
            // btnSaveEdit
            // 
            btnSaveEdit.Location = new Point(299, 327);
            btnSaveEdit.Name = "btnSaveEdit";
            btnSaveEdit.Size = new Size(75, 23);
            btnSaveEdit.TabIndex = 11;
            btnSaveEdit.Text = "Save";
            btnSaveEdit.UseVisualStyleBackColor = true;
            btnSaveEdit.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(418, 327);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // EditProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSaveEdit);
            Controls.Add(txtCategory);
            Controls.Add(txtQuantity);
            Controls.Add(txtPrice);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(lblCategoryEdit);
            Controls.Add(lblQuantityEdit);
            Controls.Add(lblPriceEdit);
            Controls.Add(lblDescriptionEdit);
            Controls.Add(lblNameEdit);
            Controls.Add(label1);
            Name = "EditProductForm";
            Text = "EditProductForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblNameEdit;
        private Label lblDescriptionEdit;
        private Label lblPriceEdit;
        private Label lblQuantityEdit;
        private Label lblCategoryEdit;
        private TextBox txtName;
        private TextBox txtDescription;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private TextBox txtCategory;
        private Button btnSaveEdit;
        private Button btnCancel;
    }
}