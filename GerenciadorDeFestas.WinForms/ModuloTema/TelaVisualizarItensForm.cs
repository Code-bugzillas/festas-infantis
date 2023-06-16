using GerenciadorDeFestas.Dominio.ModuloAluguel;
using GerenciadorDeFestas.Dominio.ModuloItem;
using GerenciadorDeFestas.Dominio.ModuloTema;
using GerenciadorDeFestas.WinForms.Compartilhado;

namespace GerenciadorDeFestas.WinForms.ModuloTema
{
    public partial class TelaVisualizarItensForm : Form
    {
        public TelaVisualizarItensForm(Item itemSelecionado)
        {
            InitializeComponent();

            this.ConfigurarDialog();

            AtualizarLista(itemSelecionado);
        }

        private void AtualizarLista(Item itemSelecionado)
        {
            listTemas.Items.Clear();

            string[] atributos = itemSelecionado.ToString().Split('\n');
            listTemas.Items.AddRange(atributos);

        }


        public void CarregarLabel(Tema tema)
        {
            lblTema.Text = tema.nome;
        }
    }
}
