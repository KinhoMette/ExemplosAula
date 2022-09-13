using System;

namespace OlaMundo
{
    /// <summary>
    /// Método principal do programa
    /// </summary>
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Digite seu nome completo");
            var nomeCompleto = Console.ReadLine();

            Console.WriteLine("Digite sua idade");
            var idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu telefone");
            var telefone = Console.ReadLine();
            telefone = FormataTelefone(telefone);

            var raizQuadradaIdade = CalculaRaizQuadrada(idade);
            var nomeFormatado = FormartarNome(nomeCompleto);

            Console.WriteLine("Seu nome é:" + nomeFormatado);
            Console.WriteLine("Sua idade é:" + idade);
            Console.WriteLine("A raiz quadrada da sua idade é:" + raizQuadradaIdade);
            Console.WriteLine("Seu telefone é:" + telefone);
        }

        private static string FormataTelefone(string telefone)
        {
            telefone = telefone.Insert(0, "(").Insert(3, ")").Insert(9, "-");
            return telefone;
        }

        private static double CalculaRaizQuadrada(int idade)
        {
            var raizQuadradaIdade = Math.Sqrt(idade);
            return raizQuadradaIdade;
        }

        private static string FormartarNome(string nome)
        {
            var nomeFormatado = nome.Replace(" ", ";");
            return nomeFormatado;
        }
    }
}