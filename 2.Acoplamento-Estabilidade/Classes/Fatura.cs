namespace SOLID_CSharp_ConsoleApplication.Acoplamento_Estabilidade
{
    public class Fatura
    {        
        public double ValorMensal { get; set; }
        public string Cliente { get; private set; }

        public Fatura(double valorMensal,string cliente)
        {
            this.ValorMensal = valorMensal;
            this.Cliente = cliente;
        }
        
    }
}