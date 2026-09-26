//static List<string> bandas = new List<string> {"U2", "Linkin Park", "Iron Maden"};
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 8, 7, 10 });
bool menu = true;

void ExibirMensagensDeBoasVindas()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine("Boas vindas ao Screen Sound");
}

void ExibirOpcoesDoMenu()
{
    ExibirMensagensDeBoasVindas();
    Console.WriteLine("\n");
    Console.WriteLine("Digite 1 para registrar uma banda.");
    Console.WriteLine("Digite 2 para mostrar todas as bandas.");
    Console.WriteLine("Digite 3 para avaliar uma banda.");
    Console.WriteLine("Digite 4 para exibir a média de uma banda.");
    Console.WriteLine("Digite -1 para sair.");

    Console.Write("\nDigite a sua opção: ");
    int opcao = int.Parse(Console.ReadLine()!);

    switch (opcao)
    {
        case 1:
            RegistrarBandas();
            break;
        case 2:
            ExibirBandasRegistradas();
            break;
        case 3:
            AvaliarUmaBanda();
            break;
        case 4:
            ExibirMediaDaBanda();
            break;
        case -1:
            menu = false;
            Console.WriteLine("Encerrando...");
            break;
        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }
}

void RegistrarBandas()
{
    Console.Clear();
    TituloFuncao("Registro de bandas");

    Console.Write("Digite o nome da banda: ");
    string nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso.");

    Thread.Sleep(500);
    ExibirOpcoesDoMenu();
}

void ExibirBandasRegistradas()
{
    TituloFuncao("Bandas registradas");

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.Write("\nDigite uma tecla para voltar ao menu principal: ");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();

}

void AvaliarUmaBanda()
{
    Console.Clear();
    TituloFuncao("Avaliar banda");

    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nome = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nome))
    {
        Console.Write("Digite a nota da banda: ");
        int nota = int.Parse(Console.ReadLine()!);

        bandasRegistradas[nome].Add(nota);
        Console.WriteLine($"A nota {nota} foi registrada com sucesso.");

        Thread.Sleep(1000);
        Console.Clear();
    }
    else
    {
        Console.WriteLine($"Banda {nome} não encontrada.");
        Console.Write("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void ExibirMediaDaBanda()
{
    Console.Clear();
    TituloFuncao("Media da banda");

    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nome = Console.ReadLine()!;


    if (bandasRegistradas.ContainsKey(nome))
    {
        List<int> notasDaBanda = bandasRegistradas[nome];
        Console.WriteLine($"\nA média da banda {nome} é {notasDaBanda.Average()}.");

        Console.Write("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"Banda {nome} não encontrada.");
        Console.Write("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void TituloFuncao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');

    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

while (menu)
{
    ExibirOpcoesDoMenu();
}