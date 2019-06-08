namespace SOLID_CSharp_ConsoleApplication.OCP_DIP
{
    public class Compra
    {
        public IServicoEntregaCidade Cidade { get; set; }
        public double Valor { get; set; }
    }
}