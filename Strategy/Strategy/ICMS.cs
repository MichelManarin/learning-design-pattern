using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class ICMS : IImposto
    {
        public double ObterValorImposto(FaturamentoAnual faturamento)
        {
            return faturamento.ValorFaturamentoAnual * 0.09;
        }
    }
}
