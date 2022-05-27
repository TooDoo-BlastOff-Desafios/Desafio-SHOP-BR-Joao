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
    public partial class ScoreReviewForm : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter;
        SqlDataReader reader;

        string strSQL;
        public ScoreReviewForm()
        {
            InitializeComponent();
        }

        private void ScoreReviewForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var test = false;

            test = txtScore.Text == "1" || txtScore.Text == "2" || txtScore.Text == "3"
                || txtScore.Text == "4" || txtScore.Text == "5";

            if (test == true)
            {
                try
                {
                    connection = new SqlConnection(@"Server= localhost,1433; Database=SHOP_BR;User Id=sa;Password=Algar123;");
                    strSQL = @$"UPDATE [Review]
                            SET[score] = '{txtScore.Text}', [text] = '{txtComment.Text}'
                            WHERE[ProductId] = '{int.Parse(txtProductId.Text)}' AND [ClientCPF] = '{txtClientCPF.Text}'";
                    command = new SqlCommand(strSQL, connection);

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
                        MessageBox.Show("Review has been added to the database!");
                    }
                    connection.Close();
                    connection = null;
                    command = null;
                }
            }
            else
            {
                MessageBox.Show("The score must be an int between 1 and 5!");
            }
        }

    }
}
