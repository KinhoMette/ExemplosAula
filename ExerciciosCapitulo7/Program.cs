using System;

namespace ExerciciosCapitulo7
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Numero 1
            Console.WriteLine("Digite sua idade");
            var idade = Convert.ToInt32(Console.ReadLine());

            if (idade >= 13 && idade < 19)
            {
                Console.WriteLine("Adoslecente");
            }
            else if (idade >= 19 && idade <= 60)
            {
                Console.WriteLine("Adulto");
            }
            else if (idade > 60)
            {
                Console.WriteLine("Idoso");
            }
            else
            {
                Console.WriteLine("Criança");
            }

            //Numero 2

            Console.WriteLine("Quem ganhou a copa do mundo de 2014? A) Brasil B)Equador C)Alemanha D)Rússia");

            var respostaUsuario = Console.ReadLine().ToUpper();

            switch (respostaUsuario)
            {
                case "A":
                    Console.WriteLine("Errou");
                    break;

                case "B":
                    Console.WriteLine("Errou");
                    break;

                case "C":
                    Console.WriteLine("Acertou");
                    break;

                case "D":
                    Console.WriteLine("Errou");
                    break;

                default:
                    Console.WriteLine("Errou");
                    break;
            }
        }
    }
}