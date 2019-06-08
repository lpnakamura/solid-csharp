using System;

namespace SOLID_CSharp_ConsoleApplication.Heranca_LSP
{
    public class ContaComum
    {
        private ManipuladorDeSaldo Manipulador;
        public double Saldo { 
            get {
                return this.Manipulador.Saldo;
            } 
        }

        public ContaComum()
        {
            this.Manipulador = new ManipuladorDeSaldo();
        }

        public void SomaInvestimento()
        {
            this.Manipulador.SomaInvestimento(1.1);
        }
        public void Saca(double valor)  {
            this.Manipulador.Saca(valor);
        }

        public virtual void Deposita(double valor)  {
            this.Manipulador.Deposita(valor);
        }

    }
}