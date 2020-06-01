using System;

namespace InterfaceSegregation
{
    public class MaquinaDeCafeFiltrado : IMaquinaDeCafeFiltrado
    {
        public void AdicionarAguaQuente()
        {
            Console.WriteLine("Água quente adicionada.");

        }

        public void AdicionarFiltro()
        {
            Console.WriteLine("Filtro adicionado");

        }

        public void AdicionarPo()
        {
            Console.WriteLine("Pó adicionado");
        }

        public void FazerCafe()
        {
            AdicionarFiltro();
            AdicionarPo();
            AdicionarAguaQuente();
        }
    }
}
