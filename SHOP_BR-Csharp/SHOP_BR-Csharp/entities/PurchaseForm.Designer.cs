namespace SHOP_BR_Csharp.entities
{
    partial class PurchaseForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTrackingCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.dgvPurchases = new System.Windows.Forms.DataGridView();
            this.btnConsultName = new System.Windows.Forms.Button();
            this.lbType = new System.Windows.Forms.Label();
            this.lbBrand = new System.Windows.Forms.Label();
            this.txtQuantityPurchased = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lbProductId = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnConsultAll = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.txtClientCPF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPaymentType = new System.Windows.Forms.TextBox();
            this.dgvPurchaseName = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchases)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseName)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(119, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 87;
            this.label4.Text = "TOTAL VALUE:";
            // 
            // txtTotalValue
            // 
            this.txtTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotalValue.Location = new System.Drawing.Point(215, 229);
            this.txtTotalValue.Name = "txtTotalValue";
            this.txtTotalValue.Size = new System.Drawing.Size(328, 24);
            this.txtTotalValue.TabIndex = 86;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(102, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 85;
            this.label3.Text = "TRACKING CODE:";
            // 
            // txtTrackingCode
            // 
            this.txtTrackingCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTrackingCode.Location = new System.Drawing.Point(215, 199);
            this.txtTrackingCode.Name = "txtTrackingCode";
            this.txtTrackingCode.Size = new System.Drawing.Size(328, 24);
            this.txtTrackingCode.TabIndex = 84;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(134, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 83;
            this.label2.Text = "MAIL CODE:";
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCode.Location = new System.Drawing.Point(215, 169);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(328, 24);
            this.txtCode.TabIndex = 82;
            // 
            // dgvPurchases
            // 
            this.dgvPurchases.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dgvPurchases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchases.Location = new System.Drawing.Point(142, 271);
            this.dgvPurchases.Name = "dgvPurchases";
            this.dgvPurchases.RowTemplate.Height = 25;
            this.dgvPurchases.Size = new System.Drawing.Size(533, 150);
            this.dgvPurchases.TabIndex = 81;
            // 
            // btnConsultName
            // 
            this.btnConsultName.BackColor = System.Drawing.Color.SeaGreen;
            this.btnConsultName.FlatAppearance.BorderSize = 0;
            this.btnConsultName.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnConsultName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConsultName.ForeColor = System.Drawing.Color.White;
            this.btnConsultName.Location = new System.Drawing.Point(854, 278);
            this.btnConsultName.Name = "btnConsultName";
            this.btnConsultName.Size = new System.Drawing.Size(111, 33);
            this.btnConsultName.TabIndex = 80;
            this.btnConsultName.Text = "Consult CPF";
            this.btnConsultName.UseVisualStyleBackColor = false;
            this.btnConsultName.Click += new System.EventHandler(this.btnConsultName_Click);
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbType.ForeColor = System.Drawing.Color.White;
            this.lbType.Location = new System.Drawing.Point(109, 144);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(100, 15);
            this.lbType.TabIndex = 79;
            this.lbType.Text = "PAYMENT TYPE:";
            // 
            // lbBrand
            // 
            this.lbBrand.AutoSize = true;
            this.lbBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbBrand.ForeColor = System.Drawing.Color.White;
            this.lbBrand.Location = new System.Drawing.Point(63, 114);
            this.lbBrand.Name = "lbBrand";
            this.lbBrand.Size = new System.Drawing.Size(146, 15);
            this.lbBrand.TabIndex = 77;
            this.lbBrand.Text = "QUANTITY PURCHASED:";
            // 
            // txtQuantityPurchased
            // 
            this.txtQuantityPurchased.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQuantityPurchased.Location = new System.Drawing.Point(215, 109);
            this.txtQuantityPurchased.Name = "txtQuantityPurchased";
            this.txtQuantityPurchased.Size = new System.Drawing.Size(328, 24);
            this.txtQuantityPurchased.TabIndex = 76;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(581, 174);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 33);
            this.btnDelete.TabIndex = 75;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.SeaGreen;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(581, 114);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(94, 33);
            this.btnEdit.TabIndex = 73;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lbProductId
            // 
            this.lbProductId.AutoSize = true;
            this.lbProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbProductId.ForeColor = System.Drawing.Color.White;
            this.lbProductId.Location = new System.Drawing.Point(702, 320);
            this.lbProductId.Name = "lbProductId";
            this.lbProductId.Size = new System.Drawing.Size(42, 18);
            this.lbProductId.TabIndex = 72;
            this.lbProductId.Text = "CPF:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(750, 317);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(328, 24);
            this.txtName.TabIndex = 71;
            // 
            // btnConsultAll
            // 
            this.btnConsultAll.BackColor = System.Drawing.Color.SeaGreen;
            this.btnConsultAll.FlatAppearance.BorderSize = 0;
            this.btnConsultAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnConsultAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultAll.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConsultAll.ForeColor = System.Drawing.Color.White;
            this.btnConsultAll.Location = new System.Drawing.Point(9, 271);
            this.btnConsultAll.Name = "btnConsultAll";
            this.btnConsultAll.Size = new System.Drawing.Size(94, 33);
            this.btnConsultAll.TabIndex = 70;
            this.btnConsultAll.Text = "Consult All";
            this.btnConsultAll.UseVisualStyleBackColor = false;
            this.btnConsultAll.Click += new System.EventHandler(this.btnConsultAll_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(142, 84);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(67, 15);
            this.lbName.TabIndex = 69;
            this.lbName.Text = "Client CPF:";
            // 
            // txtClientCPF
            // 
            this.txtClientCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtClientCPF.Location = new System.Drawing.Point(215, 79);
            this.txtClientCPF.Name = "txtClientCPF";
            this.txtClientCPF.Size = new System.Drawing.Size(328, 24);
            this.txtClientCPF.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(309, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 26);
            this.label1.TabIndex = 67;
            this.label1.Text = "PURCHASES";
            // 
            // txtPaymentType
            // 
            this.txtPaymentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPaymentType.Location = new System.Drawing.Point(215, 139);
            this.txtPaymentType.Name = "txtPaymentType";
            this.txtPaymentType.Size = new System.Drawing.Size(328, 24);
            this.txtPaymentType.TabIndex = 78;
            // 
            // dgvPurchaseName
            // 
            this.dgvPurchaseName.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dgvPurchaseName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchaseName.Location = new System.Drawing.Point(750, 363);
            this.dgvPurchaseName.Name = "dgvPurchaseName";
            this.dgvPurchaseName.RowTemplate.Height = 25;
            this.dgvPurchaseName.Size = new System.Drawing.Size(328, 150);
            this.dgvPurchaseName.TabIndex = 88;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(142, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 90;
            this.label5.Text = "ProductId:";
            // 
            // txtProductId
            // 
            this.txtProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProductId.Location = new System.Drawing.Point(215, 49);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(328, 24);
            this.txtProductId.TabIndex = 89;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(549, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 15);
            this.label6.TabIndex = 91;
            this.label6.Text = "DECIMALS ARE SEPARATED BY \',\'";
            // 
            // PurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1080, 612);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.dgvPurchaseName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotalValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTrackingCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.dgvPurchases);
            this.Controls.Add(this.btnConsultName);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.txtPaymentType);
            this.Controls.Add(this.lbBrand);
            this.Controls.Add(this.txtQuantityPurchased);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lbProductId);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnConsultAll);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.txtClientCPF);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PurchaseForm";
            this.Text = "PurchaseForm";
            this.Load += new System.EventHandler(this.PurchaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchases)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label4;
        private TextBox txtTotalValue;
        private Label label3;
        private TextBox txtTrackingCode;
        private Label label2;
        private TextBox txtCode;
        private DataGridView dgvPurchases;
        private Button btnConsultName;
        private Label lbType;
        private Label lbBrand;
        private TextBox txtQuantityPurchased;
        private Button btnDelete;
        private Button btnEdit;
        private Label lbProductId;
        private TextBox txtName;
        private Button btnConsultAll;
        private Label lbName;
        private TextBox txtClientCPF;
        private Label label1;
        private TextBox txtPaymentType;
        private DataGridView dgvPurchaseName;
        private Label label5;
        private TextBox txtProductId;
        private Label label6;
    }
}