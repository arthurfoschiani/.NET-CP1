using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCP01.Models
{
    public class Pessoa
    {
        public int Id;
        public string Nome;
        public int Idade;

        public Pessoa(int id, string nome, int idade)
        {
            Id = id;
            Nome = nome;
            Idade = idade;
        }

        public Pessoa()
        {
        }

        private void fazerAniversario ()
        {
            Idade = Idade + 1;
        }

        internal virtual string InfosPessoa()
        {
            return $"{Nome}, {Idade}";
        }
    }
}
