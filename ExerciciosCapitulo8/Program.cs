using System;
using System.Collections.Generic;

namespace ExerciciosCapitulo8
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero");
            var numero = Convert.ToInt32(Console.ReadLine());

            for (int i = numero; i >= 0; i--)
            {
                Console.WriteLine(i);
            }

            Exercicio2();
            Exercicio3();
        }

        private static void Exercicio2()
        {
            var contador = 0;
            int numero;
            do
            {
                Console.WriteLine("Digite um número par");
                numero = Convert.ToInt32(Console.ReadLine());
                contador++;
            } while (numero % 2 != 0);

            var x = numero / 2;

            Console.WriteLine(x * contador);
        }

        private static void Exercicio3()
        {
            var resposta = "";
            while (resposta != "D")
            {
                Console.WriteLine("Qual time ganhou a copa de 2014? A) Brasil B) Belgica C) Equador D) Alemanha");
                resposta = Console.ReadLine().ToUpper();

                if (resposta != "D")
                {
                    Console.WriteLine("Errou");
                }
            }
            Console.WriteLine("Acertou!");
        }
    }
}