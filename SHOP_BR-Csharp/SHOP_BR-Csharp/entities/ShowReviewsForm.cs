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
    public partial class ShowReviewsForm : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter;
        SqlDataReader reader;

        string strSQL;
        public ShowReviewsForm()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(@"Server= localhost,1433; Database=SHOP_BR;User Id=sa;Password=Algar123;");
                strSQL = @"SELECT
                            [Client].[name] AS Client,
                            [Product].[name] AS Product,
                            [Review].[score],
                            [Review].[text]
                            FROM[Review]
                            INNER JOIN[Client] ON[Review].[ClientCPF] = [Client].[cpf]
                            INNER JOIN[Product] ON[Product].[id] = [Review].[ProductId]";

                DataSet ds = new DataSet();

                adapter = new SqlDataAdapter(strSQL, connection);

                connection.Open();
                adapter.Fill(ds);
                dgvScores.DataSource = ds.Tables[0];
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
