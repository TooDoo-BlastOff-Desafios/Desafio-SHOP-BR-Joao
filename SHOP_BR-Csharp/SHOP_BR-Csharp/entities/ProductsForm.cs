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

namespace SHOP_BR_Csharp
{
    public partial class ProductsForm : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter;
        SqlDataReader reader;

        string strSQL;
        public ProductsForm()
        {
            InitializeComponent();
        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var test = true;
            try
            {
                connection = new SqlConnection(@"Server= localhost,1433; Database=SHOP_BR;User Id=sa;Password=Algar123;");
                strSQL = "INSERT INTO Product (name, brand, type, price, quantity) VALUES (@name, @brand, @type, @price, @quantity)";
                command = new SqlCommand(strSQL, connection);
                
                command.Parameters.AddWithValue("@name", string.Format(txtName.Text));
                command.Parameters.AddWithValue("@brand", string.Format(txtBrand.Text));
                command.Parameters.AddWithValue("@type", string.Format(txtType.Text));
                command.Parameters.AddWithValue("@price", double.Parse(txtPrice.Text));
                command.Parameters.AddWithValue("@quantity", int.Parse(txtQuantity.Text));

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
                    MessageBox.Show("Product has been added to the database!");
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
                strSQL = "SELECT * FROM Product";
                
                DataSet ds = new DataSet();

                adapter = new SqlDataAdapter(strSQL, connection);

                connection.Open();
                adapter.Fill(ds);
                dgvProducts.DataSource = ds.Tables[0];
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

        private void btnConsultOne_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(@"Server= localhost,1433; Database=SHOP_BR;User Id=sa;Password=Algar123;");
                strSQL = "SELECT * FROM Product WHERE id = @id";
                command = new SqlCommand(strSQL, connection);

                command.Parameters.AddWithValue("@name", txtName.Text);
                command.Parameters.AddWithValue("@id", txtId.Text);
                
                connection.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    txtName.Text = (string)reader["name"];
                    txtBrand.Text = (string)reader["brand"];
                    txtType.Text = (string)reader["type"];
                    txtPrice.Text = Convert.ToString(reader["price"]);
                    txtQuantity.Text = Convert.ToString(reader["quantity"]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (txtId.Text == "")
                {
                    MessageBox.Show("Id is empty!");
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
                strSQL = "UPDATE Product SET name = @name, brand = @brand, type = @type, price = @price, quantity = @quantity WHERE id = @id";
                
                command = new SqlCommand(strSQL, connection);

                command.Parameters.AddWithValue("@id", txtId.Text);
                command.Parameters.AddWithValue("@name", string.Format(txtName.Text));
                command.Parameters.AddWithValue("@brand", string.Format(txtBrand.Text));
                command.Parameters.AddWithValue("@type", string.Format(txtType.Text));
                command.Parameters.AddWithValue("@price", double.Parse(txtPrice.Text));
                command.Parameters.AddWithValue("@quantity", int.Parse(txtQuantity.Text));

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
                    MessageBox.Show("Product has been edited!");
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
                strSQL = "DELETE Product WHERE id = @id";
                command = new SqlCommand(strSQL, connection);

                command.Parameters.AddWithValue("@id", txtId.Text);

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
                    MessageBox.Show("Product has been deleted from the database!");
                }
                connection.Close();
                connection = null;
                command = null;
            }
        }
    }
}
