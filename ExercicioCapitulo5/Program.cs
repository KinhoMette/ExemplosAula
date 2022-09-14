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

            if (imc <= 18.5)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (imc > 18.5 && imc < 25)
            {
                Console.WriteLine("Normal");
            }
            else if (imc >= 25 && imc < 30)
            {
                Console.WriteLine("Excesso de peso");
            }
            else if (imc > 30 && imc < 35)
            {
                Console.WriteLine("Obesidade");
            }
            else
            {
                Console.WriteLine("Obesidade extrema");
            }
        }
    }
}