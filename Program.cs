using System;

namespace Calculo_CPE
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumberElements = 6;

            PermuSimples calc = new PermuSimples();
            int TotalProvaveis = calc.PermutacaoSimples(NumberElements);

            Console.WriteLine(TotalProvaveis);
        }
    }
}
