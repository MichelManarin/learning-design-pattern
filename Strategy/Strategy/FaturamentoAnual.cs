using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class FaturamentoAnual
    {
        public double ValorFaturamentoAnual { get; private set; }

        public FaturamentoAnual(Double valor)
        {
            this.ValorFaturamentoAnual = valor;
        }

    }
}
