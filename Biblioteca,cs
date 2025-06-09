using System;
using System.Collections.Generic;

public class Biblioteca
{
    public List<Emprestimo> Emprestimos { get; set; } = new List<Emprestimo>();

    public void RegistrarEmprestimo(Livro livro, Leitor leitor)
    {
        if (livro.Quantidade <= 0)
        {
            Console.WriteLine($"Livro \"{livro.Titulo}\" está indisponível.");
            return;
        }

        livro.Quantidade--;
        var emprestimo = new Emprestimo(livro, leitor);
        Emprestimos.Add(emprestimo);
        Console.WriteLine($"[OK] {emprestimo}");
    }

    public void ListarEmprestimos()
    {
        Console.WriteLine("\n--- Empréstimos Registrados ---");
        foreach (var emp in Emprestimos)
        {
            Console.WriteLine(emp);
        }
    }
}
