using System;
using System.Collections.Generic;
using System.Linq;

namespace CorrijaMe
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Cliente cliente = new Cliente();

            Console.WriteLine("Digite seu nome");
            var nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade");
            var idade = int.Parse(Console.ReadLine());

            var idadeTexto = ConverteIdadeParaTexto(cliente.Idade.Value);

            Console.WriteLine("Sua idade é:" + idadeTexto);

            List<string> listaNomes = new List<string>();

            var primeiroNome = RetornaPrimeiroNome(listaNomes);

            Console.WriteLine("Este é o primeiro nome da lista" + primeiroNome.ToUpper());
        }

        public static string ConverteIdadeParaTexto(int idade)
        {
            return idade.ToString();
        }

        public static string RetornaPrimeiroNome(List<string> listaDeNomes)
        {
            return listaDeNomes.FirstOrDefault();
        }
    }
}