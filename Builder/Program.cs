using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var criadorNF = new CriadorDeNotaFiscalBuilder();
            criadorNF
                .ParaEmpresa("Empresa")
                .ComCnpj("124.544.443-22")
                .ComDataEmissao(DateTime.Now)
                .ComObservacao("observação")
                .AdicionarItens(new List<ItemDaNota>() {
                    new ItemDaNota(){ Nome = "Item 1",Valor = 20.20},
                    new ItemDaNota(){ Nome = "Item 2",Valor = 200.00},
                    new ItemDaNota(){ Nome = "Item 3",Valor = 28.20}
                })
                .AdicionarItem(new ItemDaNota() { Nome = "item 4", Valor = 32.22 });

            var notaFiscal = criadorNF.Constroi();
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
