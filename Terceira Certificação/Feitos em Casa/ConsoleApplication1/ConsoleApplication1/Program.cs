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
            int opcoes = 0;
            string user = "";
            string senha = "";

            // Início do Código
            Console.WriteLine("Bem vindo ao Programa");
            while (true)
            {
                Console.Write("Insira o nome de usuário:");
                user = Console.ReadLine();
                Console.Write("Insira a senha:");
                senha = Console.ReadLine();
                query = true;
            
                // Saída de Login feito com sucesso
                if (query == true)
                {
                    Console.WriteLine("Login feito com sucesso!");
                    Console.WriteLine("Bem-Vindo(a) {0}", user);
                    Console.WriteLine("Sua ultima entrada foi em {0}", u.ultimoLogIn);
                    // Loop da tela de opções
                    while (opcoes != 4)
                    {
                        Console.WriteLine("O Que deseja fazer? \r\n[1]- Acessar as Credenciais \r\n[2]- Alterar as Credenciais \r\n[3]- Modificar \r\n[4]- Sair ");
                        opcoes = int.Parse(Console.ReadLine());
                        switch (opcoes)
                        {
                            case 1:
                                Console.WriteLine("SERVIÇO INDISPONÍVEL");
                                break;
                            case 2:
                                Console.WriteLine("SERVIÇO INDISPONÍVEL");
                                break;
                            case 3:
                                Console.WriteLine("SERVIÇO INDISPONÍVEL");
                                break;
                            case 4:
                                break;
                            default:
                                Console.WriteLine("Digite uma das opções");
                                break;
                        }
                    }
                
                }

                // Saída de Erro
                if (query == false)
                {
                    Console.WriteLine("Senha ou Usuário não encontrado");
                }                
            }
            

        }
    }
}
