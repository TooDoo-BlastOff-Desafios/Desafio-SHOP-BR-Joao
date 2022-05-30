namespace SHOP_BR_Csharp.entities
{
    partial class ClientForm
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
            this.dgvClients = new System.Windows.Forms.DataGridView();
            this.btnConsultOne = new System.Windows.Forms.Button();
            this.lbType = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbBrand = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lbProductId = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.btnConsultAll = new System.Windows.Forms.Button();
            this.lbStock = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lbPrice = new System.Windows.Forms.Label();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClients
            // 
            this.dgvClients.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dgvClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClients.Location = new System.Drawing.Point(300, 327);
            this.dgvClients.Name = "dgvClients";
            this.dgvClients.RowTemplate.Height = 25;
            this.dgvClients.Size = new System.Drawing.Size(533, 150);
            this.dgvClients.TabIndex = 39;
            // 
            // btnConsultOne
            // 
            this.btnConsultOne.BackColor = System.Drawing.Color.SeaGreen;
            this.btnConsultOne.FlatAppearance.BorderSize = 0;
            this.btnConsultOne.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnConsultOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultOne.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConsultOne.ForeColor = System.Drawing.Color.White;
            this.btnConsultOne.Location = new System.Drawing.Point(739, 105);
            this.btnConsultOne.Name = "btnConsultOne";
            this.btnConsultOne.Size = new System.Drawing.Size(94, 33);
            this.btnConsultOne.TabIndex = 38;
            this.btnConsultOne.Text = "Consult One";
            this.btnConsultOne.UseVisualStyleBackColor = false;
            this.btnConsultOne.Click += new System.EventHandler(this.btnConsultOne_Click);
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbType.ForeColor = System.Drawing.Color.White;
            this.lbType.Location = new System.Drawing.Point(300, 200);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(46, 15);
            this.lbType.TabIndex = 37;
            this.lbType.Text = "EMAIL:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEmail.Location = new System.Drawing.Point(380, 195);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(328, 24);
            this.txtEmail.TabIndex = 36;
            // 
            // lbBrand
            // 
            this.lbBrand.AutoSize = true;
            this.lbBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbBrand.ForeColor = System.Drawing.Color.White;
            this.lbBrand.Location = new System.Drawing.Point(300, 170);
            this.lbBrand.Name = "lbBrand";
            this.lbBrand.Size = new System.Drawing.Size(34, 15);
            this.lbBrand.TabIndex = 35;
            this.lbBrand.Text = "CEP:";
            // 
            // txtCEP
            // 
            this.txtCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCEP.Location = new System.Drawing.Point(380, 165);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(328, 24);
            this.txtCEP.TabIndex = 34;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(739, 272);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 33);
            this.btnDelete.TabIndex = 33;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(739, 216);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 33);
            this.btnAdd.TabIndex = 32;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.SeaGreen;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(739, 161);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(94, 33);
            this.btnEdit.TabIndex = 31;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lbProductId
            // 
            this.lbProductId.AutoSize = true;
            this.lbProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbProductId.ForeColor = System.Drawing.Color.White;
            this.lbProductId.Location = new System.Drawing.Point(300, 110);
            this.lbProductId.Name = "lbProductId";
            this.lbProductId.Size = new System.Drawing.Size(30, 13);
            this.lbProductId.TabIndex = 30;
            this.lbProductId.Text = "CPF:";
            // 
            // txtCPF
            // 
            this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCPF.Location = new System.Drawing.Point(380, 105);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(328, 24);
            this.txtCPF.TabIndex = 29;
            // 
            // btnConsultAll
            // 
            this.btnConsultAll.BackColor = System.Drawing.Color.SeaGreen;
            this.btnConsultAll.FlatAppearance.BorderSize = 0;
            this.btnConsultAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnConsultAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultAll.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConsultAll.ForeColor = System.Drawing.Color.White;
            this.btnConsultAll.Location = new System.Drawing.Point(174, 327);
            this.btnConsultAll.Name = "btnConsultAll";
            this.btnConsultAll.Size = new System.Drawing.Size(94, 33);
            this.btnConsultAll.TabIndex = 28;
            this.btnConsultAll.Text = "Consult All";
            this.btnConsultAll.UseVisualStyleBackColor = false;
            this.btnConsultAll.Click += new System.EventHandler(this.btnConsultAll_Click);
            // 
            // lbStock
            // 
            this.lbStock.AutoSize = true;
            this.lbStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbStock.ForeColor = System.Drawing.Color.White;
            this.lbStock.Location = new System.Drawing.Point(300, 290);
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(53, 15);
            this.lbStock.TabIndex = 27;
            this.lbStock.Text = "PHONE:";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPhone.Location = new System.Drawing.Point(380, 285);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(328, 24);
            this.txtPhone.TabIndex = 26;
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPrice.ForeColor = System.Drawing.Color.White;
            this.lbPrice.Location = new System.Drawing.Point(300, 260);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(47, 15);
            this.lbPrice.TabIndex = 25;
            this.lbPrice.Text = "LEVEL:";
            // 
            // txtLevel
            // 
            this.txtLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLevel.Location = new System.Drawing.Point(380, 255);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(328, 24);
            this.txtLevel.TabIndex = 24;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(300, 140);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(45, 15);
            this.lbName.TabIndex = 23;
            this.lbName.Text = "NAME:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.Location = new System.Drawing.Point(380, 135);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(328, 24);
            this.txtName.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(495, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 26);
            this.label1.TabIndex = 21;
            this.label1.Text = "CLIENTS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(300, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 41;
            this.label2.Text = "PASSWORD:";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(380, 225);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(328, 24);
            this.txtPassword.TabIndex = 40;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1080, 612);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.dgvClients);
            this.Controls.Add(this.btnConsultOne);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lbBrand);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lbProductId);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.btnConsultAll);
            this.Controls.Add(this.lbStock);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClientForm";
            this.Text = "ClientForm";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvClients;
        private Button btnConsultOne;
        private Label lbType;
        private TextBox txtEmail;
        private Label lbBrand;
        private TextBox txtCEP;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnEdit;
        private Label lbProductId;
        private TextBox txtCPF;
        private Button btnConsultAll;
        private Label lbStock;
        private TextBox txtPhone;
        private Label lbPrice;
        private TextBox txtLevel;
        private Label lbName;
        private TextBox txtName;
        private Label label1;
        private Label label2;
        private TextBox txtPassword;
    }
}