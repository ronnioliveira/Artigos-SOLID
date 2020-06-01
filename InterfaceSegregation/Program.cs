using System;

namespace InterfaceSegregation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Preparando um café filtrado!");

            var maquinaDeCafeFiltrado = new MaquinaDeCafeFiltrado();
            maquinaDeCafeFiltrado.FazerCafe();

            Console.WriteLine();
            Console.WriteLine("Preparando um café expresso!");

            var maquinaDeCafeExpresso = new MaquinaDeCafeExpresso();
            maquinaDeCafeExpresso.FazerCafe();

            Console.ReadKey();
        }
    }
}
