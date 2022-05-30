namespace SHOP_BR_Csharp.entities
{
    partial class MailForm
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
            this.dgvMails = new System.Windows.Forms.DataGridView();
            this.btnConsultOne = new System.Windows.Forms.Button();
            this.lbBrand = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lbProductId = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnConsultAll = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.txtDeadline = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMails)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMails
            // 
            this.dgvMails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.dgvMails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMails.Location = new System.Drawing.Point(305, 212);
            this.dgvMails.Name = "dgvMails";
            this.dgvMails.RowTemplate.Height = 25;
            this.dgvMails.Size = new System.Drawing.Size(533, 150);
            this.dgvMails.TabIndex = 39;
            // 
            // btnConsultOne
            // 
            this.btnConsultOne.BackColor = System.Drawing.Color.SeaGreen;
            this.btnConsultOne.FlatAppearance.BorderSize = 0;
            this.btnConsultOne.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnConsultOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultOne.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConsultOne.ForeColor = System.Drawing.Color.White;
            this.btnConsultOne.Location = new System.Drawing.Point(744, 99);
            this.btnConsultOne.Name = "btnConsultOne";
            this.btnConsultOne.Size = new System.Drawing.Size(94, 33);
            this.btnConsultOne.TabIndex = 38;
            this.btnConsultOne.Text = "Consult One";
            this.btnConsultOne.UseVisualStyleBackColor = false;
            this.btnConsultOne.Click += new System.EventHandler(this.btnConsultOne_Click);
            // 
            // lbBrand
            // 
            this.lbBrand.AutoSize = true;
            this.lbBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbBrand.ForeColor = System.Drawing.Color.White;
            this.lbBrand.Location = new System.Drawing.Point(305, 164);
            this.lbBrand.Name = "lbBrand";
            this.lbBrand.Size = new System.Drawing.Size(46, 15);
            this.lbBrand.TabIndex = 35;
            this.lbBrand.Text = "PRICE:";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrice.Location = new System.Drawing.Point(385, 159);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(328, 24);
            this.txtPrice.TabIndex = 34;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(188, 146);
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
            this.btnAdd.Location = new System.Drawing.Point(188, 99);
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
            this.btnEdit.Location = new System.Drawing.Point(744, 146);
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
            this.lbProductId.Location = new System.Drawing.Point(305, 104);
            this.lbProductId.Name = "lbProductId";
            this.lbProductId.Size = new System.Drawing.Size(40, 13);
            this.lbProductId.TabIndex = 30;
            this.lbProductId.Text = "CODE:";
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCode.Location = new System.Drawing.Point(385, 99);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(328, 24);
            this.txtCode.TabIndex = 29;
            // 
            // btnConsultAll
            // 
            this.btnConsultAll.BackColor = System.Drawing.Color.SeaGreen;
            this.btnConsultAll.FlatAppearance.BorderSize = 0;
            this.btnConsultAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnConsultAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultAll.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConsultAll.ForeColor = System.Drawing.Color.White;
            this.btnConsultAll.Location = new System.Drawing.Point(179, 291);
            this.btnConsultAll.Name = "btnConsultAll";
            this.btnConsultAll.Size = new System.Drawing.Size(94, 33);
            this.btnConsultAll.TabIndex = 28;
            this.btnConsultAll.Text = "Consult All";
            this.btnConsultAll.UseVisualStyleBackColor = false;
            this.btnConsultAll.Click += new System.EventHandler(this.btnConsultAll_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(305, 134);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(70, 15);
            this.lbName.TabIndex = 23;
            this.lbName.Text = "DEADLINE:";
            // 
            // txtDeadline
            // 
            this.txtDeadline.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDeadline.Location = new System.Drawing.Point(385, 129);
            this.txtDeadline.Name = "txtDeadline";
            this.txtDeadline.Size = new System.Drawing.Size(328, 24);
            this.txtDeadline.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(510, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 26);
            this.label1.TabIndex = 21;
            this.label1.Text = "MAILS";
            // 
            // MailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1080, 612);
            this.Controls.Add(this.dgvMails);
            this.Controls.Add(this.btnConsultOne);
            this.Controls.Add(this.lbBrand);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.lbProductId);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.btnConsultAll);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.txtDeadline);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MailForm";
            this.Text = "MailForm";
            this.Load += new System.EventHandler(this.MailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvMails;
        private Button btnConsultOne;
        private Label lbBrand;
        private TextBox txtPrice;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnEdit;
        private Label lbProductId;
        private TextBox txtCode;
        private Button btnConsultAll;
        private Label lbName;
        private TextBox txtDeadline;
        private Label label1;
    }
}