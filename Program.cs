using System;
using System.Collections.Generic;

namespace CadastroUsuarios
{
    // Classe que representa um usuário
    public class Usuario
    {
        // Propriedades do usuário
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public int Idade { get; private set; }

        // Construtor da classe Usuario, que recebe nome, email e idade como parâmetros
        public Usuario(string nome, string email, int idade)
        {
            Nome = nome;
            Email = email;
            Idade = idade;
        }

        // Sobrescrita do método ToString para exibir o usuário de forma legível
        public override string ToString()
        {
            return $"{Nome} - {Email} - {Idade} anos";
        }
    }

    // Classe principal que contém as funcionalidades do cadastro de usuários
    public class CadastroUsuariosApp
    {
        // Lista que armazenará os usuários cadastrados
        private readonly List<Usuario> _usuarios;

        // Construtor que inicializa a lista de usuários
        public CadastroUsuariosApp()
        {
            _usuarios = new List<Usuario>();
        }

        // Método para iniciar a interação com o usuário
        public void Iniciar()
        {
            int opcao;

            do
            {
                ExibirMenu(); // Exibe o menu de opções
                opcao = ObterOpcaoUsuario(); // Obtém a opção escolhida pelo usuário
                ExecutarAcao(opcao); // Executa a ação correspondente à opção

            } while (opcao != 4); // O loop continua até que a opção 4 (Sair) seja escolhida
        }

        // Método para exibir o menu de opções no console
        private void ExibirMenu()
        {
            Console.Clear(); // Limpa a tela do console
            Console.WriteLine("---- Sistema de Cadastro de Usuários ----");
            Console.WriteLine("1. Cadastrar usuário");
            Console.WriteLine("2. Listar usuários");
            Console.WriteLine("3. Buscar usuário");
            Console.WriteLine("4. Sair");
        }

        // Método para obter a opção escolhida pelo usuário no menu
        private int ObterOpcaoUsuario()
        {
            Console.Write("Escolha uma opção: ");
            return int.TryParse(Console.ReadLine(), out var opcao) ? opcao : 0; // Converte a entrada para int, caso falhe retorna 0
        }

        // Método para executar a ação correspondente à opção escolhida
        private void ExecutarAcao(int opcao)
        {
            switch (opcao)
            {
                case 1:
                    CadastrarUsuario(); // Chama o método para cadastrar um novo usuário
                    break;
                case 2:
                    ListarUsuarios(); // Chama o método para listar todos os usuários cadastrados
                    break;
                case 3:
                    BuscarUsuario(); // Chama o método para buscar um usuário específico
                    break;
                case 4:
                    Console.WriteLine("Saindo do sistema..."); // Exibe mensagem de saída
                    break;
                default:
                    Console.WriteLine("Opção inválida!"); // Caso o usuário escolha uma opção inválida
                    break;
            }
            // Caso a opção não seja "Sair" (opção 4), espera que o usuário pressione uma tecla para continuar
            if (opcao != 4)
            {
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }

        // Método para cadastrar um novo usuário
        private void CadastrarUsuario()
        {
            Console.WriteLine("\nDigite os dados do usuário:");

            // Coleta os dados do usuário através de métodos auxiliares
            string nome = ObterEntrada("Nome: ");
            string email = ObterEntrada("E-mail: ");
            int idade = ObterEntradaInt("Idade: ");

            // Cria um novo objeto de usuário e adiciona à lista
            var usuario = new Usuario(nome, email, idade);
            _usuarios.Add(usuario);

            Console.WriteLine("Usuário cadastrado com sucesso!"); // Confirma o cadastro do usuário
        }

        // Método para listar todos os usuários cadastrados
        private void ListarUsuarios()
        {
            if (_usuarios.Count == 0) // Verifica se não há usuários cadastrados
            {
                Console.WriteLine("Nenhum usuário cadastrado.");
            }
            else
            {
                Console.WriteLine("\nLista de usuários cadastrados:");
                // Exibe os dados de todos os usuários
                foreach (var usuario in _usuarios)
                {
                    Console.WriteLine(usuario);
                }
            }
        }

        // Método para buscar um usuário pelo nome
        private void BuscarUsuario()
        {
            string nomeBusca = ObterEntrada("\nDigite o nome do usuário a ser buscado: ");
            // Usa o método Find para procurar um usuário pelo nome (ignorando diferenças de maiúsculas/minúsculas)
            var usuario = _usuarios.Find(u => u.Nome.Equals(nomeBusca, StringComparison.OrdinalIgnoreCase));

            if (usuario != null)
            {
                Console.WriteLine("\nUsuário encontrado:");
                Console.WriteLine(usuario); // Exibe os dados do usuário encontrado
            }
            else
            {
                Console.WriteLine("\nUsuário não encontrado."); // Caso o usuário não seja encontrado
            }
        }

        // Método auxiliar para obter uma entrada de string do usuário
        private string ObterEntrada(string mensagem)
        {
            Console.Write(mensagem);
            return Console.ReadLine();
        }

        // Método auxiliar para obter uma entrada de número inteiro
        private int ObterEntradaInt(string mensagem)
        {
            int valor;
            // Continua pedindo a entrada até que o usuário digite um valor válido
            do
            {
                Console.Write(mensagem);
            } while (!int.TryParse(Console.ReadLine(), out valor)); // Tenta converter a entrada para int
            return valor;
        }
    }

    // Classe principal que inicia o aplicativo
    class Program
    {
        static void Main(string[] args)
        {
            var app = new CadastroUsuariosApp(); // Cria uma instância da classe de cadastro de usuários
            app.Iniciar(); // Inicia o sistema
        }
    }
}

