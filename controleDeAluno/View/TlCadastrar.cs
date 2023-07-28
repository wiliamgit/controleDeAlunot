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
    public partial class TelaCadastrar : Form
    {
        public TelaCadastrar()
        {
            InitializeComponent();
        }

        private void btnCadastrarDados_Click(object sender, EventArgs e)
        {
           Alunos.Nome = textBoxNome.Text;
           Alunos.Sala = textBoxSala.Text;
           Alunos.Turma = textBoxTurma.Text;
           Alunos.Email= textBoxEmail.Text;
           Alunos.DtNascimento = textBoxDatadeNascimento.Text;
           Alunos.Media = textBoxMedia.Text;
           GerenciadorAluno grG = new GerenciadorAluno();
           grG.CadastrarAluno();

        }

       public void AbrirCadastro()
        {
            this.ShowDialog();
        }

        private void btnDeletaDados_Click(object sender, EventArgs e)
        {
            Alunos.Id = Convert.ToInt32(textBoxPesquisar.Text);
            GerenciadorAluno gt = new GerenciadorAluno();
            gt.DeletarAluno();
            
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Alunos.Id = Convert.ToInt32(textBoxPesquisar.Text);
            GerenciadorAluno gt = new GerenciadorAluno();
            gt.Buscarid();


            textBoxNome.Text  = Convert.ToString(Alunos.Id);
            textBoxNome.Text = Alunos.Nome; 
            textBoxSala.Text = Alunos.Sala;
            textBoxTurma.Text = Alunos.Turma;
            textBoxEmail.Text = Alunos.Email;
            textBoxDatadeNascimento.Text = Alunos.Sala;
            textBoxMedia.Text = Alunos.Media;
        }
    }
}
