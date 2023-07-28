using controleDeAluno.Model;
using controleDeAluno.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleDeAluno.Controller
{
    internal class GerenciadorAluno
    {
        public void CadastrarAluno()
        {
            SqlConnection liAluno = new SqlConnection(Conexao.conectar());
            SqlCommand paluno = new SqlCommand("pCadastrar", liAluno);
            paluno.CommandType = CommandType.StoredProcedure;

            try
            {
                paluno.Parameters.AddWithValue("id", Alunos.Id);
                paluno.Parameters.AddWithValue("nome", Alunos.Nome);
                paluno.Parameters.AddWithValue("sala", Alunos.Sala);
                paluno.Parameters.AddWithValue("turma", Alunos.Turma);
                paluno.Parameters.AddWithValue("email", Alunos.Email);
                paluno.Parameters.AddWithValue("dtNascimento", Alunos.DtNascimento);
                paluno.Parameters.AddWithValue("media", Alunos.Media);

                liAluno.Open();
                paluno.ExecuteNonQuery();

                var resultado = MessageBox.Show("Aluno Cadastrado(a) com sucesso, Deseja cadastrar outro aluno(a)?", "Novo Registro",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resultado == DialogResult.Yes)
                {
                    TelaCadastrar tc = new TelaCadastrar();
                    tc.AbrirCadastro();
                }

            }
            catch (Exception)
            {

                throw;
            }
            

            
        }

        public void AlterarAluno()
        {
            SqlConnection liAluno = new SqlConnection(Conexao.conectar());
            SqlCommand pAluno = new SqlCommand("pAlterarAluno", liAluno);
            pAluno.CommandType = CommandType.StoredProcedure;

            try
            {
                pAluno.Parameters.AddWithValue("id", Alunos.Id);
                pAluno.Parameters.AddWithValue("nome", Alunos.Nome);
                pAluno.Parameters.AddWithValue("sala", Alunos.Sala);
                pAluno.Parameters.AddWithValue("turma", Alunos.Turma);
                pAluno.Parameters.AddWithValue("email", Alunos.Email);
                pAluno.Parameters.AddWithValue("dtNascimento", Alunos.DtNascimento);
                pAluno.Parameters.AddWithValue("media", Alunos.Media);

                liAluno.Open();
                pAluno.ExecuteNonQuery();

                MessageBox.Show("Peça Alterada com sucesso");
                Alunos.Id = 0;
                Alunos.Nome = "";
                Alunos.Sala= "";
                Alunos.Turma = "";
                Alunos.Email = "";
                Alunos.DtNascimento = "";
                Alunos.Media = "";
            }
            catch (Exception)
            {

                throw;
            }
         } 

        public void DeletarAluno()
        {
            SqlConnection liAluno = new SqlConnection(Conexao.conectar());
            SqlCommand pAluno = new SqlCommand("pDeletarAluno", liAluno);
            pAluno.CommandType = CommandType.StoredProcedure;

            try
            {
              pAluno.Parameters.AddWithValue ("id", Alunos.Id);
              liAluno.Open();
              pAluno.ExecuteNonQuery();

                var resultado = MessageBox.Show("Aluno(a) Deletada com sucesso, Deseja Deletar outro Aluno(o)?", "Deletar Outra",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resultado == DialogResult.Yes)
                {
                    TelaCadastrar tc = new TelaCadastrar();
                    tc.AbrirCadastro();
                }
                else
                {

                }
               

            }
            catch (Exception)
            {

                throw;
            }
  

        }

        public static BindingSource BuscarN() 
        {
            SqlConnection liALuno = new SqlConnection(Conexao.conectar());
            SqlCommand pAluno = new SqlCommand("pBuscaNome", liALuno);
            pAluno.CommandType = CommandType.StoredProcedure;

            pAluno.Parameters.AddWithValue("nome", Alunos.Nome);
            liALuno.Open();
            pAluno.ExecuteNonQuery();

            SqlDataAdapter da = new SqlDataAdapter(pAluno);
            DataTable dt = new DataTable();

            da.Fill(dt);

            BindingSource dados = new BindingSource();
            dados.DataSource = dt;

            return dados;

        }
        public void Buscarid() 
        {
            SqlConnection liAluno = new SqlConnection(Conexao.conectar());
            SqlCommand pAluno = new SqlCommand("pBuscarID", liAluno);
            pAluno.CommandType = CommandType.StoredProcedure;

            try
            {
                pAluno.Parameters.AddWithValue("id", Alunos.Id);
                liAluno.Open();
                pAluno.ExecuteNonQuery();

                var registro = pAluno.ExecuteReader();

                if (registro.Read())
                {
                    Alunos.Id = Convert.ToInt32(registro["id"]);
                    Alunos.Nome = (string)(registro["nome"]);
                    Alunos.Sala = (string)(registro["sala"]);
                    Alunos.Turma = (string)(registro["turma"]);
                    Alunos.DtNascimento = (string)(registro["dtNascimento"]);
                    Alunos.Media = (string)(registro["media"]);
                    Alunos.Email = (string)(registro["email"]);
                }
                else
                {
                    Alunos.Id = 0;
                    Alunos.Nome = "";
                    Alunos.Sala = "";
                    Alunos.Turma = "";
                    Alunos.Email = "";
                    Alunos.DtNascimento = "";
                    Alunos.Media = "";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
