using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string DataNascimento { get; set; }
        public double Salario { get; set; }
        public int Matricula { get; set; }
        public string cpf()
        {
            string s = String.Format("{0}.{1}.{2}-{3}",CPF.Substring(0,3),CPF.Substring(3,3),CPF.Substring(6,3),CPF.Substring(9,2));
            return CPF;
        }
        public string dataNascimento()
        {
            string n = String.Format("{0}/{1}/{2}", DataNascimento.Substring(0, 2), DataNascimento.Substring(2, 2), DataNascimento.Substring(4, 4));
            return DataNascimento;
        }
    }
}
