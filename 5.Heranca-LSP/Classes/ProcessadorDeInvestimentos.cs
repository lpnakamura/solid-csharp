using System;
using System.Collections.Generic;

namespace SOLID_CSharp_ConsoleApplication.Heranca_LSP
{
    public class ProcessadorDeInvestimentos
    {
        public void Processa(IList<ContaComum> contas)
        {
            foreach(ContaComum conta in contas)
            {
                conta.SomaInvestimento();
                Console.WriteLine("Novo saldo: " + conta.Saldo);
            }
        }

    }
}