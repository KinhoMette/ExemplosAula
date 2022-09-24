using System;
using System.Collections.Generic;

namespace ExerciciosCapitulo9
{
    internal class Program
    {
        private static void Main()
        {
            var valores = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            List<int> valoresMultiplicados = new();

            for (int i = 0; i < valores.Length; i++)
            {
                Console.WriteLine("valores iniciais: " + valores[i]);

                valoresMultiplicados.Add(valores[i] * 10);
            }

            foreach (var valor in valoresMultiplicados)
            {
                Console.WriteLine("valores multiplicados: " + valor);
            }

            Console.Read();
        }
    }
}