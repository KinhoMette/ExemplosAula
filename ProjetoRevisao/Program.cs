using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ProjetoRevisao
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome");
            var nome = Console.ReadLine();

            Console.WriteLine("Digite seu Cpf");
            var cpf = Console.ReadLine();

            Console.WriteLine("Digite sua idade");
            var idade = int.Parse(Console.ReadLine());

            var dataNascimento = DateTime.Now.AddYears(-idade);

            Cliente cliente = new Cliente();
            cliente.Cadastrar(MascaraCpf(cpf), FormatarNome(nome), dataNascimento);

            var menorIdade = VerificaMenorDeIdade(dataNascimento);
            if (menorIdade)
                Console.WriteLine("Cliente menor de idade");
        }

        public static bool VerificaMenorDeIdade(DateTime dataNascimento)
        {
            if (dataNascimento < DateTime.Now.AddYears(-18))
            {
                return false;
            }
            return true;
        }

        private static string MascaraCpf(string cpf)
        {
            return cpf.Remove(4, 7).Insert(4, "XXX.XXX");
        }

        private static string FormatarNome(string nomeCompleto)
        {
            StringBuilder meio = new();
            var nomes = nomeCompleto.Split(' ');
            for (var i = 1; i < nomes.Length - 1; i++)
            {
                if (!nomes[i].Equals("de", StringComparison.OrdinalIgnoreCase) &&
                    !nomes[i].Equals("da", StringComparison.OrdinalIgnoreCase) &&
                    !nomes[i].Equals("do", StringComparison.OrdinalIgnoreCase) &&
                    !nomes[i].Equals("das", StringComparison.OrdinalIgnoreCase) &&
                    !nomes[i].Equals("dos", StringComparison.OrdinalIgnoreCase))
                {
                    var nome = nomes[i].Trim();
                    if (string.IsNullOrEmpty(nome))
                        continue;

                    var letraNome = nome[0];
                    meio.Append($"{letraNome}. ");
                }
            }
            return $"{nomes[0]} {meio.ToString().ToUpper()}{nomes.Last()}".Trim();
        }
    }
}