using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCP01.Models
{
    public class Vendedor : Pessoa
    {
        public string Email;

        public Vendedor(int id,string nome, int idade, string email) : base(id, nome, idade)
        {
            Email = email;
        }

        internal override string InfosPessoa()
        {
            return $"{Nome}, {Idade}, {Email}";
        }
    }
}
