namespace DesignPatternsBoasPraticas
{
    internal class CalculadorDeImpostos
    {
        public void RealizaCalculo(Orcamento orcamento, Imposto imposto )
        {
            double impostoCalculado = imposto.Calcula(orcamento);
            Console.WriteLine(impostoCalculado);
        }
    }
}
