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

        private void buttonSALVAR_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNOME.Text != "" && textBoxCEL.Text != "")
                {
                    conexao.Open();
                    comando.CommandText = "INSERT INTO cliente(nome, celular, processador, placamae, fonte, ram, video, acessorios, status, dataentrada, orcamento, observacao, queixa) VALUES ('" + textBoxNOME.Text + "', '" + textBoxCEL.Text + "', '" + textBoxPROC.Text + "', '" + textBoxPLACAM.Text + "', '" + textBoxFONTE.Text + "', '" + textBoxRAM.Text + "', '" + textBoxVIDEO.Text + "', '" + textBoxACESS.Text + "', '" + comboBoxSTATUS.Text + "', '" + textBoxDATA.Text + "', '" + textBoxORC.Text + "', '" + textBoxOBS.Text + "', '" + textBoxQUEIXA.Text + "');";
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cliente adicionado com sucesso!");

                  
                }
                else
                {
                    MessageBox.Show("Nome e/ou Celular estão em BRANCO! Por favor preencha!");

                    
                    
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

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
