# Sistema de Cadastro de Usuários

Este é um projeto em C# que implementa um sistema simples de cadastro de usuários. O aplicativo permite ao usuário cadastrar, listar e buscar usuários no sistema por meio de um menu interativo no console.

## Funcionalidades

- **Cadastrar Usuário:** Permite ao usuário inserir os dados (nome, e-mail e idade) para cadastrar um novo usuário.
- **Listar Usuários:** Exibe todos os usuários cadastrados.
- **Buscar Usuário:** Permite buscar um usuário pelo nome.
- **Sair:** Encerra o sistema.

## Estrutura do Código

### 1. `Usuario`

Classe que representa um usuário no sistema. Contém as seguintes propriedades:

- `Nome`: Nome do usuário.
- `Email`: E-mail do usuário.
- `Idade`: Idade do usuário.

A classe possui um construtor para inicializar essas propriedades e um método `ToString()` para exibir os dados do usuário de forma legível.

### 2. `CadastroUsuariosApp`

Classe que contém a lógica principal do sistema de cadastro de usuários. Ela possui os seguintes métodos:

- **Iniciar():** Inicia o sistema e apresenta o menu de opções.
- **ExibirMenu():** Exibe as opções do menu no console.
- **ObterOpcaoUsuario():** Obtém a opção escolhida pelo usuário.
- **ExecutarAcao():** Executa a ação correspondente à opção escolhida.
- **CadastrarUsuario():** Coleta os dados do usuário e cadastra um novo usuário.
- **ListarUsuarios():** Exibe todos os usuários cadastrados.
- **BuscarUsuario():** Busca um usuário pelo nome e exibe suas informações.

### 3. `Program`

Classe responsável por iniciar o aplicativo. O método `Main()` cria uma instância da classe `CadastroUsuariosApp` e inicia o sistema.

## Como Executar

1. Clone este repositório para sua máquina local:

   ```bash
   git clone https://github.com/seu-usuario/nome-do-repositorio.git
