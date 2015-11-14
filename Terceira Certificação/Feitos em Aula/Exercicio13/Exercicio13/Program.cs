using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Globalization;

namespace Exercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            Console.WriteLine("Bem vindo ao ａｅｓｔｅｔｈｉｃ  ｐｒｏｇｒａｍ");
            string resposta = "";
            while (resposta != "S")
            {
                Console.WriteLine("Digite I para inserir uma nova pessoa ou digite C para consultar ou se deseja sair, digite S");
                resposta = Console.ReadLine();
                if (resposta == "I")
                {

                    Console.WriteLine("Insira o nome:");
                    p.Nome = Console.ReadLine();
                    Console.WriteLine("Insira o Sobrenome:");
                    p.Sobrenome = Console.ReadLine();
                    Console.WriteLine("Insira o Peso:");
                    p.Peso = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Insira o Telefone:");
                    p.Telefone = int.Parse(Console.ReadLine());
                    Console.WriteLine("Insira o Altura:");
                    p.Altura = Convert.ToDouble(Console.ReadLine());

                    string strConn = "Server=localhost;Database=test;Uid=root;Pwd=";
                    string query = string.Format(new CultureInfo("en"), "INSERT into PESSOA (Nome, Sobrenome, Peso, Altura, Telefone) VALUES ('{0}' , '{1}' , '{2}', '{3}', '{4}')", p.Nome, p.Sobrenome, p.Peso, p.Altura, p.Telefone);

                    MySqlConnection conn = new MySqlConnection(strConn);
                    MySqlCommand command = new MySqlCommand();
                    command.Connection = conn;
                    command.CommandText = query;
                    conn.Open();
                    command.ExecuteNonQuery();
                    conn.Close();

                }
                else if (resposta == "C")
                {
                    Console.WriteLine("Deseja consultar pelo nome ou id?");
                    string respConsulta = Console.ReadLine();

                    if (respConsulta.ToLower() == "nome")
                    {
                        Console.WriteLine("Insira o nome:");
                        p.Nome = Console.ReadLine();
                        string strConn = "Server=localhost;Database=test;Uid=root;Pwd=";
                        string query = string.Format(new CultureInfo("en"), "SELECT * FROM PESSOA WHERE NOME = p.Nome");
                        MySqlConnection conn = new MySqlConnection(strConn);
                        MySqlCommand command = new MySqlCommand();
                        command.Connection = conn;
                        command.CommandText = query;
                        conn.Open();
                        MySqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine("Id: {0} Nome: {1} Sobrenome: {2} Peso: {3} Altura: {4} Telefone: {5} ", reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDouble(3), reader.GetDouble(4), reader.GetInt32(5));
                            }
                        }

                        reader.Close();
                        conn.Close();
                    
                    }

                    else if (respConsulta.ToLower() == "id")
                    {
                         Console.WriteLine("Insira o id:");
                         p.Id = int.Parse(Console.ReadLine());

                         string strConn = "Server=localhost;Database=test;Uid=root;Pwd=";
                         string query = string.Format(new CultureInfo("en"), "SELECT * FROM PESSOA WHERE ID = p.Id");

                         MySqlConnection conn = new MySqlConnection(strConn);
                         MySqlCommand command = new MySqlCommand();

                         command.Connection = conn;
                         command.CommandText = query;

                         conn.Open();
                         MySqlDataReader reader = command.ExecuteReader();
                         if (reader.HasRows)
                         {
                             while (reader.Read())
                             {
                                 Console.WriteLine("Id: {0} Nome: {1} Sobrenome: {2} Peso: {3} Altura: {4} Telefone: {5} ", reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDouble(3), reader.GetDouble(4), reader.GetInt32(5));
                             }
                         }

                         reader.Close();
                         conn.Close();
                    }
                }

            }
        }
    }
}
