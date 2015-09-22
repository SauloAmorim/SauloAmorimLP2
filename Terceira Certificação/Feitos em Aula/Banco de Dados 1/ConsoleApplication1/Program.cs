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
            Console.WriteLine("Insira o nome:");
            string nome = Console.ReadLine();
            string query = "INSERT into PESSOA (Nome) VALUES ('" + nome + "')";
            string strConn = "Server=localhost;Database=test;Uid=root;Pwd=";
            MySqlConnection conn = new MySqlConnection(strConn);
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn;
            command.CommandText = query;
            conn.Open();
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}

