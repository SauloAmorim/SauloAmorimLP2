using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variaveis
            Usuarios u = new Usuarios();
            bool query = false;
            string user = "";
            string senha = "";

            // Início do Código
            Console.WriteLine("Bem vindo ao Programa");
            Console.Write("Insira o nome de usuário:");
            user = Console.ReadLine();
            Console.Write("Insira a senha:");
            senha = Console.ReadLine();
            
            // Saída de Acerto
            if (query == true)
            {
                Console.WriteLine("Bem Vindo {0}", user);
                Console.WriteLine("Sua ultima entrada foi em {0}", u.ultimoLogIn);
            }

            // Saída de Erro
            if (query == false)
            {
                Console.WriteLine("Senha ou Usuário não encontrado");
            }

        }
    }
}
