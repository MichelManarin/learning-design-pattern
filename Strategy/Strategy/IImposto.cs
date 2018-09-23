using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public interface IImposto 
    {
        Double ObterValorImposto(FaturamentoAnual faturamento); 
    }
}
