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
    public partial class PurchaseForm : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter;
        SqlDataReader reader;

        string strSQL;
        public PurchaseForm()
        {
            InitializeComponent();
        }

        private void PurchaseForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var test = true;
            try
            {
                connection = new SqlConnection(@"Server= localhost,1433; Database=SHOP_BR;User Id=sa;Password=Algar123;");
                strSQL = "INSERT INTO Purchase (clientCPF, quantityPurchased, PaymentType, Code, trackingCode) VALUES (@clientCPF, @quantityPurchased, @PaymentType, @Code, @trackingCode)";
                command = new SqlCommand(strSQL, connection);

                command.Parameters.AddWithValue("@clientCPF", string.Format(txtClientCPF.Text));
                command.Parameters.AddWithValue("@quantityPurchased", string.Format(txtQuantityPurchased.Text));
                command.Parameters.AddWithValue("@PaymentType", string.Format(txtPaymentType.Text));
                command.Parameters.AddWithValue("@Code", double.Parse(txtCode.Text));
                command.Parameters.AddWithValue("@trackingCode", int.Parse(txtTrackingCode.Text));

                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                test = false;
            }
            finally
            {
                if (test == true)
                {
                    MessageBox.Show("Purchase has been added to the database!");
                }
                connection.Close();
                connection = null;
                command = null;
            }
        }

        private void btnConsultAll_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(@"Server= localhost,1433; Database=SHOP_BR;User Id=sa;Password=Algar123;");
                strSQL = "SELECT * FROM Purchase";

                DataSet ds = new DataSet();

                adapter = new SqlDataAdapter(strSQL, connection);

                connection.Open();
                adapter.Fill(ds);
                dgvPurchases.DataSource = ds.Tables[0];
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
        		
        private void btnConsultName_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(@"Server= localhost,1433; Database=SHOP_BR;User Id=sa;Password=Algar123;");
                strSQL = $"SELECT [Product].[name], [Purchase].[totalValue], [Purchase].[payment_type], [Client].[name] FROM [Client] INNER JOIN [Purchase] ON [Client].[cpf] = [Purchase].[ClientCPF] AND [Client].[cpf] =  '{txtName.Text}' INNER JOIN [Product] ON [Purchase].[ProductId] = [Product].[id]";

                command = new SqlCommand(strSQL, connection);

                //command.Parameters.AddWithValue("@cpf", Convert.ToString(txtName.Text));
                

                connection.Open();
               

                DataSet ds = new DataSet();
                adapter = new SqlDataAdapter(strSQL, connection);

                adapter.Fill(ds);
                dgvPurchaseName.DataSource = ds.Tables[0];
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (txtName.Text == "")
                {
                    MessageBox.Show("Name is empty!");
                }
                connection.Close();
                connection = null;
                command = null;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var test = true;
            try
            {
                connection = new SqlConnection(@"Server= localhost,1433; Database=SHOP_BR;User Id=sa;Password=Algar123;");
                strSQL = "UPDATE Purchase SET ClientCPF = @clientCPF, quantity_purchased = @quantityPurchased, payment_type = @PaymentType, MailCode = @Code, tracking_code = @trackingCode, totalValue = @totalValue WHERE ProductId = @productId AND ClientCPF = @clientCPF";

                command = new SqlCommand(strSQL, connection);
                command.Parameters.AddWithValue("@productId", string.Format(txtProductId.Text));
                command.Parameters.AddWithValue("@clientCPF", string.Format(txtClientCPF.Text));
                command.Parameters.AddWithValue("@quantityPurchased", txtQuantityPurchased.Text);
                command.Parameters.AddWithValue("@PaymentType", string.Format(txtPaymentType.Text));
                command.Parameters.AddWithValue("@Code", txtCode.Text);
                command.Parameters.AddWithValue("@trackingCode", txtTrackingCode.Text);
                command.Parameters.AddWithValue("@totalValue", txtTotalValue.Text);

                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                test = false;
            }
            finally
            {
                if (test == true)
                {
                    MessageBox.Show("Purchase has been edited!");
                }
                connection.Close();
                connection = null;
                command = null;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var test = true;
            try
            {
                connection = new SqlConnection(@"Server= localhost,1433; Database=SHOP_BR;User Id=sa;Password=Algar123;");
                strSQL = $"DELETE [Purchase] WHERE [ProductId] = '@productId' AND [ClientCPF] = '@clientCPF' AND [totalValue] = '@totalValue'";
                command = new SqlCommand(strSQL, connection);

                command.Parameters.AddWithValue("@productId", txtProductId.Text);
                command.Parameters.AddWithValue("@clientCPF", txtClientCPF.Text);
                command.Parameters.AddWithValue("@totalValue", txtTotalValue.Text);

                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                test = false;
            }
            finally
            {
                if (test == true)
                {
                    MessageBox.Show("Purchase has been deleted from the database!");
                }
                connection.Close();
                connection = null;
                command = null;
            }
        }

    }
}
