namespace SOLID_CSharp_ConsoleApplication
{
    public class CinquentaPorcento : IRegraCalculo
    {
        public double Calcula(Funcionario funcionario)
        {
          return funcionario.SalarioBase * 0.5;
        }
    }
}