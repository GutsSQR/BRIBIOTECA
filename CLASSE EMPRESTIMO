class Emprestimo
    {
        public Livro Emprestimo { get; set; }
        public Leitor Leitor { get; set; }
        public PeriodoEmprestimo Periodo { get; set; }

        public bool Ativo => !Periodo.DataDevolucao.HasValue;

        public Emprestimo(Livro livro, Leitor leitor)
        {
            LivroEmprestado = livro;
            Leitor = leitor;
            Periodo = new PeriodoEmprestimo(DateTime.Now);
        }

        public void Devolver()
        {
            Periodo.RegistrarDevolucao();
            LivroEmprestado.Quantidade++;
        }

        public override string ToString()
        {
            string status = Ativo ? "EM ANDAMENTO" : $"DEVOLVIDO em {Periodo.DataDevolucao.Value.ToShortDateString()}";
            return $"{LivroEmprestado.Titulo} -> {Leitor.Nome} em {Periodo.DataEmprestimo.ToShortDateString()} | {status}";
        }
    }
