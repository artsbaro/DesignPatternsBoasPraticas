
namespace DesignPatternsBoasPraticas
{
    internal class CalculadorDeDescontos
    {
        public double Calcula(Orcamento orcamento)
        {
            Desconto desconto1 = new DescontoPorCincoItens();
            Desconto desconto2 = new DescontoPorMaisDeQuinhentosReais();
            Desconto desconto3 = new SemDesconto();

            desconto1.Proximo = desconto2;
            desconto2.Proximo = desconto3;

            return desconto1.Desconta(orcamento);
        }
    }
}
