namespace GerenciadorDeFestas.Dominio.ModuloAluguel
{
    public class Desconto
    {
        public decimal valorMin;
        public decimal valorMax;

        public Desconto(bool valorDescontos)
        {
            if (valorDescontos)
            {
                valorMin = 1;
                valorMax = 15;
            }
        }
        public Desconto()
        {

        }

        public void EditarDesconto(Desconto desconto)
        {
            valorMin = desconto.valorMin;
            valorMax = desconto.valorMax;
        }
    }
}
