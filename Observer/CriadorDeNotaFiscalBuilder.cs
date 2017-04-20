using System;
using System.Collections.Generic;

namespace Observer
{
    public class CriadorDeNotaFiscalBuilder
    {
        public string RazaoSocial { get; private set; }
        public string Cnpj { get; private set; }
        public DateTime DataDeEmissao { get; private set; } = DateTime.Now;
        public double ValorBruto { get; private set; }
        public double Impostos { get; private set; }
        public IList<ItemDaNota> Itens = new List<ItemDaNota>();
        public string Observacao { get; private set; }
        private IList<IAcaoAposGerarNota> todasAcoesAExecutar = new List<IAcaoAposGerarNota>();


        public NotaFiscal Constroi()
        {
            return new NotaFiscal(RazaoSocial, Cnpj, DataDeEmissao, Observacao, ValorBruto, Impostos, Itens);

        }

        public void ExecutarAcoes(NotaFiscal nf)
        {

            foreach (var acao in todasAcoesAExecutar)
            {
                acao.Executa(nf);
            }

        }

        public void AdicionarAcao(IAcaoAposGerarNota novaAcao)
        {
            todasAcoesAExecutar.Add(novaAcao);
        }


        public CriadorDeNotaFiscalBuilder ParaEmpresa(string razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
            return this;
        }

        public CriadorDeNotaFiscalBuilder ComCnpj(string cnpj)
        {
            this.Cnpj = cnpj;
            return this;
        }

        public CriadorDeNotaFiscalBuilder NaData(DateTime dataEmissao)
        {
            this.DataDeEmissao = dataEmissao;
            return this;
        }

        public CriadorDeNotaFiscalBuilder ComObservacao(string observacao)
        {
            this.Observacao = observacao;
            return this;
        }

        public CriadorDeNotaFiscalBuilder Com(List<ItemDaNota> itens)
        {
            foreach (var item in itens)
            {
                this.Itens.Add(item);
                this.ValorBruto += item.Valor;
                this.Impostos += item.Valor * 0.05;
            }
            return this;
        }

        public CriadorDeNotaFiscalBuilder Com(ItemDaNota item)
        {
            this.Itens.Add(item);
            this.ValorBruto += item.Valor;
            this.Impostos += item.Valor * 0.05;
            return this;
        }


    }
}