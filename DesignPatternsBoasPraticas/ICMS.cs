namespace DesignPatternsBoasPraticas
{
    internal class ICMS : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
                
        }
    }
}
