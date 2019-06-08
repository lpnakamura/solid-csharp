namespace SOLID_CSharp_ConsoleApplication.Encapsulamento
{
    public class Pagamento
    {
        public double Valor { get; private set; }
        public MeioDePagamento Forma { get; private set; }

        public Pagamento(double valor, MeioDePagamento forma)
        {
            this.Valor = valor;
            this.Forma = forma;
        }
    }
}