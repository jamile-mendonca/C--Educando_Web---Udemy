using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0011_Vetor
{
    class Estudante
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public Estudante(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
        public override string ToString()
        {
            return Nome + ", " + Email;
        }
    }
}  }
}
