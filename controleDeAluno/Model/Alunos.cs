using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleDeAluno.Model
{
    internal class Alunos
    {
        private static int id;
        private static string nome;
        private static string sala;
        private static string turma;
        private static string email;
        private static string dtNascimento;
        private static string media;

        public static int Id { get => id; set => id = value; }
        public static string Nome { get => nome; set => nome = value; }
        public static string Sala { get => sala; set => sala = value; }
        public static string Turma { get => turma; set => turma = value; }
        public static string Email { get => email; set => email = value; }
        public static string DtNascimento { get => dtNascimento; set => dtNascimento = value; }
        public static string Media { get => media; set => media = value; }
    }
}
