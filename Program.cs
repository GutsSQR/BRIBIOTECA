class Program
{
    static Biblioteca biblioteca = new Biblioteca();

    static void Main()
    {
        int opcao;
        do
        {
            Console.WriteLine("\n MENU ");
            Console.WriteLine("1. Cadastrar Livro");
            Console.WriteLine("2. Cadastrar Usuário");
            Console.WriteLine("3. Registrar Empréstimo");
            Console.WriteLine("4. Registrar Devolução");
            Console.WriteLine("5. Relatório - Livros Disponíveis");
            Console.WriteLine("6. Relatório - Livros Emprestados");
            Console.WriteLine("7. Relatório - Usuários com Livros");
            Console.WriteLine("0. Sair");
            Console.Write("Selecione a opção: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    CadastrarLivro(); break;
                case 2:
                    CadastrarUsuario(); break;
                case 3:
                    RegistrarEmprestimo(); break;
                case 4:
                    RegistrarDevolucao(); break;
                case 5:
                    biblioteca.RelatorioLivrosDisponiveis(); break;
                case 6:
                    biblioteca.RelatorioLivrosEmprestados(); break;
                case 7:
                    biblioteca.RelatorioUsuariosComLivros(); break;
            }

        } while (opcao != 0);
    }

    static void CadastrarLivro()
    {
        Console.Write("Título: ");
        string titulo = Console.ReadLine();
        Console.Write("Autor: ");
        string autor = Console.ReadLine();
        Console.Write("Nome: ");
        string Nome = Console.ReadLine();
        Console.Write("Quantidade: ");
        int quantidade = int.Parse(Console.ReadLine());

        var livro = new Livro(titulo, autor, Nome, quantidade);
        biblioteca.CadastrarLivro(livro);
        Console.WriteLine("Livro cadastrado!");
    }

    static void CadastrarUsuario()
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Matrícula: ");
        string matricula = Console.ReadLine();

        var usuario = new Usuario(nome, matricula);
        biblioteca.CadastrarUsuario(usuario);
        Console.WriteLine("Usuário cadastrado!");
    }

    static void RegistrarEmprestimo()
    {
        Console.Write("Nome do livro: ");
        string Nome = Console.ReadLine();
        Console.Write("Matrícula do usuário: ");
        string matricula = Console.ReadLine();

        biblioteca.RegistrarEmprestimo(Nome, matricula);
    }

    static void RegistrarDevolucao()
    {
        Console.Write("Nome do livro: ");
        string Nome = Console.ReadLine();
        Console.Write("Matrícula do usuário: ");
        string matricula = Console.ReadLine();

        biblioteca.RegistrarDevolucao(Nome, matricula);
    }
}
