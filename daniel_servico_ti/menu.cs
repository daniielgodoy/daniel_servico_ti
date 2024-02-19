using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace daniel_servico_ti
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form TelaMenu = new Cadastro();
            TelaMenu.FormClosed += (s, args) => this.Close();
            TelaMenu.Show();
        }

        private void atualizarRegistrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form TelaMenu = new Update();
            TelaMenu.FormClosed += (s, args) => this.Close();
            TelaMenu.Show();
        }

        private void apagarRegistrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form TelaMenu = new Deletar();
            TelaMenu.FormClosed += (s, args) => this.Close();
            TelaMenu.Show();
        }

        private void relatórioOrçamentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form TelaMenu = new Relatorio();
            TelaMenu.FormClosed += (s, args) => this.Close();
            TelaMenu.Show();
        }
    }
}
