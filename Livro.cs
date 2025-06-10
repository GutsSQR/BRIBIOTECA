using System;

public class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }

    private int quantidade;
    public int Quantidade
    {
        get => quantidade;
        set
        {
            if (value < 0)
                throw new ArgumentException("Quantidade não pode ser negativa.");
            quantidade = value;
        }
    }

    public Livro(string titulo, string autor, int quantidade = 1)
    {
        if (quantidade < 0)
            throw new ArgumentException("Quantidade não pode ser negativa.");

        Titulo = titulo ?? throw new ArgumentNullException(nameof(titulo));
        Autor = autor ?? throw new ArgumentNullException(nameof(autor));
        Quantidade = quantidade;
    }

    public override string ToString()
    {
        return $"{Titulo} por {Autor} - Quantidade: {Quantidade}";
    }
}
