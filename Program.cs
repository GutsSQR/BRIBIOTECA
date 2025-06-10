using System;

class Program
{
    static void Main(string[] args)
    {
        var livro1 = new Livro("NARNIA", "Clive", 2);
        var livro2 = new Livro("Hobbit", "Tolkien", 1);

        var leitor1 = new Leitor("Bolsonaro L", "A123");
        var leitor2 = new Leitor("Mago da peda", "B456");

        var biblioteca = new Biblioteca();

        biblioteca.RegistrarEmprestimo(livro1, leitor1);
        biblioteca.RegistrarEmprestimo(livro2, leitor2);
        biblioteca.RegistrarEmprestimo(livro2, leitor1);

        biblioteca.ListarEmprestimos();
    }
}
