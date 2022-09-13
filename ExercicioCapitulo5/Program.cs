using System;

namespace ExercicioCapitulo5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            float peso = 0;
            float altura = 0;
            float imc = 0;

            Console.WriteLine("Digite seu peso:");
            peso = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua altura:");
            altura = float.Parse(Console.ReadLine());

            imc = (peso / (altura * altura));

            Console.WriteLine(imc);
        }
    }
}