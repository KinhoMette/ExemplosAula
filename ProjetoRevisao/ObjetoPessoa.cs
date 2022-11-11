using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoRevisao
{
    public class ObjetoPessoa
    {
        public string Nome { get; set; } = "Sem nome";
        public int Idade { get; set; } = 18;
        public DateTime? DataNascimento { get; set; } = DateTime.Now;
    }
}