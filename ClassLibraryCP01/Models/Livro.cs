using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCP01.Models
{
    public class Livro
    {
        public int Id;
        public string Titulo;
        public Autor Autor;
        public Categoria Categoria;
        public double Preco;

        public Livro(int id, string titulo, Autor autor, Categoria categoria, double preco)
        {
            Id = id;
            Titulo = titulo;
            Autor = autor;
            Categoria = categoria;
            Preco = preco;
        }

        public Livro()
        {
        }
    }
}
