namespace SOLID_CSharp_ConsoleApplication.OCP_DIP
{
    public class CalculadoraDePrecos
    {
        private readonly ITabelaDePreco tabela;
        private readonly IServicoEntrega entrega;
        public CalculadoraDePrecos(ITabelaDePreco tabela, IServicoEntrega entrega)
        {
            this.entrega = entrega;
            this.tabela = tabela;
        }

        public double Calcula(Compra produto)
        {
            double desconto = tabela.DescontoPara(produto.Valor);
            double frete = entrega.Para(produto.Cidade);

            return produto.Valor * (1 - desconto) + frete;
        }


    }
}