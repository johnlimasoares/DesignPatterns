using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class NotaFiscal
    {
          
        public string RazaoSocial { get; private set; }
        public string Cnpj { get; private set; }
        public DateTime DataDeEmissao { get; private set; }
        public double ValorBruto { get; private set; }
        public double Impostos { get; private set; }
        public IList<ItemDaNota> Itens { get; set; }
        private string observacao;

        public NotaFiscal(string razaoSocial, string cnpj, DateTime dataDeEmissao, string observacao, double valorBruto, double impostos, IList<ItemDaNota> itens)
        {
            this.RazaoSocial = razaoSocial;
            this.Cnpj = cnpj;
            this.DataDeEmissao = dataDeEmissao;
            this.observacao = observacao;
            this.ValorBruto = valorBruto;
            this.Impostos = impostos;
            this.Itens = itens;
        }

    }
}
