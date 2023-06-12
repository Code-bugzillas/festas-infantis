using GerenciadorDeFestas.Dominio.ModuloItem;

namespace GerenciadorDeFestas.WinForms.ModuloItem
{
    public partial class TelaItemForm : Form
    {
        public TelaItemForm(List<Item> itens)
        {
            InitializeComponent();
        }

        public Item ObterItem()
        {
            int id = int.Parse(txtId.Text);
            string nome = txtNome.Text;
            int valor;

            try
            {
                valor = int.Parse(txtValor.Text);
            }
            catch
            {
                valor = -1;
            }

            Item item = new Item(nome, valor);
            item.id = id;

            return item;
        }

        public void ConfigurarTela(Item itemSelecionado)
        {
            txtId.Text = itemSelecionado.id.ToString();
            txtNome.Text = itemSelecionado.nome;
            txtValor.Text = itemSelecionado.valor.ToString();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Item item = ObterItem();

            string[] erros = item.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}
