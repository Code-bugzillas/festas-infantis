using GerenciadorDeFestas.Dominio.ModuloAluguel;
using GerenciadorDeFestas.WinForms.Compartilhado;
using System.Windows.Forms;

namespace GerenciadorDeFestas.WinForms.ModuloAluguel
{
    public partial class TelaVisualizarForm : Form
    {
        public TelaVisualizarForm(Aluguel aluguelSelecionado)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            AtualizarLista(aluguelSelecionado);
        }

        private void AtualizarLista(Aluguel aluguelSelecionado)
        {
            listFestas.Items.Clear();

            string[] atributos = aluguelSelecionado.ToString().Split('\n');
            listFestas.Items.AddRange(atributos);

        }

        public void CarregarLabel(Aluguel aluguel)
        {
            lblFesta.Text = aluguel.cliente.nome;
        }
    }
}
