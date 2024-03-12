using learn_poo_csharp.Aula1;

Livro livro = new Livro();

livro.Nome = "Codigo limpo";
livro.Isbn = 123456;
livro.Autor = "Uncle Bob";

Console.WriteLine(livro.Nome + ", " + livro.Autor + ", " + livro.Isbn);