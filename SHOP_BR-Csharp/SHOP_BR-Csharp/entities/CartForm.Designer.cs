namespace SHOP_BR_Csharp.entities
{
    partial class CartForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lbType = new System.Windows.Forms.Label();
            this.txtPaymentType = new System.Windows.Forms.TextBox();
            this.lbBrand = new System.Windows.Forms.Label();
            this.txtQuantityPurchased = new System.Windows.Forms.TextBox();
            this.lbProductId = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.txtClientCPF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(281, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 15);
            this.label2.TabIndex = 62;
            this.label2.Text = "MAIL CODE:";
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCode.Location = new System.Drawing.Point(362, 217);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(328, 24);
            this.txtCode.TabIndex = 61;
            // 
            // lbType
            // 
            this.lbType.AutoSize = true;
            this.lbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbType.ForeColor = System.Drawing.Color.White;
            this.lbType.Location = new System.Drawing.Point(256, 192);
            this.lbType.Name = "lbType";
            this.lbType.Size = new System.Drawing.Size(100, 15);
            this.lbType.TabIndex = 58;
            this.lbType.Text = "PAYMENT TYPE:";
            // 
            // txtPaymentType
            // 
            this.txtPaymentType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPaymentType.Location = new System.Drawing.Point(362, 187);
            this.txtPaymentType.Name = "txtPaymentType";
            this.txtPaymentType.Size = new System.Drawing.Size(328, 24);
            this.txtPaymentType.TabIndex = 57;
            // 
            // lbBrand
            // 
            this.lbBrand.AutoSize = true;
            this.lbBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbBrand.ForeColor = System.Drawing.Color.White;
            this.lbBrand.Location = new System.Drawing.Point(210, 162);
            this.lbBrand.Name = "lbBrand";
            this.lbBrand.Size = new System.Drawing.Size(146, 15);
            this.lbBrand.TabIndex = 56;
            this.lbBrand.Text = "QUANTITY PURCHASED:";
            // 
            // txtQuantityPurchased
            // 
            this.txtQuantityPurchased.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQuantityPurchased.Location = new System.Drawing.Point(362, 157);
            this.txtQuantityPurchased.Name = "txtQuantityPurchased";
            this.txtQuantityPurchased.Size = new System.Drawing.Size(328, 24);
            this.txtQuantityPurchased.TabIndex = 55;
            // 
            // lbProductId
            // 
            this.lbProductId.AutoSize = true;
            this.lbProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbProductId.ForeColor = System.Drawing.Color.White;
            this.lbProductId.Location = new System.Drawing.Point(289, 102);
            this.lbProductId.Name = "lbProductId";
            this.lbProductId.Size = new System.Drawing.Size(72, 17);
            this.lbProductId.TabIndex = 51;
            this.lbProductId.Text = "ProductId:";
            // 
            // txtProductId
            // 
            this.txtProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProductId.Location = new System.Drawing.Point(362, 97);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(328, 24);
            this.txtProductId.TabIndex = 50;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(289, 132);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(67, 15);
            this.lbName.TabIndex = 44;
            this.lbName.Text = "Client CPF:";
            // 
            // txtClientCPF
            // 
            this.txtClientCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtClientCPF.Location = new System.Drawing.Point(362, 127);
            this.txtClientCPF.Name = "txtClientCPF";
            this.txtClientCPF.Size = new System.Drawing.Size(328, 24);
            this.txtClientCPF.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(494, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 26);
            this.label1.TabIndex = 42;
            this.label1.Text = "CART";
            // 
            // btnPurchase
            // 
            this.btnPurchase.BackColor = System.Drawing.Color.SeaGreen;
            this.btnPurchase.FlatAppearance.BorderSize = 0;
            this.btnPurchase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchase.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPurchase.ForeColor = System.Drawing.Color.White;
            this.btnPurchase.Location = new System.Drawing.Point(696, 97);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(94, 33);
            this.btnPurchase.TabIndex = 67;
            this.btnPurchase.Text = "Purchase";
            this.btnPurchase.UseVisualStyleBackColor = false;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1080, 612);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.lbType);
            this.Controls.Add(this.txtPaymentType);
            this.Controls.Add(this.lbBrand);
            this.Controls.Add(this.txtQuantityPurchased);
            this.Controls.Add(this.lbProductId);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.txtClientCPF);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CartForm";
            this.Text = "CartForm";
            this.Load += new System.EventHandler(this.CartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label2;
        private TextBox txtCode;
        private Label lbType;
        private TextBox txtPaymentType;
        private Label lbBrand;
        private TextBox txtQuantityPurchased;
        private Label lbProductId;
        private TextBox txtProductId;
        private Label lbName;
        private TextBox txtClientCPF;
        private Label label1;
        private Button btnPurchase;
    }
}