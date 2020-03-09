using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BolsaDeValores.Model
{
    class Carteira
    {
        
        private List<Acoes> acoes = new List<Acoes>();

        public Carteira()
        {
            acoes = new List<Acoes>();
        }

        public void AdicionarAcao(Acoes acao)
        {
            Console.WriteLine("Adicionar ação");
            Console.WriteLine("Digite o id de uma ação: ");
            int id = int.Parse((Console.ReadLine());

            Console.WriteLine("Digite quantas ações deseja: ");
            string qtd = Console.ReadLine();

            acoes.Add(new Acoes(id, qtd));


        }

        public void VisualizarAcao()
        {
            Console.WriteLine("Ações");
            for(int i = 0; i < acoes.Count; i++)
            {
                Console.WriteLine("Id da ação: " + acoes[i].id + " ");
                Console.WriteLine("Quantidade de ações: " + acoes[i].qtd + " ");
            }
        }
        public void PesquisarAcoesAdicionadas()
        {
            Console.WriteLine("Digite o id da ação");
            int codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Id encontrada: ");

            for(int i = 0; i < acoes.Count; i++)
            {
                if (acoes[i].id == codigo)
                {
                    Console.WriteLine("Id da ação:" + acoes[i].id + " ");
                    Console.WriteLine("Quantidade de ações: " + acoes[i].qtd + " ");
                }
            }
        }

       

    }
}
