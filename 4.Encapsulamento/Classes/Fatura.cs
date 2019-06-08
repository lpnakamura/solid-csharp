using System;
using System.Collections.Generic;
using System.Linq;

namespace SOLID_CSharp_ConsoleApplication.Encapsulamento
{
    public class Fatura
    {
        public string Cliente { get; private set; }
        public double Valor { get; set; }
        private IList<Pagamento> Pagamentos;
        public bool Pago { 
            get 
            {
                var valorTotalPagamentos = this.Pagamentos.Sum(p => p.Valor);

                if(valorTotalPagamentos >= this.Valor)
                    return true;

                return false;
            }  
        }

        public Fatura(string cliente,double valor)
        {
            this.Cliente = cliente;
            this.Valor = valor;
            this.Pagamentos = new List<Pagamento>();
        }

        public void AdicionarPagamento(Pagamento pagamento)
        {
            this.Pagamentos.Add(pagamento);
        }
    }
}