﻿namespace DesignPatternsBoasPraticas
{
    internal class DescontoPorMaisDeQuinhentosReais : Desconto
    {
        public Desconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (orcamento.Valor >= 500)
            {
                return orcamento.Valor * 0.07;
            }
            return Proximo.Desconta(orcamento);
        }
    }
}
