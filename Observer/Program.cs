using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var criadorNFBuilder = new CriadorDeNotaFiscalBuilder();
            criadorNFBuilder
                .ParaEmpresa("Empresa")
                .ComCnpj("124.544.443-22")
                .NaData(DateTime.Now)
                .ComObservacao("observação")
                .Com(new List<ItemDaNota>() {
                     new ItemDaNota(){ Nome = "Item 1",Valor = 20.20},
                     new ItemDaNota(){ Nome = "Item 2",Valor = 200.00},
                     new ItemDaNota(){ Nome = "Item 3",Valor = 28.20}})
                .Com(new ItemDaNota() { Nome = "item 4", Valor = 32.22 });

            var notaFiscal = criadorNFBuilder.Constroi();

            criadorNFBuilder.AdicionarAcao(new EnviadorDeEmail());
            criadorNFBuilder.AdicionarAcao(new EnviadorDeSMS());
            criadorNFBuilder.ExecutarAcoes(notaFiscal);

            Console.WriteLine(
                $"NF Empresa : {notaFiscal.RazaoSocial}\n" +
                $"NF Cnpj : {notaFiscal.Cnpj}\n" +
                $"NF Valor : {notaFiscal.ValorBruto}\n" +
                $"NF Impostos : {notaFiscal.Impostos}"
                );
            Console.ReadKey();
        }
    }
}
