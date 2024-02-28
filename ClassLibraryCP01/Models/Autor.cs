using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCP01.Models
{
    public class Autor : Pessoa
    {
        public string Nacionalidade;

        public Autor(int id, string nome, int idade, string nacionalidade) : base(id, nome, idade)
        {
            Nacionalidade = nacionalidade;
        }
       
        internal override string InfosPessoa()
        {
            return $"{Nome}, {Idade}, {Nacionalidade}";
        }
    }
}
