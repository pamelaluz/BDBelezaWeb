using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace BancodeDadosBelezaWeb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntSalvar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conn_string = new MySqlConnectionStringBuilder();
            conn_string.Server = "localhost";
            conn_string.Database = "belezaweb";
            conn_string.UserID = "root";
            conn_string.Password = "";
            MySqlConnection connectionString = new MySqlConnection(conn_string.ToString());


            try
            {
                connectionString.Open();
                MessageBox.Show("Connection Open ! ");

                MySqlCommand cmd = connectionString.CreateCommand();
                cmd.CommandText = "INSERT INTO marca (nomeMarca,descricaoMarca,historiaMarca) " +
                     "VALUES('" + txbNomeMarca.Text + "', '" + txbDescricaoMarca.Text + "', '" + txbHistoriaMarca.Text + "')";
                cmd.ExecuteNonQuery();

                connectionString.Close();
                MessageBox.Show("Inserido com sucesso");
                limparCampos();
                atualizarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
                Console.WriteLine(ex.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            atualizarGrid();
        }

        private void atualizarGrid()
        {
            MySqlConnectionStringBuilder conn_string = new MySqlConnectionStringBuilder();
            conn_string.Server = "localhost";
            conn_string.Database = "belezaweb";
            conn_string.UserID = "root";
            conn_string.Password = "";
            MySqlConnection connectionString = new MySqlConnection(conn_string.ToString());
            try
            {
                connectionString.Open();

                MySqlCommand comandoMySql = connectionString.CreateCommand();
                comandoMySql.CommandText = "SELECT * from marca WHERE InativoMarca = 0 "; //Traz todo mundo da tabela autor
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                dataGridViewBW.Rows.Clear();//FAZ LIMPAR A TABELA

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridViewBW.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = reader.GetInt32(0);//ID
                    row.Cells[1].Value = reader.GetString(1);//NOME
                    row.Cells[2].Value = reader.GetString(2);//DESCRICAO
                    row.Cells[3].Value = reader.GetString(3);//HISTORIA
                   
                    dataGridViewBW.Rows.Add(row);//ADICIONO A LINHA NA TABELA
                }

                connectionString.Close();
                //MessageBox.Show("Removido com sucesso"); ;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
                Console.WriteLine(ex.Message);
            }


        }

        private void bntLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();

        }

        private void limparCampos()
        {
            txbNomeMarca.Clear();
            txbDescricaoMarca.Clear();
            txbHistoriaMarca.Clear();

        }

        private void bntEditar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conn_string = new MySqlConnectionStringBuilder();
            conn_string.Server = "localhost";
            conn_string.Database = "belezaweb";
            conn_string.UserID = "root";
            conn_string.Password = "";
            MySqlConnection connectionString = new MySqlConnection(conn_string.ToString());


            try
            {
                connectionString.Open();
                MessageBox.Show("Connection Open ! ");
                

                MySqlCommand cmd = connectionString.CreateCommand();
                cmd.CommandText = "UPDATE marca SET nomeMarca = '" + txbNomeMarca.Text + "', " +
                        "descricaoMarca = '" + txbDescricaoMarca.Text + "', " +
                        "historiaMarca = '" + txbHistoriaMarca.Text + "' WHERE idMarca = " + txbID.Text + "";
                cmd.ExecuteNonQuery();
                connectionString.Close();
                MessageBox.Show(" Editado com sucesso");
                limparCampos();
                atualizarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
                Console.WriteLine(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           if (dataGridViewBW.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
           {
                dataGridViewBW.CurrentRow.Selected = true;
                txbID.Text = dataGridViewBW.Rows[e.RowIndex].Cells["ColumnID"].FormattedValue.ToString();
                txbNomeMarca.Text = dataGridViewBW.Rows[e.RowIndex].Cells["ColumnNome"].FormattedValue.ToString();
                txbDescricaoMarca.Text = dataGridViewBW.Rows[e.RowIndex].Cells["ColumnDescricao"].FormattedValue.ToString();
                txbHistoriaMarca.Text = dataGridViewBW.Rows[e.RowIndex].Cells["ColumnHistoria"].FormattedValue.ToString();
          
            }

        }

        private void bntExcluir_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conn_string = new MySqlConnectionStringBuilder();
            conn_string.Server = "localhost";
            conn_string.Database = "belezaweb";
            conn_string.UserID = "root";
            conn_string.Password = "";
            MySqlConnection connectionString = new MySqlConnection(conn_string.ToString());


            try
            {
                connectionString.Open();
                MessageBox.Show("Connection Open ! ");

                MySqlCommand cmd = connectionString.CreateCommand();
                cmd.CommandText = "UPDATE  marca SET InativoMarca = 1 WHERE idMarca = " + txbID.Text + "";

                cmd.ExecuteNonQuery();

                connectionString.Close();
                MessageBox.Show("Excluido com sucesso");
                limparCampos();
                atualizarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
                Console.WriteLine(ex.Message);
            }
        }
    }
}


