using MySql.Data.MySqlClient;
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
    public partial class Relatorio : Form
    {
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;
        public Relatorio()
        {
            InitializeComponent();
            servidor = "Server=localhost;Database=bd_ti;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();
      
        }
        

        private void buttonBUSCAR_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("Pesquisa invalida");
                }
                else
                {
                    conexao.Open();

                    comando.CommandText = "SELECT SUM(orcamento) FROM cliente WHERE status = '" + comboBox1.Text + "';";
                    MySqlDataAdapter adaptadorTI = new MySqlDataAdapter(comando);
                    DataTable tabelaTI = new DataTable();
                    adaptadorTI.Fill(tabelaTI);

                    dataGridViewTOP.DataSource = tabelaTI;

                    comando.CommandText = "SELECT nome, observacao, dataentrada, orcamento FROM cliente WHERE status = '" + comboBox1.Text + "';";
                    MySqlDataAdapter adaptadorTI2 = new MySqlDataAdapter(comando);
                    DataTable tabelaTI2 = new DataTable();
                    adaptadorTI2.Fill(tabelaTI2);

                    dataGridViewSELECT.DataSource = tabelaTI2;
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
            Form TelaRelatorio = new menu();
            TelaRelatorio.FormClosed += (s, args) => this.Close();
            TelaRelatorio.Show();
        }

        private void buttonBUSCAR2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxDATA.Text == "")
                {
                    MessageBox.Show("Pesquisa invalida");
                }
                else
                {
                    conexao.Open();

                    comando.CommandText = "SELECT SUM(orcamento) FROM cliente WHERE dataentrada = '" + textBoxDATA.Text + "';";
                    MySqlDataAdapter adaptadorTI = new MySqlDataAdapter(comando);
                    DataTable tabelaTI = new DataTable();
                    adaptadorTI.Fill(tabelaTI);

                    dataGridViewTOP.DataSource = tabelaTI;

                    comando.CommandText = "SELECT nome, observacao, dataentrada, orcamento FROM cliente WHERE dataentrada = '" + textBoxDATA.Text + "';";
                    MySqlDataAdapter adaptadorTI2 = new MySqlDataAdapter(comando);
                    DataTable tabelaTI2 = new DataTable();
                    adaptadorTI2.Fill(tabelaTI2);

                    dataGridViewSELECT.DataSource = tabelaTI2;
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

        private void buttonENTREDATAS_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxDATAS1.Text == "" && textBoxDATAS2.Text == "")
                {
                    MessageBox.Show("Pesquisa invalida");
                }
                else
                {
                    conexao.Open();

                    comando.CommandText = "SELECT SUM(orcamento) FROM cliente WHERE dataentrada BETWEEN '" + textBoxDATAS1.Text + "' AND '" + textBoxDATAS2.Text + "';";
                    MySqlDataAdapter adaptadorTI = new MySqlDataAdapter(comando);
                    DataTable tabelaTI = new DataTable();
                    adaptadorTI.Fill(tabelaTI);

                    dataGridViewTOP.DataSource = tabelaTI;

                    comando.CommandText = "SELECT nome, observacao, dataentrada, orcamento FROM cliente WHERE dataentrada BETWEEN '" + textBoxDATAS1.Text + "' AND '"+textBoxDATAS2.Text+"';";
                    MySqlDataAdapter adaptadorTI2 = new MySqlDataAdapter(comando);
                    DataTable tabelaTI2 = new DataTable();
                    adaptadorTI2.Fill(tabelaTI2);

                    dataGridViewSELECT.DataSource = tabelaTI2;
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
    }

    }
    
    

