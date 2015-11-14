using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_02_Conta_Bancaria
{
    class ContaBancaria
    {
        public string cliente {get; set;}
        public int num_conta { get; set; }
        public double saldo { get; set; }

        public void Depositar(double valor)
        {
            saldo += valor;
        }
        public void Sacar(double valor)
        {
            if (saldo - valor > 0)
            {
                saldo -= valor;
            }
            else
            {
                Console.WriteLine("O saldo não pode ser negativo.");
            }
        }

        public void Transferencia(double valor, ContaBancaria conta)
        {
            if (saldo != 0 && saldo > 0)
            {
                Console.WriteLine("Tem saldo.");
            }
            else 
            {
                Console.WriteLine("Não tem saldo.");
            }
        }
    }
}
