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

        // Construtor especializado
        public Pessoa(int id, string nome, int idade)
        {
            Id = id;
            Nome = nome;
            Idade = idade;
        }

        // Construtor convencional ou padrão
        public Pessoa()
        {
        }

        // Método privado para formatar o nome e deixar somente a primeira letra maíuscula
        private string FormatarNome(string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                return nome;
            }
            return char.ToUpper(nome[0]) + nome.Substring(1).ToLower();
        }

        // Método protected que retorna as informações da pessoa e permite ser sobrescrito
        protected virtual string InfosPessoa()
        {
            return $"{Id}, {Nome}, {Idade}";
        }
    }
}
