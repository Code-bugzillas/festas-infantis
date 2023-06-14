using GerenciadorDeFestas.Dominio.ModuloAluguel;
using GerenciadorDeFestas.WinForms.Compartilhado;

namespace GerenciadorDeFestas.WinForms.ModuloAluguel
{
    public partial class TelaPagamentoForm : Form
    {
        public bool cemPorcento;

        public TelaPagamentoForm()
        {
            InitializeComponent();
            this.ConfigurarDialog();
        }

        public void ConfigurarTela(Aluguel aluguelSelecionado)
        {
            decimal porcentagemPaga = aluguelSelecionado.porcentagemPaga;

            if (porcentagemPaga == 40)
                rdbQuarenta.Checked = true;

            else if (porcentagemPaga == 50)
                rdbCinquenta.Checked = true;

            else if (porcentagemPaga == 100)
                rdbCem.Checked = true;
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
