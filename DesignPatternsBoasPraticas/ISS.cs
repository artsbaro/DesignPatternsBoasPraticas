﻿namespace DesignPatternsBoasPraticas
{
    internal class ISS: Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }
    }
}
