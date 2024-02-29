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


        // Construtor que chama construtor da classe pai
        public Vendedor(int id,string nome, int idade, string email) : base(id, nome, idade)
        {
            Email = email;
        }

        // Método protected que sobrescreve o método pai, colocando o email no retorno
        protected override string InfosPessoa()
        {
            return $"{Id}, {Nome}, {Idade}, {Email}";
        }
    }
}
