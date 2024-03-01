using ClassLibraryCP01.Models;
using System;

Console.WriteLine("---------- Seja bem-vindo ao nosso sistema! ----------");

// Declaração de listas para armazenar os dados do sistema
var autores = new List<Autor>();
var categorias = new List<Categoria>();
var livros = new List<Livro>();
var vendedores = new List<Vendedor>();
var vendas = new List<Venda>();


// Criação e adição de autores iniciais
Autor arthur = new Autor(1, "Arthur", 20, "Brasileiro");
Autor alicia = new Autor(2, "Alícia", 23, "Brasileiro");
autores.Add(arthur);
autores.Add(alicia);

// Criação e adição de categorias iniciais
Categoria romance = new Categoria(1, "Romance");
Categoria aventura = new Categoria(2, "Aventura");
categorias.Add(romance);
categorias.Add(aventura);

// Criação e adição de livros iniciais
Livro harryPotter = new Livro(1, "Harry Potter", arthur, aventura, 100.0);
Livro romeuEJulieta = new Livro(2, "Romeu e Julieta", alicia, romance, 150.0);
livros.Add(harryPotter);
livros.Add(romeuEJulieta);

// Criação e adição de vendedores iniciais
Vendedor anaCarolina = new Vendedor(1, "Ana Carolina", 26, "ana.carol@gmail.com");
Vendedor larah = new Vendedor(2, "Larah", 27, "larah@gmail.com");
vendedores.Add(anaCarolina);
vendedores.Add(larah);

// Loop principal do programa, o qual o usuário faz suas tarefas
bool continuar = true;
while (continuar)
{
    // Exibição do menu de opções
    Console.WriteLine();
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1 - Adicionar Livro");
    Console.WriteLine("2 - Listar Livros");
    Console.WriteLine("3 - Adicionar Autor");
    Console.WriteLine("4 - Listar Autores");
    Console.WriteLine("5 - Adicionar Categoria");
    Console.WriteLine("6 - Listar Categorias");
    Console.WriteLine("7 - Adicionar Vendedor");
    Console.WriteLine("8 - Listar Vendedores");
    Console.WriteLine("9 - Registrar Venda");
    Console.WriteLine("10 - Listar Vendas");
    Console.WriteLine("11 - Listar Livros com Preço Acima de um Valor");
    Console.WriteLine("12 - Listar Livros por Categoria");
    Console.WriteLine("13 - Listar Venda por Vendedor");
    Console.WriteLine("14 - Sair");

    // Leitura da opção escolhida pelo usuário
    int opcao = Convert.ToInt32(Console.ReadLine());

    // Tratamento da opção escolhida
    switch (opcao)
    {
        case 1:
            // Adiciona um novo livro
            Console.WriteLine("Vc escolheu: Adicionar um novo livro");
            AdicionarLivro(livros, autores, categorias);
            break;
        case 2:
            // Lista todos os livros
            Console.WriteLine("Vc escolheu: Listar todos os livros");
            ListarLivros(livros);
            break;
        case 3:
            // Adiciona um novo autor
            Console.WriteLine("Vc escolheu: Adicionar um novo autor");
            AdicionarAutor(autores);
            break;
        case 4:
            // Lista todos os autores
            Console.WriteLine("Vc escolheu: Listar todos os autores");
            ListarAutores(autores);
            break;
        case 5:
            // Adiciona uma nova categoria
            Console.WriteLine("Vc escolheu: Adicionar uma nova categoria");
            AdicionarCategoria(categorias);
            break;
        case 6:
            // Lista todas as categorias
            Console.WriteLine("Vc escolheu: Listar todas as categorias");
            ListarCategorias(categorias);
            break;
        case 7:
            // Adiciona um novo vendedor
            Console.WriteLine("Vc escolheu: Adicionar um novo vendedor");
            AdicionarVendedor(vendedores);
            break;
        case 8:
            // Lista todos os vendedores
            Console.WriteLine("Vc escolheu: Listar todos os vendedores");
            ListarVendedores(vendedores);
            break;
        case 9:
            // Registra uma nova venda
            Console.WriteLine("Vc escolheu: Adicionar uma nova venda");
            RegistrarVenda(vendas, vendedores, livros);
            break;
        case 10:
            // Lista todas as vendas
            Console.WriteLine("Vc escolheu: Listar todas as vendas");
            ListarVendas(vendas);
            break;
        case 11:
            // Lista livros com preço acima de um valor específico
            Console.WriteLine("Vc escolheu: Listar livros com preço acima de um valor específico");
            ListarLivrosComPrecoAcimaDeValor(livros);
            break;
        case 12:
            // Lista livros por categoria
            Console.WriteLine("Vc escolheu: Listar livros por categoria");
            ListarLivrosPorCategoria(livros, categorias);
            break;
        case 13:
            // Lista vendas por vendedor
            Console.WriteLine("Vc escolheu: Listar livros por categoria");
            ListarVendasPorVendedor(vendas, vendedores);
            break;
        case 14:
            // Encerra o programa
            continuar = false;
            break;
        default:
            // Opção inválida
            Console.WriteLine("Opção inválida!");
            break;
    }
}

// Função que solicita ao usuário informações do livro que ele queira cadastrar e o-resgistra
static void AdicionarLivro(List<Livro> livros, List<Autor> autores, List<Categoria> categorias)
{
    // Solicita informações do livro
    Console.WriteLine("Título do livro:");
    string titulo = Console.ReadLine();

    // Lista autores disponíveis
    ListarAutores(autores);
    Console.WriteLine("ID do autor:");
    int autorId = Convert.ToInt32(Console.ReadLine());
    Autor autor = autores.Find(a => a.Id == autorId);
    if (autor == null)
    {
        Console.WriteLine("Autor não encontrado.");
        return;
    }

    // Lista categorias disponíveis
    ListarCategorias(categorias);
    Console.WriteLine("ID da categoria:");
    int categoriaId = Convert.ToInt32(Console.ReadLine());
    Categoria categoria = categorias.Find(c => c.Id == categoriaId);
    if (categoria == null)
    {
        Console.WriteLine("Categoria não encontrada.");
        return;
    }

    // Solicita preço do livro
    Console.WriteLine("Preço do livro:");
    double preco = Convert.ToDouble(Console.ReadLine());

    // Cria e adiciona o livro à lista
    Livro livro = new Livro(livros.Count + 1, titulo, autor, categoria, preco);
    livros.Add(livro);
    Console.WriteLine($"Livro '{titulo}' adicionado com sucesso!");
}

// Função que retorna no console todos os livros cadastrados no sistema
static void ListarLivros(List<Livro> livros)
{
    // Verifica se existem livros registrados
    if (livros.Count == 0)
    {
        Console.WriteLine("Não há livros registrados.");
        return;
    }

    // Lista todos os livros
    foreach (var livro in livros)
    {
        Console.WriteLine($"ID: {livro.Id}, Título: {livro.Titulo}, Autor: {livro.Autor.Nome}, Categoria: {livro.Categoria.Titulo}, Preço: {livro.Preco}");
    }
}

// Função que solicita ao usuário informações do autor que ele queira cadastrar e o-resgistra
static void AdicionarAutor(List<Autor> autores)
{
    // Solicita informações do autor
    Console.WriteLine("Nome do autor:");
    string nome = Console.ReadLine();

    Console.WriteLine("Idade do autor:");
    int idade = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Nacionalidade do autor:");
    string nacionalidade = Console.ReadLine();

    // Cria e adiciona o autor à lista
    Autor autor = new Autor(autores.Count + 1, nome, idade, nacionalidade);
    autores.Add(autor);
    Console.WriteLine($"Autor '{nome}' adicionado com sucesso!");
}

// Função que retorna no console todos os livros cadastrados no sistema
static void ListarAutores(List<Autor> autores)
{
    // Verifica se existem autores registrados
    if (autores.Count == 0)
    {
        Console.WriteLine("Não há autores registrados.");
        return;
    }

    // Lista todos os autores
    foreach (var autor in autores)
    {
        Console.WriteLine($"ID: {autor.Id}, Nome: {autor.Nome}, Idade: {autor.Idade}, Nacionalidade: {autor.Nacionalidade}");
    }
}

// Função que solicita ao usuário informações de uma categoria que ele queira cadastrar e a-resgistra
static void AdicionarCategoria(List<Categoria> categorias)
{
    // Solicita o nome da categoria
    Console.WriteLine("Nome da categoria:");
    string nome = Console.ReadLine();

    // Cria e adiciona a categoria à lista
    Categoria categoria = new Categoria(categorias.Count + 1, nome);
    categorias.Add(categoria);
    Console.WriteLine($"Categoria '{nome}' adicionada com sucesso!");
}

// Função que retorna no console todas as categorias cadastradas no sistema
static void ListarCategorias(List<Categoria> categorias)
{
    // Verifica se existem categorias registradas
    if (categorias.Count == 0)
    {
        Console.WriteLine("Não há categorias registradas.");
        return;
    }

    // Lista todas as categorias
    foreach (var categoria in categorias)
    {
        Console.WriteLine($"ID: {categoria.Id}, Nome: {categoria.Titulo}");
    }
}

// Função que solicita ao usuário informações do vendedor que ele queira cadastrar e o-resgistra
static void AdicionarVendedor(List<Vendedor> vendedores)
{
    // Solicita nome do vendedor
    Console.WriteLine("Nome do vendedor:");
    string nome = Console.ReadLine();

    // Solicita idade do vendedor
    Console.WriteLine("Idade do vendedor:");
    int idade = Convert.ToInt32(Console.ReadLine());

    // Solicita email do vendedor
    Console.WriteLine("Email do vendedor:");
    string email = Console.ReadLine();

    // Cria e adiciona o vendedor à lista
    Vendedor vendedor = new Vendedor(vendedores.Count + 1, nome, idade, email);
    vendedores.Add(vendedor);
    Console.WriteLine($"Vendedor '{nome}' adicionado com sucesso!");
}

// Função que retorna no console todos vendedores cadastrados no sistema
static void ListarVendedores(List<Vendedor> vendedores)
{
    // Verifica se existem vendedores registrados
    if (vendedores.Count == 0)
    {
        Console.WriteLine("Não há vendedores registrados.");
        return;
    }

    // Lista todos os vendedores
    foreach (var vendedor in vendedores)
    {
        Console.WriteLine($"ID: {vendedor.Id}, Nome: {vendedor.Nome}, Idade: {vendedor.Idade}, Email: {vendedor.Email}");
    }
}

// Função que solicita ao usuário informações da venda que ele queira registrar e cadastra a mesma no sistema
static void RegistrarVenda(List<Venda> vendas, List<Vendedor> vendedores, List<Livro> livros)
{
    // Lista vendedores disponíveis
    ListarVendedores(vendedores);
    Console.WriteLine("ID do vendedor:");
    int vendedorId = Convert.ToInt32(Console.ReadLine());
    Vendedor vendedor = vendedores.Find(v => v.Id == vendedorId);
    if (vendedor == null)
    {
        Console.WriteLine("Vendedor não encontrado.");
        return;
    }

    // Adiciona livros à venda
    List<Livro> livrosVendidos = AdicionarLivrosAVenda(livros);

    // Cria e registra a venda
    Venda venda = new Venda(vendas.Count + 1, livrosVendidos, vendedor);
    vendas.Add(venda);
    Console.WriteLine("Venda registrada com sucesso!");
}

// Função que retorna lista de livros escolhidos pelo usuários para cadastrar na venda
static List<Livro> AdicionarLivrosAVenda(List<Livro> livros)
{
    List<Livro> livrosVendidos = new List<Livro>();
    bool adicionarMaisLivros = true;
    do
    {
        // Lista livros disponíveis
        ListarLivros(livros);

        Console.WriteLine("ID do livro:");
        int livroId = Convert.ToInt32(Console.ReadLine());
        Livro livro = livros.Find(l => l.Id == livroId);
        if (livro == null)
        {
            Console.WriteLine("Livro não encontrado.");
            continue;
        }
        livrosVendidos.Add(livro);

        // Pergunta se deseja adicionar mais livros à venda
        Console.WriteLine("Deseja adicionar mais livros à venda? (S/N)");
        adicionarMaisLivros = Console.ReadLine().ToUpper() == "S";
    } while (adicionarMaisLivros);

    return livrosVendidos;
}

// Função que retorna no console todas as vendas registradas no sistema
static void ListarVendas(List<Venda> vendas)
{
    // Verifica se existem vendas registradas
    if (vendas.Count == 0)
    {
        Console.WriteLine("Não há vendas registradas.");
        return;
    }

    // Lista todas as vendas
    foreach (var venda in vendas)
    {
        Console.WriteLine($"ID: {venda.Id}, Vendedor: {venda.Vendedor.Nome}, Total: {venda.Total}");
        Console.WriteLine("Livros vendidos:");
        foreach (var livro in venda.Livros)
        {
            Console.WriteLine($"- Título: {livro.Titulo}, Autor: {livro.Autor.Nome}, Categoria: {livro.Categoria.Titulo}, Preço: {livro.Preco}");
        }
        Console.WriteLine();
    }
}

// Função que retorna no console todos os livros acima do preço que o usuário solicitou
static void ListarLivrosComPrecoAcimaDeValor(List<Livro> livros)
{
    // Solicita o preço mínimo
    Console.WriteLine("Preço mínimo:");
    double valorMinimo = Convert.ToDouble(Console.ReadLine());

    // Lista livros com preço acima do valor mínimo
    bool encontrouLivros = false;
    foreach (var livro in livros)
    {
        if (livro.Preco > valorMinimo)
        {
            Console.WriteLine($"ID: {livro.Id}, Título: {livro.Titulo}, Autor: {livro.Autor.Nome}, Categoria: {livro.Categoria.Titulo}, Preço: {livro.Preco}");
            encontrouLivros = true;
        }
    }

    // Exibe mensagem para caso não haja livro maior que o valor específicado
    if (!encontrouLivros)
    {
        Console.WriteLine("Nenhum livro encontrado com preço acima do valor especificado.");
    }
}

// Função que retorna no console todos os livros da categoria que o usuáro escolher
static void ListarLivrosPorCategoria(List<Livro> livros, List<Categoria> categorias)
{
    // Lista categorias disponíveis
    ListarCategorias(categorias);
    Console.WriteLine("Escolha o ID da categoria:");
    int categoriaId = Convert.ToInt32(Console.ReadLine());
    Categoria categoriaEscolhida = categorias.Find(c => c.Id == categoriaId);

    if (categoriaEscolhida == null)
    {
        Console.WriteLine("Categoria não encontrada.");
        return;
    }

    // Lista livros da categoria escolhida
    Console.WriteLine($"Lista de livros da categoria: {categoriaEscolhida.Titulo}");
    bool encontrouLivros = false;
    foreach (var livro in livros)
    {
        if (livro.Categoria.Id == categoriaId)
        {
            Console.WriteLine($"- Título: {livro.Titulo}, Autor: {livro.Autor.Nome}, Preço: {livro.Preco}");
            encontrouLivros = true;
        }
    }

    // Exibe mensagem para caso não haja livro para a categoria escolhida
    if (!encontrouLivros)
    {
        Console.WriteLine("Nenhum livro encontrado nesta categoria.");
    }
}

// Função que retorna no console todas as vendas registradas pelo vendedor escolhido pelo usuário
static void ListarVendasPorVendedor(List<Venda> vendas, List<Vendedor> vendedores)
{
    // Lista vendedores disponíveis
    ListarVendedores(vendedores);
    Console.WriteLine("Escolha o ID do vendedor:");
    int vendedorId = Convert.ToInt32(Console.ReadLine());
    Vendedor vendedorEscolhido = vendedores.Find(v => v.Id == vendedorId);

    if (vendedorEscolhido == null)
    {
        Console.WriteLine("Vendedor não encontrado.");
        return;
    }

    // Lista vendas do vendedor escolhido
    Console.WriteLine($"Lista de vendas do vendedor: {vendedorEscolhido.Nome}");
    bool encontrouVendas = false;
    foreach (var venda in vendas)
    {
        if (venda.Vendedor.Id == vendedorId)
        {
            Console.WriteLine($"ID da Venda: {venda.Id}, Total: {venda.Total}");
            Console.WriteLine("Livros vendidos:");
            foreach (var livro in venda.Livros)
            {
                Console.WriteLine($"- Título: {livro.Titulo}, Autor: {livro.Autor.Nome}, Categoria: {livro.Categoria.Titulo}, Preço: {livro.Preco}");
            }
            Console.WriteLine();
            encontrouVendas = true;
        }
    }

    // Exibe mensagem para caso não haja venda para o vendedor escolhido
    if (!encontrouVendas)
    {
        Console.WriteLine("Nenhuma venda encontrada para este vendedor.");
    }
}