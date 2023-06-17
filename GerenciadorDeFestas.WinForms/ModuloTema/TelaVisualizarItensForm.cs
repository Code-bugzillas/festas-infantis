using GerenciadorDeFestas.Dominio.ModuloItem;
using GerenciadorDeFestas.Dominio.ModuloTema;
using GerenciadorDeFestas.WinForms.Compartilhado;

namespace GerenciadorDeFestas.WinForms.ModuloTema
{
    public partial class TelaVisualizarItensForm : Form
    {
        public TelaVisualizarItensForm()
        {
            InitializeComponent();
            this.ConfigurarDialog();
        }

        public void AtualizarLista(List<Item> itens)
        {
            listTemas.Items.Clear();

            foreach (Item item in itens)
            {
                listTemas.Items.Add("  ★ " + item);
            }
        }

        public void CarregarLista(List<Item> itens)
        {
            AtualizarLista(itens);
        }

        public void CarregarLabel(Tema tema)
        {
            lblTema.Text = tema.nome;
        }
    }
}
