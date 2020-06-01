
namespace LiskovSubstitution
{
    public class CalculoDeComissaoClienteComum : CalculoDeComissao
    {
        public CalculoDeComissaoClienteComum(double valorVenda)
            : base(valorVenda)
        {
        }

        public override double CalculaComissao() => _valorVenda * 0.05;
    }
}


