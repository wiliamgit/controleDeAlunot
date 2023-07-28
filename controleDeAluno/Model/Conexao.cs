using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleDeAluno.Model
{
    internal class Conexao
    {
        public static string conectar()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wiliam.lsilva\source\repos\controleDeAluno\controleDeAluno\Model\bdAlunos.mdf;Integrated Security=True";
        }
    }
}