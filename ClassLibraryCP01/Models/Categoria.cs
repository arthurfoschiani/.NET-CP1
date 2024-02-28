using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryCP01.Models
{
    public class Categoria
    {
        public int Id;
        public string Titulo;

        public Categoria(int id, string titulo)
        {
            Id = id;
            Titulo = titulo;
        }

        public Categoria()
        {
        }
    }
}
