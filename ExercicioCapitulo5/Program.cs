using System;

namespace ExercicioCapitulo5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Digite seu peso:");
            float peso = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua altura:");
            float altura = float.Parse(Console.ReadLine());

            float imc = peso / (altura * altura);
            Console.WriteLine(imc);
        }
    }
}