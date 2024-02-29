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

        // Construtor que chama construtor da classe pai
        public Autor(int id, string nome, int idade, string nacionalidade) : base(id, nome, idade)
        {
            Nacionalidade = nacionalidade;
        }

        // Método protected que sobrescreve o método pai, colocando a nacionalidade no retorno
        protected override string InfosPessoa()
        {
            return $"{Id}, {Nome}, {Idade}, {Nacionalidade}";
        }
    }
}
