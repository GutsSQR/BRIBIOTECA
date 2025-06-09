public class Leitor : Pessoa
{
    public string Matricula { get; set; }

    public Leitor(string nome, string matricula) : base(nome)
    {
        Matricula = matricula;
    }

    public override string ToString()
    {
        return $"{Nome} (Matrícula: {Matricula})";
    }
}
