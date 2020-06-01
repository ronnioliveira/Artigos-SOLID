using System;

namespace LiskovSubstitution
{
    class Program
    {
        static void Main(string[] args)
        {
            var valorVenda = 150;

            CalculoDeComissao comissaoComum = new CalculoDeComissaoClienteComum(valorVenda);
            Console.WriteLine($"Comissão do cliente comum e de: {comissaoComum.CalculaComissao()}");

            Console.WriteLine();

            CalculoDeComissao comissaoPremium = new CalculoDeComissaoClientePremium(valorVenda);
            Console.WriteLine($"Comissão do cliente premium e de: {comissaoPremium.CalculaComissao()}");

            Console.ReadKey();
        }
    }
}
