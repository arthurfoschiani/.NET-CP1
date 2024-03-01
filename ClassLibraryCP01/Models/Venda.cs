using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCP01.Models
{
    public class Venda
    {
        public int Id;
        public List<Livro> Livros;
        public Vendedor Vendedor;
        public double Total;


        // Construtor especializado
        public Venda(int id, List<Livro> livro, Vendedor vendedor, double total)
        {
            Id = id;
            Livros= livro;
            Vendedor = vendedor;
            Total = total;
        }

        // Construtor que utiliza o this para chamar o construtor especializado
        public Venda(int id, List<Livro> livros, Vendedor vendedor) : this(id, livros, vendedor, CalcularTotalLivros(livros))
        {
        }


        // Construtor convencional ou padrão
        public Venda()
        {
        }

        // Método internal que retorna no console o recibo da venda
        internal void GerarRecibo()
        {
            Console.WriteLine($"Venda ID: {Id}");
            Console.WriteLine($"Vendedor: {Vendedor.Nome}");
            Console.WriteLine("Livros:");
            foreach (var livro in Livros)
            {
                Console.WriteLine($"- {livro.Titulo}: {livro.Preco}");
            }
            Console.WriteLine($"Total: {Total}");
        }

        // Método privado para calcular o preço total dos livros da venda
        private static double CalcularTotalLivros(List<Livro> livros)
        {
            double total = 0;
            foreach (var livro in livros)
            {
                total += livro.Preco;
            }
            return total;
        }
    }
}
