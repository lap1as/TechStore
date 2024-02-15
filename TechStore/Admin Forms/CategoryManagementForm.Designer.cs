namespace TechStore.Admin_Forms
{
    partial class CategoryManagementForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryManagementForm));
            dataGridViewCategories = new DataGridView();
            btnDeleteCategory = new Button();
            btnAddCategory = new Button();
            label1 = new Label();
            databaseServiceBindingSource = new BindingSource(components);
            btnClose = new Button();
            txtCategoryName = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)databaseServiceBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewCategories
            // 
            dataGridViewCategories.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCategories.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCategories.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCategories.Location = new Point(205, 85);
            dataGridViewCategories.Name = "dataGridViewCategories";
            dataGridViewCategories.Size = new Size(583, 355);
            dataGridViewCategories.TabIndex = 13;
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.Location = new Point(12, 245);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(172, 31);
            btnDeleteCategory.TabIndex = 12;
            btnDeleteCategory.Text = "Delete Category";
            btnDeleteCategory.UseVisualStyleBackColor = true;
            btnDeleteCategory.Click += btnDeleteCategory_Click;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(12, 114);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(172, 31);
            btnAddCategory.TabIndex = 11;
            btnAddCategory.Text = "Add Category";
            btnAddCategory.UseVisualStyleBackColor = true;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(254, 11);
            label1.Name = "label1";
            label1.Size = new Size(290, 37);
            label1.TabIndex = 8;
            label1.Text = "Category Management";
            // 
            // databaseServiceBindingSource
            // 
            databaseServiceBindingSource.DataSource = typeof(DatabaseService);
            // 
            // btnClose
            // 
            btnClose.Location = new Point(56, 282);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(12, 85);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(172, 23);
            txtCategoryName.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(14, 207);
            label2.Name = "label2";
            label2.Size = new Size(125, 57);
            label2.TabIndex = 16;
            label2.Text = "To delete category \r\nselect it on grid\r\n\r\n";
            // 
            // CategoryManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeleteCategory);
            Controls.Add(label2);
            Controls.Add(txtCategoryName);
            Controls.Add(dataGridViewCategories);
            Controls.Add(btnAddCategory);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CategoryManagementForm";
            Text = "CategoryManagementForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategories).EndInit();
            ((System.ComponentModel.ISupportInitialize)databaseServiceBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewCategories;
        private Button btnDeleteCategory;
        private Button btnAddCategory;
        private Label label1;
        private BindingSource databaseServiceBindingSource;
        private Button btnClose;
        private TextBox txtCategoryName;
        private Label label2;
    }
}