using GerenciadorDeFestas.Dominio.ModuloAluguel;
using GerenciadorDeFestas.Dominio.ModuloCliente;
using GerenciadorDeFestas.Dominio.ModuloTema;
using GerenciadorDeFestas.Infra.Dados.Arquivo.Compartilhado;
using GerenciadorDeFestas.WinForms.Compartilhado;
using GerenciadorDeFestas.WinForms.ModuloCliente;
using System.Windows.Forms;

namespace GerenciadorDeFestas.WinForms.ModuloAluguel
{
    public class ControladorAluguel : ControladorBase
    {
        private IRepositorioCliente repositorioCliente;
        private IRepositorioTema repositorioTema;
        private IRepositorioAluguel repositorioAluguel;
        private TabelaAluguelControl tabelaAluguel;

        public ControladorAluguel(IRepositorioAluguel repositorioAluguel, IRepositorioCliente repositorioCliente, IRepositorioTema repositorioTema)
        {
            this.repositorioAluguel = repositorioAluguel;
            this.repositorioCliente = repositorioCliente;
            this.repositorioTema = repositorioTema;
        }

        #region
        public override string ToolTipInserir { get { return "Inserir novo Aluguel"; } }

        public override string ToolTipEditar { get { return "Editar Aluguel existente"; } }

        public override string ToolTipExcluir { get { return "Excluir Aluguel existente"; } }

        public override string ToolTipPagamento { get { return "Gerenciar pagamento"; } }

        public override string ToolTipVisualizar { get { return "Visualizar detalhes do Aluguel"; } }
        #endregion

        public override void Inserir()
        {
            if (repositorioCliente.SelecionarTodos().Count == 0)
            {
                ApresentarMensagem("Não há clientes cadastrados!", "Inserção de aluguéis");
                return;
            }

            if (repositorioTema.SelecionarTodos().Count == 0)
            {
                ApresentarMensagem("Não há temas cadastrados!", "Inserção de aluguéis");
                return;
            }

            TelaAluguelForm telaAluguel = new TelaAluguelForm(repositorioCliente.SelecionarTodos(), repositorioTema.SelecionarTodos());

            DialogResult opcaoEscolhida = telaAluguel.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Aluguel aluguel = telaAluguel.ObterAluguel();

                if (aluguel == null) return;

                aluguel.cliente.alugueis.Add(aluguel);
                aluguel.tema.alugueis.Add(aluguel);

                aluguel.CalcularValorTotal();
                aluguel.CalcularValorAPagar();

                repositorioAluguel.Inserir(aluguel);

                CarregarAlugueis();
            }
        }

        public override void Editar()
        {
            if (repositorioCliente.SelecionarTodos().Count == 0)
            {
                ApresentarMensagem("Não há clientes cadastrados!", "Edição de aluguéis");
                return;
            }

            if (repositorioTema.SelecionarTodos().Count == 0)
            {
                ApresentarMensagem("Não há temas cadastrados!", "Edição de aluguéis");
                return;
            }

            Aluguel aluguelSelecionado = ObterAluguelSelecionado();

            if (aluguelSelecionado == null)
            {
                ApresentarMensagem("Selecione um aluguel primeiro!", "Edição de Alugueis");
                return;
            }

            if (aluguelSelecionado.pagamentoFinalizado)
            {
                ApresentarMensagem("Este pagamento já está fechado!", "Pagamentos");
                return;
            }

            TelaAluguelForm telaAluguel = new TelaAluguelForm(repositorioCliente.SelecionarTodos(), repositorioTema.SelecionarTodos());
            telaAluguel.ConfigurarTela(aluguelSelecionado);

            DialogResult opcaoEscolhida = telaAluguel.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Aluguel aluguel = telaAluguel.ObterAluguel();


                aluguel.CalcularValorTotal();
                aluguel.CalcularValorAPagar();

                repositorioAluguel.Editar(aluguel.id, aluguel);

                CarregarAlugueis();
            }
        }

        public override void Excluir()
        {
            Aluguel aluguel = ObterAluguelSelecionado();

            if (aluguel == null)
            {
                ApresentarMensagem("Selecione um aluguel primeiro!", "Exclusão de Alugueis");

                return;
            }

            if (aluguel.pagamentoFinalizado == false)
            {
                ApresentarMensagem("Não é possível excluir um aluguel não finalizado!", "Exclusão de Alugueis");
                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o Aluguel {aluguel.cliente.nome}?", "Exclusão de Alugueis",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                for (int i = 0; i < aluguel.cliente.alugueis.Count(); i++)
                {
                    if (aluguel.cliente.alugueis[i] == aluguel)
                    {
                        aluguel.cliente.alugueis.Remove(aluguel.cliente.alugueis[i]);
                    }
                }

                for (int i = 0; i < aluguel.tema.alugueis.Count(); i++)
                {
                    if (aluguel.tema.alugueis[i] == aluguel)
                    {
                        aluguel.tema.alugueis.Remove(aluguel.tema.alugueis[i]);
                    }
                }

                repositorioAluguel.Excluir(aluguel);

                CarregarAlugueis();
            }
        }

        public override void Pagamento()
        {
            TelaPagamentoForm telaPagamento = new TelaPagamentoForm();

            Aluguel aluguelSelecionado = ObterAluguelSelecionado();

            if (aluguelSelecionado.pagamentoFinalizado)
            {
                ApresentarMensagem("Este pagamento já está fechado!", "Pagamentos");
                return;
            }

            telaPagamento.CarregarLabel(aluguelSelecionado);

            telaPagamento.ConfigurarTela(aluguelSelecionado);

            DialogResult opcaoEscolhida = telaPagamento.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                telaPagamento.PorcentagemPaga(aluguelSelecionado);

                aluguelSelecionado.valorAhPagar = aluguelSelecionado.CalcularValorAPagar();

                aluguelSelecionado.FinalizarPagamento();

                repositorioAluguel.AtualizarPagamentoJson(aluguelSelecionado.id, aluguelSelecionado);

                CarregarAlugueis();
            }
        }

        public override void Visualizar()
        {
            Aluguel aluguel = ObterAluguelSelecionado();

            if (aluguel == null)
            {
                MessageBox.Show("Selecione um aluguel!");
                return;
            }

            TelaVisualizarForm tela = new TelaVisualizarForm(aluguel);

            tela.CarregarLabel(aluguel);

            tela.ShowDialog();
        }

        private Aluguel ObterAluguelSelecionado()
        {
            int id = tabelaAluguel.ObterIdSelecionado();

            return repositorioAluguel.SelecionarPorId(id);
        }

        private void CarregarAlugueis()
        {
            List<Aluguel> alugueis = repositorioAluguel.SelecionarTodos();

            tabelaAluguel.AtualizarRegistros(alugueis);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaAluguel == null)
                tabelaAluguel = new TabelaAluguelControl();

            CarregarAlugueis();

            return tabelaAluguel;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Aluguel";
        }

        public override void ApresentarMensagem(string mensagem, string titulo)
        {
            MessageBox.Show(mensagem, titulo, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}

