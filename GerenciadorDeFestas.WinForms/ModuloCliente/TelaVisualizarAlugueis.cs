using GerenciadorDeFestas.Dominio.ModuloCliente;

namespace GerenciadorDeFestas.WinForms.ModuloCliente
{
    public partial class TelaVisualizarAlugueis : Form
    {
        public TelaVisualizarAlugueis(Cliente cliente)
        {
            InitializeComponent();

            //AtualizarLista(cliente);
        }

        //private void AtualizarLista(Cliente clienteSelecionado)
        //{
        //    listAluguel.Items.Clear();

        //    foreach (Aluguel aluguel in clienteSelecionado.aluguels)
        //    {
        //        string[] atributos = aluguel.ToString().Split('\n');
        //        listAluguel.Items.AddRange(atributos);
        //    }
        //}

        public void CarregarLabel(Cliente cliente)
        {
            lblFesta.Text = cliente.nome;
        }
    }
}
