using SOLID_CSharp_ConsoleApplication.Cargos;

namespace SOLID_CSharp_ConsoleApplication
{
    public class Funcionario
    {
        public Cargo Cargo { get; private set; }        
        public double SalarioBase { get; private set; }

        public Funcionario(Cargo cargo, double salarioBase)
        {
            this.Cargo = cargo;
            this.SalarioBase = salarioBase;
        }
    }
}