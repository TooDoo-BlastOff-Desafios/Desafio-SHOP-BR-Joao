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
    public partial class MailForm : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter;
        SqlDataReader reader;

        string strSQL;
        public MailForm()
        {
            InitializeComponent();
        }

        private void MailForm_Load(object sender, EventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var test = true;
            try
            {
                connection = new SqlConnection(@"Server= localhost,1433; Database=SHOP_BR;User Id=sa;Password=Algar123;");
                strSQL = "INSERT INTO Mail (deadline, price) VALUES (@deadline, @price)";
                command = new SqlCommand(strSQL, connection);

                command.Parameters.AddWithValue("@deadline", string.Format(txtDeadline.Text));
                command.Parameters.AddWithValue("@price", double.Parse(txtPrice.Text));

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
                    MessageBox.Show("Mail has been added to the database!");
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
                strSQL = "SELECT * FROM Mail";

                DataSet ds = new DataSet();

                adapter = new SqlDataAdapter(strSQL, connection);

                connection.Open();
                adapter.Fill(ds);
                dgvMails.DataSource = ds.Tables[0];
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


        private void btnEdit_Click(object sender, EventArgs e)
        {
            var test = true;
            try
            {
                connection = new SqlConnection(@"Server= localhost,1433; Database=SHOP_BR;User Id=sa;Password=Algar123;");
                strSQL = "UPDATE Mail SET deadline = @deadline, price = @price WHERE code = @code";

                command = new SqlCommand(strSQL, connection);

                command.Parameters.AddWithValue("@code", txtCode.Text);
                command.Parameters.AddWithValue("@deadline", int.Parse(txtDeadline.Text));
                command.Parameters.AddWithValue("@price", double.Parse(txtPrice.Text));

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
                    MessageBox.Show("Mail has been edited!");
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
                strSQL = "DELETE Mail WHERE code = @code";
                command = new SqlCommand(strSQL, connection);

                command.Parameters.AddWithValue("@code", txtCode.Text);

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
                    MessageBox.Show("Mail has been deleted from the database!");
                }
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
                strSQL = "SELECT * FROM Mail WHERE code = @code";
                command = new SqlCommand(strSQL, connection);

                command.Parameters.AddWithValue("@code", txtCode.Text);

                connection.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    txtDeadline.Text = Convert.ToString(reader["deadline"] + " days");
                    txtPrice.Text = Convert.ToString(reader["price"]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (txtCode.Text == "")
                {
                    MessageBox.Show("Code is empty!");
                }
                connection.Close();
                connection = null;
                command = null;
            }
        }

    }
}
