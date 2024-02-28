// See https://aka.ms/new-console-template for more information
using ClassLibraryCP01.Models;

Console.WriteLine("Hello, World!");


Autor autor = new Autor(1, "Arthur Foschiani", 20, "Brasileiro");
Categoria categoria = new Categoria(1, "Aventura");
Livro livro = new Livro(1, "Harry Potter", autor, categoria, 59.99);
Livro livro2 = new Livro(2, "Harry Potter 2", autor, categoria, 55.99);
Vendedor vendedor = new Vendedor(1, "Alicia Guiradelo", 23, 5);
Venda venda = new Venda(1, new Livro[] {livro, livro2}, vendedor, 100);


Console.WriteLine(venda.calcularTotal());


Console.WriteLine("Seja bem vindo ao nosso sistema de livraria. Escolha uma das opções seguintes opções:");

var executa = true;

while (executa)
{
    Console.WriteLine();
    Console.WriteLine("Digite 1 para: Visualizar livros e seus respectivos autores");
    Console.WriteLine("Digite 2 para: Mostrar todos os livros daquela categoria");
    Console.WriteLine("Digite 3 para: Digitar dois números para retornar a multiplicação entre os dois");
    Console.WriteLine("Digite 4 para: Digitar dois números para retornar a divisão entre os dois");
    Console.WriteLine("Digite 5 para: Gerar nota fiscal");
    Console.WriteLine("Digite 6 para: Sair do programa");
    Console.WriteLine();

    //Capturamos a opção desejada
    var opcaoEscolhida = Console.ReadLine();

    switch (opcaoEscolhida)
    {
        case "1":
            Console.WriteLine("Digite o primeiro Número: ");
            double primeiroNumeroSoma = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo Número: ");
            double segundoNumeroSoma = double.Parse(Console.ReadLine());

            var resultadoSoma = primeiroNumeroSoma + segundoNumeroSoma;

            var mensagemSoma = $"A soma dos números {primeiroNumeroSoma} e {segundoNumeroSoma} é: {resultadoSoma}";
            Console.WriteLine(mensagemSoma);

            listaOperacao.Add($"Função Executada em {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}: {mensagemSoma}");

            break;
        case "2":
            Console.WriteLine("Digite o primeiro Número: ");
            double primeiroNumeroSubtracao = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo Número: ");
            double segundoNumeroSubtracao = double.Parse(Console.ReadLine());

            var resultadoContaSubtracao = primeiroNumeroSubtracao - segundoNumeroSubtracao;

            var mensagemSubtracao = $"A Subtração dos números {primeiroNumeroSubtracao} e {segundoNumeroSubtracao} é: {resultadoContaSubtracao}";
            Console.WriteLine(mensagemSubtracao);

            listaOperacao.Add($"Função Executada em {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}: {mensagemSubtracao}");

            break;
        case "3":
            Console.WriteLine("Digite o primeiro Número: ");
            double primeiroNumeroMultiplicacao = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo Número: ");
            double segundoNumeroMultiplicacao = double.Parse(Console.ReadLine());

            var resultadoContaMultiplicacao = primeiroNumeroMultiplicacao * segundoNumeroMultiplicacao;

            var mensagemMultiplicacao = $"A multiplicação dos números {primeiroNumeroMultiplicacao} e {segundoNumeroMultiplicacao} é: {resultadoContaMultiplicacao}";
            Console.WriteLine(mensagemMultiplicacao);

            listaOperacao.Add($"Função Executada em {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}: {mensagemMultiplicacao}");

            break;
        case "4":
            Console.WriteLine("Digite o primeiro Número: ");
            double primeiroNumeroDivisao = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo Número: ");
            double segundoNumeroDivisao = double.Parse(Console.ReadLine());

            var resultadoContaDivisao = primeiroNumeroDivisao / segundoNumeroDivisao;

            var mensagemDivisao = $"A divisão dos números {primeiroNumeroDivisao} e {segundoNumeroDivisao} é: {resultadoContaDivisao}";
            Console.WriteLine(mensagemDivisao);

            listaOperacao.Add($"Função Executada em {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}: {mensagemDivisao}");

            break;
        case "5":
            Console.WriteLine();
            Console.WriteLine("Operações realizadas pela aplicação:");
            Console.WriteLine();

            foreach (var operacao in listaOperacao)
            {
                Console.WriteLine(operacao);
            }

            break;
        default:
            controleExecucao = false;
            break;
    }
}

Console.WriteLine("Obrigado por utilizar o nosso programa!");