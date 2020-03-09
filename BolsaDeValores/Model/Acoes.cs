using System;
using System.Collections.Generic;
using System.Text;

namespace BolsaDeValores.Model
{
    public class Acoes
    {
   
        public int id { get;  set; }
        public string qtd { get; set; }

        private List<int> acoes;
        private object acao;

        public Acoes(int codigo, string qtd)
        {
            this.id = codigo;
            this.qtd = qtd;
        }

        public Acoes(object acao)
        {
            this.acao = acao;
        }

        public override string ToString()
        {
            return $"Código: {this.id} Quantidade: {this.qtd} ";
        }




    }
}
