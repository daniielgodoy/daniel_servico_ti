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

    public partial class Cadastro : Form
    {
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;
        
        public Cadastro()

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

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

        private void buttonSALVAR_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Deseja cadastrar este registro?", "Cadastro!", MessageBoxButtons.YesNo))
            {
                try
                {
                    if (textBoxNOME.Text != "" && textBoxCEL.Text != "" && comboBoxSTATUS.Text != "")
                    {
                        conexao.Open();
                        comando.CommandText = "INSERT INTO cliente(nome, celular, processador, placamae, fonte, ram, video, acessorios, status, dataentrada, orcamento, observacao, queixa) VALUES ('" + textBoxNOME.Text + "', '" + textBoxCEL.Text + "', '" + textBoxPROC.Text + "', '" + textBoxPLACAM.Text + "', '" + textBoxFONTE.Text + "', '" + textBoxRAM.Text + "', '" + textBoxVIDEO.Text + "', '" + textBoxACESS.Text + "', '" + comboBoxSTATUS.Text + "', '" + textBoxDATA.Text + "', '" + textBoxORC.Text + "', '" + textBoxOBS.Text + "', '" + textBoxQUEIXA.Text + "');";
                        comando.ExecuteNonQuery();
                        MessageBox.Show("Serviço adicionado com sucesso!");
                        LIMPARTUDO();
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
            }
            else
            {
                MessageBox.Show("Você não cadastrou o registro");
            }
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Deseja limpar os campos?", "Limpar!", MessageBoxButtons.YesNo))
            {
                LIMPARTUDO();
            }
        }

        private void buttonVOLTAR_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form TelaCadastro = new menu();
            TelaCadastro.FormClosed += (s, args) => this.Close();
            TelaCadastro.Show();
        }
    }
}
