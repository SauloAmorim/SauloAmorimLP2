using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_12
{
    class Gerente : Trabalhador
    {
        public string areaGerencia { get; set; }
        public double salarioBonus { get; set; }
        public double Setsalario()
        {
            this.salario = salarioBonus + salario;
            return this.salario;
        }
    }
}
