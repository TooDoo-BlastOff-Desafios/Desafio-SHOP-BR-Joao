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
    public partial class StoreForm : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter;
        SqlDataReader reader;

        string strSQL;

        public StoreForm()
        {
            InitializeComponent();
        }

        private void StoreForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var test = true;
            try
            {
                connection = new SqlConnection(@"Server= localhost,1433; Database=SHOP_BR;User Id=sa;Password=Algar123;");
                strSQL = "INSERT INTO Store (name, address, phone, email) VALUES (@name, @address, @phone, @email)";
                command = new SqlCommand(strSQL, connection);

                command.Parameters.AddWithValue("@name", string.Format(txtName.Text));
                command.Parameters.AddWithValue("@address", string.Format(txtAddress.Text));
                command.Parameters.AddWithValue("@phone", txtPhone.Text);
                command.Parameters.AddWithValue("@email", txtEmail.Text);

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
                    MessageBox.Show("Store has been added to the database!");
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
                strSQL = "SELECT * FROM Store";

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
                strSQL = "SELECT * FROM Store WHERE id = @id";
                command = new SqlCommand(strSQL, connection);

                command.Parameters.AddWithValue("@id", txtId.Text);

                connection.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    txtId.Text = Convert.ToString(reader["id"]);
                    txtName.Text = (string)reader["name"];
                    txtAddress.Text = (string)reader["address"];
                    txtPhone.Text = Convert.ToString(reader["phone"]);
                    txtEmail.Text = Convert.ToString(reader["email"]);
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
                strSQL = "UPDATE Store SET name = @name, address = @address, phone = @phone, email = @email WHERE id = @id";

                command = new SqlCommand(strSQL, connection);

                command.Parameters.AddWithValue("@id", txtId.Text);
                command.Parameters.AddWithValue("@name", string.Format(txtName.Text));
                command.Parameters.AddWithValue("@address", string.Format(txtAddress.Text));
                command.Parameters.AddWithValue("@phone", txtPhone.Text);
                command.Parameters.AddWithValue("@email", txtEmail.Text);

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
                    MessageBox.Show("Store has been edited!");
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
                strSQL = "DELETE Store WHERE id = @id";
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
                    MessageBox.Show("Store has been deleted from the database!");
                }
                connection.Close();
                connection = null;
                command = null;
            }
        }

        private void btnConsultProducts_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(@"Server= localhost,1433; Database=SHOP_BR;User Id=sa;Password=Algar123;");
                strSQL = @"SELECT 
                            [Store].[name],
                            [Product].[name]
                            FROM[ProductHasStore]
                            INNER JOIN[Store] ON[ProductHasStore].[StoreId] = [Store].[id]
                            INNER JOIN[Product] ON[Product].[id] = [ProductHasStore].[ProductId]";

                DataSet ds = new DataSet();

                adapter = new SqlDataAdapter(strSQL, connection);

                connection.Open();
                adapter.Fill(ds);
                dgvProdutsList.DataSource = ds.Tables[0];
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
    }
}