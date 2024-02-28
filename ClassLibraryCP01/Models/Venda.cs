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
        public Livro[] Livro;
        public Vendedor Vendedor;
        public double Total;

        public Venda(int id, Livro[] livro, Vendedor vendedor, double total)
        {
            Id = id;
            Livro = livro;
            Vendedor = vendedor;
            Total = total;
        }

        public Venda()
        {
        }

        public double calcularTotal()
        {
            double total = 0;
            foreach (var item in Livro)
            {
                total += item.Preco;
            }
            return total;
        }

        protected void visualizarVenda()
        {
            Console.WriteLine($"{Id}, {Livro.ToString()}, {Vendedor.ToString}, {Total}");
        }
    }
}
