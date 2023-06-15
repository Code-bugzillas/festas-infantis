using GerenciadorDeFestas.Dominio.ModuloAluguel;
using GerenciadorDeFestas.Dominio.ModuloItem;
using GerenciadorDeFestas.Dominio.ModuloTema;
using GerenciadorDeFestas.Infra.Dados.Arquivo.Compartilhado;
using GerenciadorDeFestas.WinForms.Compartilhado;
using GerenciadorDeFestas.WinForms.ModuloItem;

namespace GerenciadorDeFestas.WinForms.ModuloTema
{
    public class ControladorTema : ControladorBase
    {
        private ContextoDados contextoDados;
        private IRepositorioItem repositorioItem;
        private IRepositorioTema repositorioTema;
        private TabelaTemaControl tabelaTemaControl;

        public ControladorTema(IRepositorioItem repositorioItem, IRepositorioTema repositorioTema, ContextoDados contextoDados)
        {
            this.contextoDados = contextoDados;
            this.repositorioItem = repositorioItem;
            this.repositorioTema = repositorioTema;
        }


        #region
        public override string ToolTipInserir => "Inserir tema";

        public override string ToolTipEditar => "Editar tema";

        public override string ToolTipExcluir => "Excluir tema";

        public override bool PagamentoHabilitado => false;
        public override bool VisualizarHabilitado => false;
        #endregion

        public override void Inserir()
        {
            TelaTemaForm telaTemaForm = new TelaTemaForm(repositorioItem.SelecionarTodos(), contextoDados);

            DialogResult opcaoEscolhida = telaTemaForm.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Tema tema = telaTemaForm.ObterTema();

                decimal valor = tema.CalcularValor();

                tema.resultado = valor;

                repositorioTema.Inserir(tema);

                CarregarTemas();
            }
        }

        public override void Editar()
        {
            Tema temaSelecionado = ObterTemaSelecionado();

            if (temaSelecionado == null)
            {
                MessageBox.Show($"Selecione um tema primeiro!",
                    "Edição de Temas",
                    MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
                return;
            }

            TelaTemaForm telaTema = new TelaTemaForm(repositorioItem.SelecionarTodos(), contextoDados);
            telaTema.ConfigurarTela(temaSelecionado);

            DialogResult opcaoEscolhida = telaTema.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Tema tema = telaTema.ObterTema();

                repositorioTema.Editar(tema.id, tema);

                CarregarTemas();
            }
        }

        public override void Excluir()
        {
            Tema tema = ObterTemaSelecionado();

            if (tema == null)
            {
                MessageBox.Show($"Selecione um tema primeiro!",
                    "Exclusão de Temas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            foreach(Aluguel a in contextoDados.alugueis)
            {
                if(a.tema == tema)
                {
                    MessageBox.Show($"O tema não pode ser excluído pois está em uso",
                    "Exclusão de Temas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                    return;
                }

            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o tema {tema.nome}?", "Exclusão de Temas",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioTema.Excluir(tema);

                CarregarTemas();
            }
        }

        private Tema ObterTemaSelecionado()
        {
            int id = tabelaTemaControl.ObterTemaSelecionado();

            return repositorioTema.SelecionarPorId(id);
        }

        private void CarregarTemas()
        {
            List<Tema> temas = repositorioTema.SelecionarTodos();

            tabelaTemaControl.AtualizarRegistros(temas);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaTemaControl == null)
                tabelaTemaControl = new TabelaTemaControl();

            CarregarTemas();

            return tabelaTemaControl;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Temas";
        }
    }
}
