namespace SOLID_CSharp_ConsoleApplication.OCP_DIP
{
    public class FreteCidadeSaoPaulo : IServicoEntregaCidade
    {
        public double Frete()
        {
           return 10;
        }
    }
}