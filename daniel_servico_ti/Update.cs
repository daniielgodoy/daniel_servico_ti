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

namespace daniel_servico_ti
{
    public partial class Update : Form
    {
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;

        string idDataGrid;
        public Update()
        {
            InitializeComponent();
            servidor = "Server=localhost;Database=bd_ti;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();
            DATAGRID_ATUALIZAR();
        }
        private void LIMPARTUDO()
        {
            textBoxNOME.Clear();
            textBoxCEL.Clear();
            textBoxPROC.Clear();
            textBoxPLACAM.Clear();
            textBoxFONTE.Clear();
            textBoxRAM.Clear();
            textBoxVIDEO.Clear();
            textBoxACESS.Clear();
            textBoxORC.Clear();
            textBoxOBS.Clear();
            textBoxQUEIXA.Clear();
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

        private void buttonUPDATE_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Deseja atualizar este registro?", "Atualizar!", MessageBoxButtons.YesNo))
            {
                try
                {
                    if (textBoxNOME.Text != "" && textBoxCEL.Text != "" && comboBoxSTATUS.Text != "")
                    {
                        conexao.Open();
                        comando.CommandText = "UPDATE cliente SET nome = '" + textBoxNOME.Text + "', celular = '" + textBoxCEL.Text + "', processador = '" + textBoxPROC.Text + "', placamae = '" + textBoxPLACAM.Text + "', fonte = '" + textBoxFONTE.Text + "', ram = '" + textBoxRAM.Text + "', video = '" + textBoxVIDEO.Text + "', acessorios = '" + textBoxACESS.Text + "', status = '" + comboBoxSTATUS.Text + "', dataentrada = '" + textBoxDATA.Text + "', orcamento = '" + textBoxORC.Text + "', observacao = '" + textBoxOBS.Text + "', queixa = '" + textBoxQUEIXA.Text + "' WHERE idcliente = "+idDataGrid+"";
                        int resultado = comando.ExecuteNonQuery();
                        if (resultado > 0)
                        {
                            MessageBox.Show("Registro atualizado!");
                        }
                        else
                        {
                            MessageBox.Show("Registro não encontrado!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nome e/ou Celular e/ou Status estão em BRANCO! Por favor preencha!");
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
                LIMPARTUDO();
            }
            else
            {
                MessageBox.Show("Você não atualizou o registro");
            }
        }

        private void dataGridViewTOP_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            idDataGrid = dataGridViewTOP.CurrentRow.Cells[0].Value.ToString();
            textBoxNOME.Text = dataGridViewTOP.CurrentRow.Cells[1].Value.ToString();
            textBoxCEL.Text = dataGridViewTOP.CurrentRow.Cells[2].Value.ToString();
            textBoxPROC.Text = dataGridViewTOP.CurrentRow.Cells[3].Value.ToString();
            textBoxPLACAM.Text = dataGridViewTOP.CurrentRow.Cells[4].Value.ToString();
            textBoxFONTE.Text = dataGridViewTOP.CurrentRow.Cells[5].Value.ToString();
            textBoxRAM.Text = dataGridViewTOP.CurrentRow.Cells[6].Value.ToString();
            textBoxVIDEO.Text = dataGridViewTOP.CurrentRow.Cells[7].Value.ToString();
            textBoxACESS.Text = dataGridViewTOP.CurrentRow.Cells[8].Value.ToString();
            comboBoxSTATUS.Text = dataGridViewTOP.CurrentRow.Cells[9].Value.ToString();
            textBoxDATA.Text = dataGridViewTOP.CurrentRow.Cells[10].Value.ToString();
            textBoxORC.Text = dataGridViewTOP.CurrentRow.Cells[11].Value.ToString();
            textBoxOBS.Text = dataGridViewTOP.CurrentRow.Cells[12].Value.ToString();
            textBoxQUEIXA.Text = dataGridViewTOP.CurrentRow.Cells[13].Value.ToString();


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
            Form TelaUpdate = new menu();
            TelaUpdate.FormClosed += (s, args) => this.Close();
            TelaUpdate.Show();
        }
    }
}
