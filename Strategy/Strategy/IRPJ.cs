using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class IRPJ : IImposto
    {
        public double ObterValorImposto(FaturamentoAnual faturamento)
        {
            return faturamento.ValorFaturamentoAnual * 0.02;
        }
    }
}
