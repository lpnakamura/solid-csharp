using System.Collections.Generic;

namespace SOLID_CSharp_ConsoleApplication.Encapsulamento
{
    public class ProcessadorDeBoletos {
        public void Processa(IList<Boleto> boletos, Fatura fatura) {
            foreach(Boleto boleto in boletos) {
                Pagamento pagamento = new Pagamento(boleto.Valor, MeioDePagamento.BOLETO);
                fatura.AdicionarPagamento(pagamento);                    
            }
        }
    }
}