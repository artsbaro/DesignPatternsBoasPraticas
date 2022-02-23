namespace DesignPatternsBoasPraticas
{
    internal interface Desconto
    {
        double Desconta(Orcamento orcamento);
        Desconto Proximo { get; set; }
    }
}
