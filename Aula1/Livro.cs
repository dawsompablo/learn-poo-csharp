using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace learn_poo_csharp.Aula1
{
    public class Livro
    {
        public int? Isbn { get; set; }
        public string? Nome { get; set; }
        public string? Autor { get; set; }

        public Livro() { }

        public Livro(string nome, string autor, int isbn)
        {
            this.Nome = nome;
            this.Autor = autor;
            this.Isbn = isbn;
        }
    }
}