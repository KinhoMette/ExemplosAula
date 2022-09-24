using ExercicioCapitulo13.Exceptions;
using System;

namespace TryCatchFinalyExamples
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            try
            {
                int numero;
                Console.WriteLine("Digite um numero");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero < 10)
                    throw new ValorMuitoBaixoException("Ops valor muito baixo");

                if (numero > 10000)
                    throw new ValorMuitoAltoException("Ops valor muito alto");

                for (int i = 0; i < numero; i++)
                {
                    Console.WriteLine(i + 1);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }
    }
}