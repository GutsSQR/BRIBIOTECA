using System;

public class Emprestimo
{
    public Livro Livro { get; private set; }
    public Leitor Leitor { get; private set; }
    public DateTime DataEmprestimo { get; private set; }
    public DateTime DataDevolucaoPrevista { get; private set; }
    public DateTime? DataDevolucaoReal { get; private set; }
    public bool EstaDevolvido => DataDevolucaoReal.HasValue;

    public Emprestimo(Livro livro, Leitor leitor, int diasParaDevolucao = 7)
    {
        Livro = livro;
        Leitor = leitor;
        DataEmprestimo = DateTime.Now;
        DataDevolucaoPrevista = DataEmprestimo.AddDays(diasParaDevolucao);
        DataDevolucaoReal = null;
    }

    public void RegistrarDevolucao()
    {
        if (EstaDevolvido)
        {
            Console.WriteLine("Livro já foi devolvido.");
            return;
        }

        DataDevolucaoReal = DateTime.Now;
        Livro.Quantidade++;
    }

    public override string ToString()
    {
        string status = EstaDevolvido ? $"Devolvido em {DataDevolucaoReal}" : $"Devolver até {DataDevolucaoPrevista.ToShortDateString()}";
        return $"Livro: \"{Livro.Titulo}\", Leitor: {Leitor.Nome}, Emprestado em: {DataEmprestimo.ToShortDateString()}, Status: {status}";
    }
}
