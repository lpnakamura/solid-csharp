using System;
using System.Collections.Generic;
using SOLID_CSharp_ConsoleApplication.Acoplamento_Estabilidade;
using SOLID_CSharp_ConsoleApplication.Cargos;
using SOLID_CSharp_ConsoleApplication.Encapsulamento;
using SOLID_CSharp_ConsoleApplication.Heranca_LSP;
using SOLID_CSharp_ConsoleApplication.OCP_DIP;

namespace SOLID_CSharp_ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Coesao-SRP");

            var cargo = new Desenvolvedor(new CinquentaPorcento());
            var funcionario = new Funcionario(cargo, 2.500);
            var resultado = new CalculadoraDeSalario(funcionario).Calcula();
            
            Console.WriteLine(resultado);
            Console.WriteLine("\n---------------------------\n");
            
            Console.WriteLine("2.Acoplamento-Estabilidade");

            var listEventosAporGerarNota = new List<IAcaoAposGerarNota>();
            listEventosAporGerarNota.Add(new NotaFiscalDao());
            listEventosAporGerarNota.Add(new EnviadorDeEmail());
     
            var gerarNf = new GeradorDeNotaFiscal(listEventosAporGerarNota).Gera(new Acoplamento_Estabilidade.Fatura(200, "José"));

             Console.WriteLine(gerarNf.ValorBruto);
             Console.WriteLine("\n---------------------------\n");

            Console.WriteLine("3.OCP-DIP");

            var tabelaPreco = new TabelaDePrecoPadrao();
            var servicoEntrega = new Frete();

            var calculadoraPreco = new CalculadoraDePrecos(tabelaPreco, servicoEntrega);
            var valorCalculado = calculadoraPreco.Calcula(new Compra(){Cidade=new FreteCidadeSaoPaulo(), Valor= 100});

            Console.WriteLine(valorCalculado);
            Console.WriteLine("\n---------------------------\n");
            
            Console.WriteLine("4.Encapsulamento");

            IList<Boleto> boletos = new List<Boleto>();

            boletos.Add(new Boleto(200.00));
            boletos.Add(new Boleto(300.00));
            boletos.Add(new Boleto(350.00));

            Encapsulamento.Fatura fatura = new Encapsulamento.Fatura("Joseph", 900);

            ProcessadorDeBoletos pdb = new ProcessadorDeBoletos();
            pdb.Processa(boletos, fatura);

            Console.WriteLine(fatura.Pago);
            Console.WriteLine("\n---------------------------\n");

            Console.WriteLine("5.Heranca-LSP");

            IList<ContaComum> contas = new List<ContaComum>();
            var contaComum = new ContaComum();
            contaComum.Deposita(100);
            contas.Add(contaComum);

            var contaComum2 = new ContaComum();
            contaComum2.Deposita(150);
            contas.Add(contaComum2);

            var contaEstudante = new ContaEstudante();
            contaEstudante.Deposita(100);
            contas.Add(contaEstudante);

            ProcessadorDeInvestimentos pi = new ProcessadorDeInvestimentos();
            pi.Processa(contas);

            Console.WriteLine("\n---------------------------\n");
            
        }
    }
}
