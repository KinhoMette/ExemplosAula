using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCapitulo13.Exceptions
{
    internal class ValorMuitoAltoException : Exception
    {
        public ValorMuitoAltoException(string message) : base(message)
        {
        }
    }
}