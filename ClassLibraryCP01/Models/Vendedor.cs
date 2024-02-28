using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCP01.Models
{
    public class Vendedor : Pessoa
    {
        public double Comissao;

        public Vendedor(int id,string nome, int idade, double comissao) : base(id, nome, idade)
        {
            Comissao = comissao;
        }

        internal override string InfosPessoa()
        {
            return $"{Nome}, {Idade}, {Comissao}";
        }
    }
}
