using GerenciadorDeFestas.Dominio.ModuloItem;
using GerenciadorDeFestas.WinForms.Compartilhado;

namespace GerenciadorDeFestas.WinForms.ModuloItem
{
    public class ControladorItem : ControladorBase
    {
        private IRepositorioItem repositorioItem;
        private TabelaItemControl tabelaItemControl;

        public ControladorItem(IRepositorioItem repositorioItem)
        {
            this.repositorioItem = repositorioItem;
        }

        #region
        public override string ToolTipInserir => "Inserir Item";

        public override string ToolTipEditar => "Editar Item";

        public override string ToolTipExcluir => "Excluir Item";

        public override bool PagamentoHabilitado => false;
        public override bool VisualizarHabilitado => false;
        #endregion

        public override void Inserir()
        {
            TelaItemForm telaItemForm = new TelaItemForm(repositorioItem.SelecionarTodos());

            DialogResult opcaoEscolhida = telaItemForm.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Item item = telaItemForm.ObterItem();

                repositorioItem.Inserir(item);
            }

            CarregarItens();
        }

        public override void Editar()
        {
            Item itemSelecionado = ObterItemSelecionado();

            if (itemSelecionado == null)
            {
                MessageBox.Show($"Selecione um item primeiro!",
                    "Edição de Itens",
                    MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }

            TelaItemForm telaItem = new TelaItemForm(repositorioItem.SelecionarTodos());
            telaItem.ConfigurarTela(itemSelecionado);

            DialogResult opcaoEscolhida = telaItem.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Item item = telaItem.ObterItem();

                repositorioItem.Editar(item.id, item);

                CarregarItens();
            }
        }

        public override void Excluir()
        {
            Item item = ObterItemSelecionado();

            if (item == null)
            {
                MessageBox.Show($"Selecione um item primeiro!",
                    "Exclusão de Itens",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o item {item.nome}?", "Exclusão de Itens",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioItem.Excluir(item);

                CarregarItens();
            }
        }

        private Item ObterItemSelecionado()
        {
            int id = tabelaItemControl.ObterIdSelecionado();

            return repositorioItem.SelecionarPorId(id);
        }

        private void CarregarItens()
        {
            List<Item> itens = repositorioItem.SelecionarTodos();

            tabelaItemControl.AtualizarRegistros(itens);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaItemControl == null)
                tabelaItemControl = new TabelaItemControl();

            CarregarItens();

            return tabelaItemControl;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Itens";
        }
    }
}
