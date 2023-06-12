using GerenciadorDeFestas.Dominio.ModuloItem;
using GerenciadorDeFestas.Dominio.ModuloTema;

namespace GerenciadorDeFestas.WinForms.ModuloTema
{
    public partial class TelaTemaForm : Form
    {
        public TelaTemaForm(List<Item> itens)
        {
            InitializeComponent();

            CarregarItens(itens);
        }

        public Tema ObterTema()
        {
            int id = int.Parse(txtId.Text);
            string nome = txtTema.Text;
            int valor;
            try
            {
                valor = int.Parse(txtValor.Text);
            }
            catch
            {
                valor = -1;
            }

            Tema tema = new Tema(nome, valor);

            tema.id = id;

            tema.itens = chListItens.CheckedItems.Cast<Item>().ToList();

            return tema;
        }

        public void ConfigurarTela(Tema temaSelecionado)
        {
            txtId.Text = temaSelecionado.id.ToString();
            txtTema.Text = temaSelecionado.nome;
            txtValor.Text = temaSelecionado.valor.ToString();

            int i = 0;

            for (int j = 0; j < chListItens.Items.Count; j++)
            {
                Item item = (Item)chListItens.Items[j];

                if (temaSelecionado.itens.Contains(item))
                {
                    chListItens.SetItemChecked(i, true);
                }

                i++;
            }
        }

        private void CarregarItens(List<Item> itens)
        {
            foreach (Item item in itens)
            {
                chListItens.Items.Add(item);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Tema tema = ObterTema();

            string[] erros = tema.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }
    }
}
