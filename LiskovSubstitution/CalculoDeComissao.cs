
namespace LiskovSubstitution
{
    public abstract class CalculoDeComissao
    {
        protected readonly double _valorVenda;

        public CalculoDeComissao(double valorVenda)
        {
            _valorVenda = valorVenda;
        }

        public abstract double CalculaComissao();
    }
}


