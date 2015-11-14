using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_02_Conta_Bancaria
{
    class ContaEspecial : ContaBancaria
    {
        public double limite { get; set; }

        public override double Sacar(double valor)
        {
            if (saldo < limite || saldo == limite)
            {
                
                return saldo - valor;
            }
            else
                return saldo;
        }
    }
}
