using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ExercicioBancoDeDados
{
    internal class Program
    {
        private const string conexao = @"Data Source=NOTEDESADM139\SQLEXPRESS;" +
                                        "Initial Catalog=PROJETO;" +
                                      "Integrated Security=SSPI;";

        private static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Voce quer atualizar, criar , ler ou deletar um registro?");
                var opcaoSelecionada = Console.ReadLine();

                switch (opcaoSelecionada)
                {
                    case "Criar":
                        InserirRegistro();
                        break;

                    case "Atualizar":
                        AtualizarRegistro();
                        break;

                    case "Listar":
                        ListarRegistros();
                        break;

                    case "Deletar":
                        DeletarRegistro();
                        break;

                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro:" + ex.Message);
                throw;
            }
        }

        private static void InserirRegistro()
        {
            SqlConnection connection = new SqlConnection(conexao);
            connection.Open();
            Console.WriteLine("Digite um nome");
            var nome = Console.ReadLine();
            Console.WriteLine("Digite uma idade");
            var idade = Console.ReadLine();
            Console.WriteLine("Digite um cpf");
            var cpf = Console.ReadLine();
            Console.WriteLine("Digite uma renda");
            var renda = Console.ReadLine();

            var queryInsert = $"insert into Cliente values ('{nome}',{short.Parse(idade)},'{cpf}',{Convert.ToDecimal(renda)})";
            SqlCommand comando = new SqlCommand(queryInsert, connection);
            comando.ExecuteNonQuery();

            Console.WriteLine("Cliente incluido com sucesso");
            connection.Close();
        }

        private static void AtualizarRegistro()
        {
            SqlConnection connection = new SqlConnection(conexao);
            connection.Open();
            Console.WriteLine("Qual Registro voce deseja atualizar?");
            var id = Console.ReadLine();

            Console.WriteLine("Digite um nome");
            var nome = Console.ReadLine();
            Console.WriteLine("Digite uma idade");
            var idade = Console.ReadLine();
            Console.WriteLine("Digite um cpf");
            var cpf = Console.ReadLine();
            Console.WriteLine("Digite uma renda");
            var renda = Console.ReadLine();

            var queryUpdate = $"update cliente set nome = '{nome}', idade = {idade}, cpf = '{cpf}', renda = {renda}" +
                $" where id = {id}";
            SqlCommand comando = new SqlCommand(queryUpdate, connection);
            comando.ExecuteNonQuery();

            Console.WriteLine("Cliente alterado com sucesso");
            connection.Close();
        }

        private static void DeletarRegistro()
        {
            SqlConnection connection = new SqlConnection(conexao);
            connection.Open();
            Console.WriteLine("Qual Registro voce deseja deletar?");
            var id = Console.ReadLine();

            var queryDelete = $"delete from Cliente where id = { id }";

            SqlCommand comando = new SqlCommand(queryDelete, connection);
            comando.ExecuteNonQuery();

            Console.WriteLine("Cliente deletado com sucesso");
            connection.Close();
        }

        private static void ListarRegistros()
        {
            SqlConnection connection = new SqlConnection(conexao);
            connection.Open();
            var querySelect = $"select * from Cliente";

            SqlCommand comando = new SqlCommand(querySelect, connection);
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                var cliente = new Cliente
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Nome = reader["Nome"].ToString(),
                    Idade = Convert.ToInt16(reader["Idade"]),
                    Cpf = reader["Cpf"].ToString(),
                    Renda = Convert.ToDecimal(reader["Renda"])
                };
                Console.WriteLine($"{cliente.Id} - {cliente.Nome} - {cliente.Idade} - {cliente.Cpf} - {cliente.Renda}");
            }
            connection.Close();
        }
    }
}