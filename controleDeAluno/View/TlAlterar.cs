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
    public partial class TlAlterar : Form
    {
        public TlAlterar()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Alunos.Id = Convert.ToInt32(textBoxPesquisar.Text);
            GerenciadorAluno gt = new GerenciadorAluno();
            gt.Buscarid();


            textBoxNome.Text = Convert.ToString(Alunos.Id);
            textBoxNome.Text = Alunos.Nome;
            textBoxSala.Text = Alunos.Sala;
            textBoxTurma.Text = Alunos.Turma;
            textBoxEmail.Text = Alunos.Email;
            textBoxDatadeNascimento.Text = Alunos.Sala;
            textBoxMedia.Text = Alunos.Media;
        }

        private void btnAlterarDados_Click(object sender, EventArgs e)
        {
            Alunos.Id = Convert.ToInt32(textBoxPesquisar.Text);
            Alunos.Nome = textBoxNome.Text;
            Alunos.Sala = textBoxSala.Text;
            Alunos.Turma = textBoxTurma.Text;
            Alunos.Email = textBoxEmail.Text;
            Alunos.Sala = textBoxDatadeNascimento.Text;
            Alunos.Media = textBoxMedia.Text;

            GerenciadorAluno gc = new GerenciadorAluno();
            gc.AlterarAluno();

        }
    }
}
