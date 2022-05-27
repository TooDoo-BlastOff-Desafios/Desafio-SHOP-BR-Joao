using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHOP_BR_Csharp.entities
{
    public partial class ClientForm : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter;
        SqlDataReader reader;

        string strSQL;
        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var test = true;
            Regex testName = new Regex(@"^[A-Za-zÁ-Úá-ú]{2,15}\s[A-Za-zÁ-Úá-ú\s]+$");
            Regex testCPF = new Regex(@"^[\d]{3}\.[\d]{3}\.[\d]{3}-[\d]{2}$");
            Regex testCEP = new Regex(@"^[\d]{5}-[\d]{3}$");

            if (testName.IsMatch(txtName.Text) && testCPF.IsMatch(txtCPF.Text) && testCEP.IsMatch(txtCEP.Text))
            {
                try
                {
                    connection = new SqlConnection(@"Server= localhost,1433; Database=SHOP_BR;User Id=sa;Password=Algar123;");
                    strSQL = "INSERT INTO Client (cpf, name, cep, email, password, level, phone) VALUES (@cpf, @name, @cep, @email, @password, @level, @phone)";
                    command = new SqlCommand(strSQL, connection);

                    command.Parameters.AddWithValue("@cpf", string.Format(txtCPF.Text));
                    command.Parameters.AddWithValue("@name", string.Format(txtName.Text));
                    command.Parameters.AddWithValue("@cep", string.Format(txtCEP.Text));
                    command.Parameters.AddWithValue("@email", string.Format(txtEmail.Text));
                    command.Parameters.AddWithValue("@password", string.Format(txtPassword.Text));
                    command.Parameters.AddWithValue("@level", txtLevel.Text);
                    command.Parameters.AddWithValue("@phone", txtLevel.Text);

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
                        MessageBox.Show("Client has been added to the database!");
                    }
                    connection.Close();
                    connection = null;
                    command = null;
                }
            }
            else
            {
                MessageBox.Show("Format name/CPF/CEP invalid!\n" +
                    "Format CPF(xxx.xxx.xxx-xx)\n" +
                    "Format CEP(xxxxx-xxx)");
            }
        }

        private void btnConsultAll_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(@"Server= localhost,1433; Database=SHOP_BR;User Id=sa;Password=Algar123;");
                strSQL = "SELECT * FROM Client";

                DataSet ds = new DataSet();

                adapter = new SqlDataAdapter(strSQL, connection);

                connection.Open();
                adapter.Fill(ds);
                dgvClients.DataSource = ds.Tables[0];
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
                strSQL = "SELECT * FROM Client WHERE cpf = @cpf";
                command = new SqlCommand(strSQL, connection);

                command.Parameters.AddWithValue("@name", txtName.Text);
                command.Parameters.AddWithValue("@cpf", txtCPF.Text);

                connection.Open();
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    txtName.Text = (string)reader["name"];
                    txtCEP.Text = (string)reader["cep"];
                    txtEmail.Text = (string)reader["email"];
                    txtPassword.Text = Convert.ToString(reader["password"]);
                    txtLevel.Text = Convert.ToString(reader["level"]);
                    txtPhone.Text = Convert.ToString(reader["phone"]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (txtCPF.Text == "")
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
                strSQL = "UPDATE Client SET name = @name, cep = @cep, email = @email, password = @password, level = @level, phone = @phone WHERE cpf = @cpf";

                command = new SqlCommand(strSQL, connection);

                command.Parameters.AddWithValue("@cpf", txtCPF.Text);
                command.Parameters.AddWithValue("@name", string.Format(txtName.Text));
                command.Parameters.AddWithValue("@cep", string.Format(txtCEP.Text));
                command.Parameters.AddWithValue("@email", string.Format(txtEmail.Text));
                command.Parameters.AddWithValue("@password", txtPassword.Text);
                command.Parameters.AddWithValue("@level", txtLevel.Text);
                command.Parameters.AddWithValue("@phone", txtLevel.Text);

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
                    MessageBox.Show("Client has been edited!");
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
                strSQL = "DELETE Client WHERE cpf = @cpf";
                command = new SqlCommand(strSQL, connection);

                command.Parameters.AddWithValue("@cpf", txtCPF.Text);

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
                    MessageBox.Show("Client has been deleted from the database!");
                }
                connection.Close();
                connection = null;
                command = null;
            }
        }

        
    }
}
