namespace SHOP_BR_Csharp
{
    partial class ProductsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lbStock = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnConsultAll = new System.Windows.Forms.Button();
            this.lbProductId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbBrand = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.lbType = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.btnConsultOne = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(465, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRODUCTS";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(372, 129);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(328, 24);
            this.txtName.TabIndex = 1;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(292, 134);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(66, 15);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "PRODUCT";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPrice.ForeColor = System.Drawing.Color.White;
            this.lbPrice.Location = new System.Drawing.Point(292, 224);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(46, 15);
            this.lbPrice.TabIndex = 4;
            this.lbPrice.Text = "PRICE:";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrice.Location = new System.Drawing.Point(372, 219);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(328, 24);
            this.txtPrice.TabIndex = 3;
            // 
            // lbStock
            // 
            this.lbStock.AutoSize = true;
            this.lbStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbStock.ForeColor = System.Drawing.Color.White;
            this.lbStock.Location = new System.Drawing.Point(292, 254);
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(50, 15);
            this.lbStock.TabIndex = 6;
            this.lbStock.Text = "STOCK:";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQuantity.Location = new System.Drawing.Point(372, 249);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(328, 24);
            this.txtQuantity.TabIndex = 5;
            // 
            // btnConsultAll
            // 
            this.btnConsultAll.BackColor = System.Drawing.Color.SeaGreen;
            this.btnConsultAll.FlatAppearance.BorderSize = 0;
            this.btnConsultAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnConsultAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultAll.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConsultAll.ForeColor = System.Drawing.Color.White;
            this.btnConsultAll.Location = new System.Drawing.Point(166, 291);
            this.btnConsultAll.Name = "btnConsultAll";
            this.btnConsultAll.Size = new System.Drawing.Size(94, 33);
            this.btnConsultAll.TabIndex = 7;
            this.btnConsultAll.Text = "Consult All";
            this.btnConsultAll.UseVisualStyleBackColor = false;
            this.btnConsultAll.Click += new System.EventHandler(this.btnConsultAll_Click);
            // 
            // lbProductId
            // 
            this.lbProductId.AutoSize = true;
            this.lbProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbProductId.ForeColor = System.Drawing.Color.White;
            this.lbProductId.Location = new System.Drawing.Point(292, 104);
            this.lbProductId.Name = "lbProductId";
            this.lbProductId.Size = new System.Drawing.Size(77, 13);
            this.lbProductId.TabIndex = 9;
            this.lbProductId.Text = "PRODUCT ID:";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtId.Location = new System.Drawing.Point(372, 99);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(328, 24);
            this.txtId.TabIndex = 8;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.SeaGreen;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(731, 146);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(94, 33);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(731, 194);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 33);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(731, 240);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 33);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lbBrand
            // 
            this.lbBrand.AutoSize = true;
            this.lbBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbBrand.ForeColor = System.Drawing.Color.White;
            this.lbBrand.Location = new System.Drawing.Point(292, 164);
            this.lbBrand.Name = "lbBrand";
            this.lbBrand.Size = new System.Drawing.Size(52, 15);
            this.lbBrand.TabIndex = 14;
            this.lbBrand.Text = "BRAND:";
            // 
            // txtBrand
            // 
            this.txtBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBrand.Location = new System.Drawing.Point(372, 159);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(328, 24);
            this.txtBrand.TabIndex = 13;
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbType.ForeColor = System.Drawing.Color.White;
            this.lbType.Location = new System.Drawing.Point(292, 194);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(40, 15);
            this.lbType.TabIndex = 16;
            this.lbType.Text = "TYPE:";
            // 
            // txtType
            // 
            this.txtType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtType.Location = new System.Drawing.Point(372, 189);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(328, 24);
            this.txtType.TabIndex = 15;
            // 
            // btnConsultOne
            // 
            this.btnConsultOne.BackColor = System.Drawing.Color.SeaGreen;
            this.btnConsultOne.FlatAppearance.BorderSize = 0;
            this.btnConsultOne.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnConsultOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultOne.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConsultOne.ForeColor = System.Drawing.Color.White;
            this.btnConsultOne.Location = new System.Drawing.Point(731, 99);
            this.btnConsultOne.Name = "btnConsultOne";
            this.btnConsultOne.Size = new System.Drawing.Size(94, 33);
            this.btnConsultOne.TabIndex = 19;
            this.btnConsultOne.Text = "Consult One";
            this.btnConsultOne.UseVisualStyleBackColor = false;
            this.btnConsultOne.Click += new System.EventHandler(this.btnConsultOne_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(292, 291);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowTemplate.Height = 25;
            this.dgvProducts.Size = new System.Drawing.Size(533, 150);
            this.dgvProducts.TabIndex = 20;
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1080, 612);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.btnConsultOne);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.lbBrand);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lbProductId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnConsultAll);
            this.Controls.Add(this.lbStock);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductsForm";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private Label lbName;
        private Label lbPrice;
        private TextBox txtPrice;
        private Label lbStock;
        private TextBox txtQuantity;
        private Button btnConsultAll;
        private Label lbProductId;
        private TextBox txtId;
        private Button btnEdit;
        private Button btnAdd;
        private Button btnDelete;
        private Label lbBrand;
        private TextBox txtBrand;
        private Label lbType;
        private TextBox txtType;
        private Button btnConsultOne;
        private DataGridView dgvProducts;
    }
}