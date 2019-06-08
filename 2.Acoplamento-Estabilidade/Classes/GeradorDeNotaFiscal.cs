using System.Collections.Generic;

namespace SOLID_CSharp_ConsoleApplication.Acoplamento_Estabilidade
{
    public class GeradorDeNotaFiscal
    {
        private readonly IList<IAcaoAposGerarNota> _acoes;
         public GeradorDeNotaFiscal(IList<IAcaoAposGerarNota> acoes) {
            this._acoes = acoes;
         }

        public NotaFiscal Gera(Fatura fatura) {

            double valor = fatura.ValorMensal;
            NotaFiscal nf = new NotaFiscal(valor, ImpostoSimplesSobreO(valor));

            foreach(var acao in _acoes){
                acao.Executa(nf);
            }

            return nf;
        }

        private double ImpostoSimplesSobreO(double valor) {
            return valor * 0.06;
        }    
    }
}