using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using SHOP_BR_Csharp.entities;

namespace SHOP_BR_Csharp
{
    public partial class Form1 : Form
    {
        public Form1([Optional]EventArgs e)
        {
            InitializeComponent();
            Form1_Load(null, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnStart_Click(sender, e);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximaze_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximaze.Visible = false;
            btnRestore.Visible = true;
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestore.Visible = false;
            btnMaximaze.Visible = true;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsh, int wParam, int lParam);

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnReviews_Click(object sender, EventArgs e)
        {
            SubMenuReviews.Visible = true;
        }

        private void btnrvScore_Click(object sender, EventArgs e)
        {
            SubMenuReviews.Visible = false;
            OpenChildForm(new ScoreReviewForm());
        }

        private void btnrvShopping_Click(object sender, EventArgs e)
        {
            SubMenuReviews.Visible = false;
            OpenChildForm(new ShowReviewsForm());
        }

        private void btnExit2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OpenChildForm(object formChild)
        {
            if(this.CenterPanel.Controls.Count > 0)
            {
                this.CenterPanel.Controls.RemoveAt(0);
            }
            Form fc = formChild as Form;
            fc.TopLevel = false;
            fc.Dock = DockStyle.Fill;
            this.CenterPanel.Controls.Add(fc);
            this.CenterPanel.Tag = fc;
            fc.Show();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProductsForm());
        }
        private void CenterPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Start());
        }

        private void btnMails_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MailForm());
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ClientForm());
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CartForm());
        }

        private void btnPurchases_Click(object sender, EventArgs e)
        {
            OpenChildForm(new PurchaseForm());
        }

        private void btnStores_Click(object sender, EventArgs e)
        {
            OpenChildForm(new StoreForm());
        }
    }
}
