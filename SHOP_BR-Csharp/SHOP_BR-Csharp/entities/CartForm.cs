using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHOP_BR_Csharp.entities
{
    public partial class CartForm : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter;
        SqlDataReader reader;

        string strSQL;
        public CartForm()
        {
            InitializeComponent();
        }

        private void CartForm_Load(object sender, EventArgs e)
        {

        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            var test = false;
            var testType = true;

            test = txtProductId.Text == "" || txtClientCPF.Text == "" || txtQuantityPurchased.Text == ""
                || txtPaymentType.Text == "" || txtCode.Text == "";

            testType = txtPaymentType.Text == "pix" || txtPaymentType.Text == "bank split" || txtPaymentType.Text == "credit card";
            if (testType == false)
            {
                MessageBox.Show("Available payment mathods:\n" +
                    "pix | bank split | credit card");
            }


            if (test == false)
            {
                try
                {
                    connection = new SqlConnection(@"Server= localhost,1433; Database=SHOP_BR;User Id=sa;Password=Algar123;");
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("spPurchase", connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@productId", SqlDbType.Int).Value = txtProductId.Text;
                    cmd.Parameters.AddWithValue("@cpf", SqlDbType.VarChar).Value = txtClientCPF.Text;
                    cmd.Parameters.AddWithValue("@quantityPurchased", SqlDbType.Int).Value = txtQuantityPurchased.Text;
                    cmd.Parameters.AddWithValue("@paymentType", SqlDbType.VarChar).Value = txtPaymentType.Text;
                    cmd.Parameters.AddWithValue("@code", SqlDbType.Int).Value = txtCode.Text;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Purchase made!");
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                    connection = null;
                    command = null;
                }
            }
            else
            {
                MessageBox.Show("Empty field!");
            }
        }

    }
}
