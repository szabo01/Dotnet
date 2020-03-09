using BolsaDeValores.Model;
using System;
using System.Collections.Generic;

namespace BolsaDeValores
{
    class Program
    {
        static void Main(string[] args)
        {

            do
            {
                ExibirMenu();

                try
                {
                    int opcao = int.Parse(Console.ReadLine());
                    if (opcao == 0) break;

                    ExecutarAcao(opcao);
                    Console.WriteLine("Digite alguma coisa ...");
                    Console.ReadLine();
                }
                catch (FormatException)
                {
                    Console.WriteLine("==================================");
                    Console.WriteLine("Opção inválida, por favor digite uma válida");
                }
            } while (true);
        }

        private static void ExecutarAcao(int opcao)
        {
          
            Console.Clear();
            switch (opcao)
            {
                case 1:
                    {

                        Carteira valor = new Carteira();
                        valor.AdicionarAcao(new Acoes("MOV1"));
                    }
                    break;
                case 2:
                    {
                        Carteira valor = new Carteira();
                        valor.PesquisarAcoesAdicionadas();
                    }
                    break;
                
                case 3:
                    {
                        Carteira valor = new Carteira();
                        valor.VisualizarAcao();
                    }
                    break;

                default:
                    break;

            }
        }

        private static void PesquisarPorAcao(int acao)
        {
            Console.WriteLine("Pesquisar por ações");
            Console.WriteLine("Digite o nome da ação: ");
            string ação = Console.ReadLine();


        }


        private static void ExibirMenu()
        {

            Console.Clear();
            Console.WriteLine("******* Bolsa de valores *******");
            Console.Write("");

            Console.WriteLine("1 - Cadastro de ação");
            Console.WriteLine("2 - Pesquisar por ação");
            Console.WriteLine("3 - Visualizar todas as carteiras de ações");
            
            Console.WriteLine("0 - Sair");

            Console.Write("Digite uma opção: ");

        }
    }
}
