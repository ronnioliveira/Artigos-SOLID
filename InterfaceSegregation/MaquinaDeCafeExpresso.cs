using System;

namespace InterfaceSegregation
{
    public class MaquinaDeCafeExpresso : IMaquinaDeCafeExpresso
    {
        public void AdicionarAguaQuente()
        {
            Console.WriteLine("Água quente adicionada.");
        }

        public void AdicionarPo()
        {
            Console.WriteLine("Pó adicionado");
        }

        public void MoerGrao()
        {
            Console.WriteLine("Grão moído");
        }

        public void FazerCafe()
        {
            MoerGrao();
            AdicionarPo();
            AdicionarAguaQuente();
        }
    }    
}
