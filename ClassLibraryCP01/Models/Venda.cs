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

        public Venda(int id, List<Livro> livro, Vendedor vendedor, double total)
        {
            Id = id;
            Livros= livro;
            Vendedor = vendedor;
            Total = total;
        }

        public Venda()
        {
        }

        protected void visualizarVenda()
        {
            Console.WriteLine($"{Id}, {Livros.ToString()}, {Vendedor.ToString}, {Total}");
        }
    }
}
