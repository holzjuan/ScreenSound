namespace ScreenSound01
{
    internal class Program
    {
        //static List<string> bandas = new List<string> {"U2", "Linkin Park", "Iron Maden"};
        static Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
        static bool menu = true;

        static void Main(string[] args)
        {
            while (menu)
            {
                ExibirOpcoesDoMenu();
            }
        }

        static void ExibirMensagensDeBoasVindas()
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

        static void ExibirOpcoesDoMenu()
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

            switch(opcao)
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
                    Console.WriteLine("Voce digitou a opção 4");
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

        static void RegistrarBandas()
        {
            Console.Clear();
            TituloFuncao("Registro de bandas");
            
            Console.Write("Digite o nome da banda: ");
            string nomeDaBanda = Console.ReadLine()!;
            bandasRegistradas.Add(nomeDaBanda, new List<int>());
            Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso.");
            
            Thread.Sleep(1000);
            ExibirOpcoesDoMenu();
        }

        static void ExibirBandasRegistradas()
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

        static void AvaliarUmaBanda()
        {
            Console.Clear();
            TituloFuncao("Avaliar banda");

            Console.Write("Digite o nome da banda que deseja avaliar: ");
            string nome = Console.ReadLine()!;

            if(bandasRegistradas.ContainsKey(nome))
            {
                Console.Write("Digite a nota da banda: ");
                int nota = int.Parse(Console.ReadLine()!);

                bandasRegistradas[nome].Add(nota);
                Console.WriteLine($"A nota {nota} foi registrada com sucesso.");

                Thread.Sleep(1000);
                Console.Clear();
            } else
            {
                Console.WriteLine($"Banda {nome} não encontrada.");
                Console.Write("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
                ExibirOpcoesDoMenu();
            }
        }

        static void ExibirMediaDaBanda()
        {

        }

        static void TituloFuncao(string titulo)
        {
            Console.WriteLine("**********************");
            Console.WriteLine($"* {titulo} *");
            Console.WriteLine("**********************\n");
        }

    }
}
