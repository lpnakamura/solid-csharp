namespace SOLID_CSharp_ConsoleApplication.OCP_DIP
{
    public class TabelaDePrecoPadrao : ITabelaDePreco
    {
        public double DescontoPara(double valor)
        {
            if(valor>5000) 
                return 0.03;
            else if(valor>1000) 
                return 0.05;
            
            return 0;
        }
    }
}