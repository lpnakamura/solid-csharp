using System;

namespace SOLID_CSharp_ConsoleApplication.Acoplamento_Estabilidade
{
    public class EnviadorDeEmail : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine("Enviando email");
        }
    }
}