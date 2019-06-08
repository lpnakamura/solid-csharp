using System;

namespace SOLID_CSharp_ConsoleApplication.Heranca_LSP
{
    class ContaEstudante : ContaComum
    {
        private ManipuladorDeSaldo Manipulador;
        public int Milhas {get;private set;}

        public ContaEstudante()
        {
            this.Manipulador = new ManipuladorDeSaldo();
        }

        public override void Deposita(double valor)  
        {
            this.Manipulador.Deposita(valor);
            this.Milhas += (int)valor;
        }
    }
}