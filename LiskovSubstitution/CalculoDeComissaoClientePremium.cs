
namespace LiskovSubstitution
{
    public class CalculoDeComissaoClientePremium : CalculoDeComissao
    {
        public CalculoDeComissaoClientePremium(double valorVenda) 
            : base(valorVenda)
        {
        }

        public override double CalculaComissao() => _valorVenda * 0.07;
    }
}


