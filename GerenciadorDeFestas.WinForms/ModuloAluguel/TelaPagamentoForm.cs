using GerenciadorDeFestas.Dominio.ModuloAluguel;

namespace GerenciadorDeFestas.WinForms.ModuloAluguel
{
    public partial class TelaPagamentoForm : Form
    {
        public TelaPagamentoForm()
        {
            InitializeComponent();
        }

        public decimal PorcentagemPaga(Aluguel aluguelSelecionado)
        {
            if (rdbQuarenta.Checked)
                return aluguelSelecionado.porcentagemPaga = 40;

            else if (rdbCinquenta.Checked)
                return aluguelSelecionado.porcentagemPaga = 50;

            else if (rdbCem.Checked)
                return aluguelSelecionado.porcentagemPaga = 100;

            return aluguelSelecionado.porcentagemPaga = 0;
        }
    }
}
