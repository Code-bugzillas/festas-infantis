using GerenciadorDeFestas.Dominio.ModuloAluguel;
using GerenciadorDeFestas.Dominio.ModuloCliente;
using GerenciadorDeFestas.WinForms.Compartilhado;

namespace GerenciadorDeFestas.WinForms.ModuloCliente
{
    public partial class TelaVisualizarAlugueisForm : Form
    {
        public TelaVisualizarAlugueisForm(Cliente cliente)
        {
            InitializeComponent();
            this.ConfigurarDialog();
        }

        public void CarregarRegistros(List<Aluguel> alugueis)
        {
            tabela.AtualizarRegistros(alugueis);
        }

        public void CarregarLabel(Cliente cliente)
        {
            lblFesta.Text = cliente.nome;
        }
    }
}
