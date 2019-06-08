namespace SOLID_CSharp_ConsoleApplication.OCP_DIP
{
    public class Frete : IServicoEntrega
    {
        public double Para(IServicoEntregaCidade cidade)
        {
            return cidade.Frete();
        }
    }
}