using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCapitulo13.Exceptions
{
    internal class ValorMuitoBaixoException : Exception
    {
        public ValorMuitoBaixoException(string message) : base(message)
        {
        }
    }
}