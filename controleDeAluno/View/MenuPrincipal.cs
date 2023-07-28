using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controleDeAluno.View
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadastrar telaCadastrar = new  TelaCadastrar();
            telaCadastrar.Show();
        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TlAlterar tl = new TlAlterar();
            tl.Show();
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaCadastrar telaCadastrar = new TelaCadastrar();
            telaCadastrar.Show();
        }

        private void PesquisarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaPesquisarID tp = new TelaPesquisarID();
            tp.Show();
        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
    