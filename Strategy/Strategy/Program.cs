using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            // A vantagem é se for criado um novo imposto não precisarei refatorar o código, pois só irei 
            // precisar criar uma única nova classe de imposto =)

            FaturamentoAnual _faturamento = new FaturamentoAnual(250000.00);
            CalculadorImposto _calc = new CalculadorImposto();

            Console.WriteLine( _calc.Calcular(_faturamento, new IRPJ()));
            Console.WriteLine( _calc.Calcular(_faturamento, new ISS()));
            Console.WriteLine( _calc.Calcular(_faturamento, new ICMS()));

            Console.ReadKey();
        }
    }
}
