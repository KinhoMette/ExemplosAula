using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ExercicioCapitulo14
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            StreamReader streamReader = new StreamReader(@"C:\Users\84961\source\Apex\Input\Alunos interessados.txt", Encoding.UTF8);

            var listNomesAlunos = new List<string>();

            while (!streamReader.EndOfStream)
            {
                var nome = streamReader.ReadLine();
                listNomesAlunos.Add(nome);
            }

            listNomesAlunos = listNomesAlunos.OrderBy(x => x).ToList();

            StreamWriter streamWriter = new StreamWriter(@"C:\Users\84961\source\Apex\Output\AlunosOrdenados.txt");
            streamWriter.AutoFlush = true;
            foreach (var nome in listNomesAlunos)
            {
                streamWriter.WriteLine(nome);
            }
            streamWriter.Close();
        }
    }
}