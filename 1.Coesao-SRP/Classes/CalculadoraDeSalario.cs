namespace SOLID_CSharp_ConsoleApplication
{
    public class CalculadoraDeSalario
    {
        private readonly Funcionario funcionario;

        public CalculadoraDeSalario(Funcionario funcionario)
        {
            this.funcionario = funcionario;
        }

        public double Calcula()
        {
            return this.funcionario.Cargo.Regra.Calcula(funcionario);
        }
    }
}