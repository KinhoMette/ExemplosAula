using System;

namespace ExericiosCondicional
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Digite o dia da semana em que estamos");
            string diaSemana = Console.ReadLine().ToUpper();

            switch (diaSemana)
            {
                case "SEGUNDA-FEIRA":
                    Console.WriteLine("1");
                    break;

                case "TERÇA-FEIRA":
                    Console.WriteLine("2");
                    break;

                case "QUARTA-FEIRA":
                    Console.WriteLine("3");
                    break;

                case "QUINTA-FEIRA":
                    Console.WriteLine("4");
                    break;

                case "SEXTA-FEIRA":
                    Console.WriteLine("5");
                    break;

                case "SÁBADO":
                    Console.WriteLine("6");
                    break;

                case "DOMINGO":
                    Console.WriteLine("7");
                    break;

                default:
                    Console.WriteLine("Tá errado, preencha direito isso aí");
                    break;
            }
            Console.Read();
        }
    }
}