namespace SOLID_CSharp_ConsoleApplication
{
    public class QuinzeOuVinteCincoPorcento : IRegraCalculo
    {
        public double Calcula(Funcionario funcionario)
        {
            if (funcionario.SalarioBase > 2000.0)
            {
                return funcionario.SalarioBase * 0.75;
            }
            else
            {
                return funcionario.SalarioBase * 0.85;
            }
        }
    }
}