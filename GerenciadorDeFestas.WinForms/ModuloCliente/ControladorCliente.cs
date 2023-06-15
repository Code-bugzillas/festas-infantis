using GerenciadorDeFestas.Dominio.ModuloAluguel;
using GerenciadorDeFestas.Dominio.ModuloCliente;
using GerenciadorDeFestas.Infra.Dados.Arquivo.Compartilhado;
using GerenciadorDeFestas.WinForms.Compartilhado;
using GerenciadorDeFestas.WinForms.ModuloAluguel;

namespace GerenciadorDeFestas.WinForms.ModuloCliente
{
    public class ControladorCliente : ControladorBase
    {

        private IRepositorioCliente repositorioCliente;
        private ContextoDados contextoDados;
        private TabelaClienteControl tabelaCliente;

        public ControladorCliente(IRepositorioCliente repositorioCliente, ContextoDados contextoDados)
        {
            this.repositorioCliente = repositorioCliente;
            this.contextoDados = contextoDados;
        }

        #region
        public override string ToolTipInserir { get { return "Inserir novo Cliente"; } }

        public override string ToolTipEditar { get { return "Editar Cliente existente"; } }

        public override string ToolTipExcluir { get { return "Excluir Cliente existente"; } }

        public override bool PagamentoHabilitado => false;
        #endregion

        public override void Inserir()
        {
            TelaClienteForm telaCliente = new TelaClienteForm(repositorioCliente.SelecionarTodos(), contextoDados);

            DialogResult opcaoEscolhida = telaCliente.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Cliente cliente = telaCliente.ObterCliente();

                repositorioCliente.Inserir(cliente);

                CarregarClientes();
            }
        }

        public override void Editar()
        {
            Cliente clienteSelecionado = ObterClienteSelecionado();

            if (clienteSelecionado == null)
            {
                MessageBox.Show($"Selecione um cliente primeiro!",
                    "Edição de Clientes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaClienteForm telaCliente = new TelaClienteForm(repositorioCliente.SelecionarTodos(), contextoDados);
            telaCliente.ConfigurarTela(clienteSelecionado);

            DialogResult opcaoEscolhida = telaCliente.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Cliente cliente = telaCliente.ObterCliente();

                repositorioCliente.Editar(cliente.id, cliente);

                CarregarClientes();
            }
        }

        public override void Excluir()
        {
            Cliente cliente = ObterClienteSelecionado();

            if (cliente == null)
            {
                MessageBox.Show($"Selecione um cliente primeiro!",
                    "Exclusão de Clientes",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            foreach (Aluguel c in contextoDados.alugueis)
            {
                if (c.cliente == cliente)
                {
                    MessageBox.Show($"O Cliente nao pode ser excluido pois esta em uso!",
                      "Exclusão de Clientes",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Exclamation);

                    return;
                }
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o cliente {cliente.nome}?", "Exclusão de Clientes",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioCliente.Excluir(cliente);

                CarregarClientes();
            }
        }

        private Cliente ObterClienteSelecionado()
        {
            int id = tabelaCliente.ObterIdSelecionado();

            return repositorioCliente.SelecionarPorId(id);
        }

        private void CarregarClientes()
        {
            List<Cliente> clientes = repositorioCliente.SelecionarTodos();

            tabelaCliente.AtualizarRegistros(clientes);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaCliente == null)
                tabelaCliente = new TabelaClienteControl();

            CarregarClientes();

            return tabelaCliente;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Clientes";
        }

        public override void Visualizar()
        {
            Cliente cliente = ObterClienteSelecionado();

            foreach(Aluguel c in contextoDados.alugueis)
            {
                if (c.cliente == cliente)
                {

                }
            }
        }
    }
}
