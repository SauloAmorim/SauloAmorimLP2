using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variaveis
            string login, senha = "";           
            Usuario u = new Usuario();
            Console.Write("Insira o Login:");
            login = Console.ReadLine();
            u.login = login;
            Console.Write("Insira a senha:");
            senha = Console.ReadLine();
            u.senha = senha;

            bool query = false;
            int opcoes = 0;
            
            // Bagulho para entrar no banco de dados
            string strConn = "Server=localhost;Database=test;Uid=root;Pwd=";
            MySqlConnection conn = new MySqlConnection(strConn);
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT login FROM usuario";
            conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Console.WriteLine("{0} \r\nNome:{1}\r\nSenha:{2}\r\nEmail:{3}\r\nLogin:{4}\r\nUltimo Login:{5} ",reader.GetInt32(0),reader.GetString(1),reader.GetString(2),reader.GetChar(3),reader.GetString(4),reader.GetDateTime(5));
                }
            }
            reader.Close();
            conn.Close();

            // Início do Código
            Console.WriteLine("Bem vindo ao Programa");
            while (true)
            {
                Console.Write("Insira o Login:");
                login = Console.ReadLine();
                u.login = login;
                Console.Write("Insira a senha:");
                senha = Console.ReadLine();
                u.senha = senha;
                query = true;
            
                // Saída de Login feito com sucesso
                if (query == true)
                {
                    Console.WriteLine("Login feito com sucesso!");
                    Console.WriteLine("Bem-Vindo(a) {0}", login);
                    Console.WriteLine("Sua ultima entrada foi em");
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