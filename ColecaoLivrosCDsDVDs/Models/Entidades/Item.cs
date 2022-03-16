using ColecaoLivrosCDsDVDs.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ColecaoLivrosCDsDVDs.Models
{
    public class Item
    {
        public class Livro
        {
            public int Id { get;}

            public string Nome { get; set; }

            public Genero Genero { get; set; }

            public string Autor { get; set; }
        }

        public class DVD
        {
            public int Id { get;}

            public string Nome { get; set; }

            public Genero Genero { get; set; }
        }

        public class CD
        {
            public int Id { get;}

            public string Nome { get; set; }

            public string Cantor { get; set; }

            public GeneroMusical GeneroMusical { get; set; }
        }
    }
}
