using ClassLibraryCP01.Models;

var autores = new List<Autor>();
var categorias = new List<Categoria>();
var livros = new List<Livro>();
var vendedores = new List<Vendedor>();
var vendas = new List<Venda>();


Autor arthur = new Autor(1, "Arthur", 20, "Brasileiro");
Autor alicia = new Autor(2, "Alícia", 23, "Brasileiro");
autores.Add(arthur);
autores.Add(alicia);

Categoria romance = new Categoria(1, "Romance");
Categoria aventura = new Categoria(2, "Aventura");
categorias.Add(romance);
categorias.Add(aventura);

Livro harryPotter = new Livro(1, "Harry Potter", arthur, aventura, 100.0);
Livro romeuEJulieta = new Livro(2, "Romeu e Julieta", alicia, romance, 150.0);
livros.Add(harryPotter);
livros.Add(romeuEJulieta);

Vendedor anaCarolina = new Vendedor(1, "Ana Carolina", 26, "ana.carol@gmail.com");
Vendedor larah = new Vendedor(2, "Larah", 27, "larah@gmail.com");
vendedores.Add(anaCarolina);
vendedores.Add(larah);

bool continuar = true;

while (continuar)
{
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

    int opcao = Convert.ToInt32(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Vc escolheu: Adicionar um novo livro");
            AdicionarLivro(livros, autores, categorias);
            break;
        case 2:
            Console.WriteLine("Vc escolheu: Listar todos os livros");
            ListarLivros(livros);
            break;
        case 3:
            Console.WriteLine("Vc escolheu: Adicionar um novo autor");
            AdicionarAutor(autores);
            break;
        case 4:
            Console.WriteLine("Vc escolheu: Listar todos os autores");
            ListarAutores(autores);
            break;
        case 5:
            Console.WriteLine("Vc escolheu: Adicionar uma nova categoria");
            AdicionarCategoria(categorias);
            break;
        case 6:
            Console.WriteLine("Vc escolheu: Listar todas as categorias");
            ListarCategorias(categorias);
            break;
        case 7:
            Console.WriteLine("Vc escolheu: Adicionar um novo vendedor");
            AdicionarVendedor(vendedores);
            break;
        case 8:
            Console.WriteLine("Vc escolheu: Listar todos os vendedores");
            ListarVendedores(vendedores);
            break;
        case 9:
            Console.WriteLine("Vc escolheu: Adicionar uma nova venda");
            RegistrarVenda(vendas, vendedores, livros);
            break;
        case 10:
            Console.WriteLine("Vc escolheu: Listar todas as vendas");
            ListarVendas(vendas);
            break;
        case 11:
            Console.WriteLine("Vc escolheu: Listar livros com preço acima de um valor específico");
            ListarLivrosComPrecoAcimaDe(livros);
            break;
        case 12:
            Console.WriteLine("Vc escolheu: Listar livros por categoria");
            ListarLivrosPorCategoria(livros, categorias);
            break;
        case 13:
            Console.WriteLine("Vc escolheu: Listar livros por categoria");
            ListarVendasPorVendedor(vendas, vendedores);
            break;
        case 14:
            continuar = false;
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}

static void AdicionarLivro(List<Livro> livros, List<Autor> autores, List<Categoria> categorias)
{
    Console.WriteLine("Título do livro:");
    string titulo = Console.ReadLine();

    ListarAutores(autores);

    Console.WriteLine("ID do autor:");
    int autorId = Convert.ToInt32(Console.ReadLine());
    Autor autor = autores.Find(a => a.Id == autorId);
    if (autor == null)
    {
        Console.WriteLine("Autor não encontrado.");
        return;
    }

    ListarCategorias(categorias);

    Console.WriteLine("ID da categoria:");
    int categoriaId = Convert.ToInt32(Console.ReadLine());
    Categoria categoria = categorias.Find(c => c.Id == categoriaId);
    if (categoria == null)
    {
        Console.WriteLine("Categoria não encontrada.");
        return;
    }

    Console.WriteLine("Preço do livro:");
    double preco = Convert.ToDouble(Console.ReadLine());

    Livro livro = new Livro(livros.Count + 1, titulo, autor, categoria, preco);
    livros.Add(livro);
    Console.WriteLine($"Livro '{titulo}' adicionado com sucesso!");
}

static void ListarLivros(List<Livro> livros)
{
    if (livros.Count == 0)
    {
        Console.WriteLine("Não há livros registrados.");
        return;
    }
    else
    {
        foreach (var livro in livros)
        {
            Console.WriteLine($"ID: {livro.Id}, Título: {livro.Titulo}, Autor: {livro.Autor.Nome}, Categoria: {livro.Categoria.Titulo}, Preço: {livro.Preco}");
        }
    }
}

static void AdicionarAutor(List<Autor> autores)
{
    Console.WriteLine("Nome do autor:");
    string nome = Console.ReadLine();

    Console.WriteLine("Idade do categoria:");
    int idade = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Nacionalidade do autor:");
    string nacionalidade = Console.ReadLine();

    Autor autor = new Autor(autores.Count + 1, nome, idade, nacionalidade);
    autores.Add(autor);
    Console.WriteLine($"Autor '{nome}' adicionado com sucesso!");
}

static void ListarAutores(List<Autor> autores)
{
    if (autores.Count == 0)
    {
        Console.WriteLine("Não há autores registrados.");
        return;
    }
    else
    {
        foreach (var autor in autores)
        {
            Console.WriteLine($"ID: {autor.Id}, Nome: {autor.Nome}, Idade: {autor.Idade}, Nacionalidade: {autor.Nacionalidade}");
        }
    }
}

static void AdicionarCategoria(List<Categoria> categorias)
{
    Console.WriteLine("Nome da categoria:");
    string nome = Console.ReadLine();

    Categoria categoria = new Categoria(categorias.Count + 1, nome);
    categorias.Add(categoria);
    Console.WriteLine($"Categoria '{nome}' adicionada com sucesso!");
}

static void ListarCategorias(List<Categoria> categorias)
{
    if (categorias.Count == 0)
    {
        Console.WriteLine("Não há categorias registradas.");
        return;
    }
    else
    {
        foreach (var categoria in categorias)
        {
            Console.WriteLine($"ID: {categoria.Id}, Nome: {categoria.Titulo}");
        }
    }
}

static void AdicionarVendedor(List<Vendedor> vendedores)
{
    Console.WriteLine("Nome do vendedor:");
    string nome = Console.ReadLine();

    Console.WriteLine("Idade do categoria:");
    int idade = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Email do vendedor:");
    string email = Console.ReadLine();

    Vendedor vendedor = new Vendedor(vendedores.Count + 1, nome, idade, email);
    vendedores.Add(vendedor);
    Console.WriteLine($"Vendedor '{nome}' adicionado com sucesso!");
}

static void ListarVendedores(List<Vendedor> vendedores)
{
    if (vendedores.Count == 0)
    {
        Console.WriteLine("Não há vendedores registrados.");
        return;
    }
    else
    {
        foreach (var vendedor in vendedores)
        {
            Console.WriteLine($"ID: {vendedor.Id}, Nome: {vendedor.Nome}, Idade: {vendedor.Idade}, Email: {vendedor.Email}");
        }
    }
}

static void RegistrarVenda(List<Venda> vendas, List<Vendedor> vendedores, List<Livro> livros)
{
    ListarVendedores(vendedores);

    Console.WriteLine("ID do vendedor:");
    int vendedorId = Convert.ToInt32(Console.ReadLine());
    Vendedor vendedor = vendedores.Find(v => v.Id == vendedorId);
    if (vendedor == null)
    {
        Console.WriteLine("Vendedor não encontrado.");
        return;
    }

    List<Livro> livrosVendidos = AdicionarLivrosAVenda(livros);

    double total = CalcularTotalVenda(livrosVendidos);

    Venda venda = new Venda(vendas.Count + 1, livrosVendidos, vendedor, total);
    vendas.Add(venda);
    Console.WriteLine("Venda registrada com sucesso!");
}

static List<Livro> AdicionarLivrosAVenda(List<Livro> livros)
{
    List<Livro> livrosVendidos = new List<Livro>();
    bool adicionarMaisLivros = true;
    do
    {
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

        Console.WriteLine("Deseja adicionar mais livros à venda? (S/N)");
        adicionarMaisLivros = Console.ReadLine().ToUpper() == "S";
    } while (adicionarMaisLivros);

    return livrosVendidos;
}

static void ListarVendas(List<Venda> vendas)
{
    if (vendas.Count == 0)
    {
        Console.WriteLine("Não há vendas registradas.");
    }

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

static void ListarLivrosComPrecoAcimaDe(List<Livro> livros)
{
    Console.WriteLine("Preço mínimo:");
    double valorMinimo = Convert.ToDouble(Console.ReadLine());

    bool encontrouLivros = false;
    foreach (var livro in livros)
    {
        if (livro.Preco > valorMinimo)
        {
            Console.WriteLine($"ID: {livro.Id}, Título: {livro.Titulo}, Autor: {livro.Autor.Nome}, Categoria: {livro.Categoria.Titulo}, Preço: {livro.Preco}");
            encontrouLivros = true;
        }
    }

    if (!encontrouLivros)
    {
        Console.WriteLine("Nenhum livro encontrado com preço acima do valor especificado.");
    }
}

static void ListarLivrosPorCategoria(List<Livro> livros, List<Categoria> categorias)
{
    ListarCategorias(categorias);

    Console.WriteLine("Escolha o ID da categoria:");
    int categoriaId = Convert.ToInt32(Console.ReadLine());
    Categoria categoriaEscolhida = categorias.Find(c => c.Id == categoriaId);

    if (categoriaEscolhida == null)
    {
        Console.WriteLine("Categoria não encontrada.");
        return;
    }

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

    if (!encontrouLivros)
    {
        Console.WriteLine("Nenhum livro encontrado nesta categoria.");
    }
}

static void ListarVendasPorVendedor(List<Venda> vendas, List<Vendedor> vendedores)
{
    ListarVendedores(vendedores);

    Console.WriteLine("Escolha o ID do vendedor:");
    int vendedorId = Convert.ToInt32(Console.ReadLine());
    Vendedor vendedorEscolhido = vendedores.Find(v => v.Id == vendedorId);

    if (vendedorEscolhido == null)
    {
        Console.WriteLine("Vendedor não encontrado.");
        return;
    }

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

    if (!encontrouVendas)
    {
        Console.WriteLine("Nenhuma venda encontrada para este vendedor.");
    }
}


static double CalcularTotalVenda(List<Livro> livros)
{
    double total = 0;
    foreach (var item in livros)
    {
        total += item.Preco;
    }
    return total;
}