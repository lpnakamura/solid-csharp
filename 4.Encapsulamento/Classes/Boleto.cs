namespace SOLID_CSharp_ConsoleApplication.Encapsulamento
{
    public class Boleto
    {
        public double Valor { get; private set; }
        public Boleto(double valor)
        {
            this.Valor = valor;
        }
    }
}