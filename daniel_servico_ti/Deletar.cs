using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace daniel_servico_ti
{
    public partial class Deletar : Form
    {
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;

        string idDataGrid;
        string statusDataGrid;
        string nomeDataGrid;
        public Deletar()
        {
            InitializeComponent();
            servidor = "Server=localhost;Database=bd_ti;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();
            DATAGRID_ATUALIZAR();
        }
        private void DATAGRID_ATUALIZAR()
        {
            try
            {
                conexao.Open();

                comando.CommandText = "SELECT * FROM cliente;";
                MySqlDataAdapter adaptadorTI = new MySqlDataAdapter(comando);
                DataTable tabelaTI = new DataTable();
                adaptadorTI.Fill(tabelaTI);

                dataGridViewTOP.DataSource = tabelaTI;
            }
            catch (Exception erro_mysql)
            {
                MessageBox.Show(erro_mysql.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Deseja selecionar o registro " + dataGridViewTOP.CurrentRow.Cells[1].Value.ToString() + " com o status " + dataGridViewTOP.CurrentRow.Cells[9].Value.ToString() + " ?", "Seleção!", MessageBoxButtons.YesNo))
            {
                idDataGrid = dataGridViewTOP.CurrentRow.Cells[0].Value.ToString();
                nomeDataGrid = dataGridViewTOP.CurrentRow.Cells[1].Value.ToString();
                statusDataGrid = dataGridViewTOP.CurrentRow.Cells[9].Value.ToString();
            }
        }

        private void buttonDELETAR_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Deseja deletar o registro "+nomeDataGrid+" com Status "+statusDataGrid+" cujo ID é "+idDataGrid+"", "Deletar!", MessageBoxButtons.YesNo))
            {
                try
                {

                    conexao.Open();
                    comando.CommandText = "DELETE FROM cliente WHERE idcliente = " + idDataGrid + ";";
                    int resultado = comando.ExecuteNonQuery();
                    if (resultado > 0)
                    {
                        MessageBox.Show("Registro deletado!");
                    }
                    else
                    {
                        MessageBox.Show("Registro não encontrado!");
                    }
                }
                catch (Exception erro_mysql)
                {
                    MessageBox.Show(erro_mysql.Message);

                }
                finally
                {
                    conexao.Close();
                }
                DATAGRID_ATUALIZAR();
            }
            else
            {
                MessageBox.Show("Você não deletou o registro");
            }
        }

        private void buttonBUSCAR_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxBUSCA.Text == "")
                {
                    DATAGRID_ATUALIZAR();
                }
                else
                {
                    conexao.Open();

                    comando.CommandText = "SELECT * FROM cliente WHERE nome = '" + textBoxBUSCA.Text + "';";
                    MySqlDataAdapter adaptadorTI = new MySqlDataAdapter(comando);
                    DataTable tabelaTI = new DataTable();
                    adaptadorTI.Fill(tabelaTI);

                    dataGridViewTOP.DataSource = tabelaTI;
                }
            }
            catch (Exception erro_mysql)
            {
                MessageBox.Show(erro_mysql.Message);
            }
            finally
            {
                conexao.Close();
            }
        }

        private void buttonVOLTAR_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form TelaDeletar = new menu();
            TelaDeletar.FormClosed += (s, args) => this.Close();
            TelaDeletar.Show();
        }
    }
}

