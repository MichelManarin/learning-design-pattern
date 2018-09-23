using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class CalculadorImposto
    {
        public double Calcular(FaturamentoAnual faturamento, IImposto imposto)
        {
           return imposto.ObterValorImposto(faturamento);
        }
    }
}
