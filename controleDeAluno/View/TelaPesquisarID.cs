using controleDeAluno.Controller;
using controleDeAluno.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controleDeAluno.View
{
    public partial class TelaPesquisarID : Form
    {
        public TelaPesquisarID()
        {
            InitializeComponent();
        }

        private void btnPesquisarPorID_Click(object sender, EventArgs e)
        {
            {
                Alunos.Id = Convert.ToInt32(textBoxCodigo.Text);
                GerenciadorAluno gt = new GerenciadorAluno();
                gt.Buscarid();

                textBoxNome.Text = Alunos.Nome;
                textBoxSala.Text = Alunos.Sala;
                textBoxTurma.Text = Alunos.Turma;
                textBoxEmail.Text = Alunos.Email;
                textBoxDatadeNascimento.Text = Alunos.DtNascimento;
                textBoxMedia.Text = Alunos.Media;
            }
        }
    }
}
