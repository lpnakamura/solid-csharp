namespace SOLID_CSharp_ConsoleApplication.Cargos
{
public abstract class Cargo
    {
        public IRegraCalculo Regra { get; private set; }

        public Cargo(IRegraCalculo regra)
        {
            this.Regra = regra;
        }
    }
}