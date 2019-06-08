using System;

namespace SOLID_CSharp_ConsoleApplication.Acoplamento_Estabilidade
{
    public class NotaFiscalDao : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal notaFiscal)
        {
             Console.WriteLine("Persistindo nota");
        }
    }
}