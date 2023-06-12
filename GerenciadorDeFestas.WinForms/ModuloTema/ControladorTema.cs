using GerenciadorDeFestas.Dominio.ModuloItem;
using GerenciadorDeFestas.Dominio.ModuloTema;
using GerenciadorDeFestas.WinForms.Compartilhado;
using GerenciadorDeFestas.WinForms.ModuloItem;

namespace GerenciadorDeFestas.WinForms.ModuloTema
{
    public class ControladorTema : ControladorBase
    {
        private IRepositorioItem repositorioItem;
        private IRepositorioTema repositorioTema;
        private TabelaTemaControl tabelaTemaControl;

        public ControladorTema(IRepositorioItem repositorioItem, IRepositorioTema repositorioTema)
        {
            this.repositorioItem = repositorioItem;
            this.repositorioTema = repositorioTema;
        }

        public override string ToolTipInserir => "Inserir tema";

        public override string ToolTipEditar => "Editar tema";

        public override string ToolTipExcluir => "Excluir tema";

        public override bool PagamentoHabilitado => false;

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

            TelaTemaForm telaTema = new TelaTemaForm(repositorioItem.SelecionarTodos());
            telaTema.ConfigurarTela(temaSelecionado);

            DialogResult opcaoEscolhida = telaTema.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Tema tema = telaTema.ObterTema();

                decimal valor = tema.CalcularValor();

                tema.valor = valor;

                repositorioTema.Editar(tema.id, tema);

                CarregarTemas();
            }
        }

        private Tema ObterTemaSelecionado()
        {
            int id = tabelaTemaControl.ObterTemaSelecionado();

            return repositorioTema.SelecionarPorId(id);
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

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o tema {tema.nome}?", "Exclusão de Temas",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioTema.Excluir(tema);

                CarregarTemas();
            }
        }

        public override void Inserir()
        {
            TelaTemaForm telaTemaForm = new TelaTemaForm(repositorioItem.SelecionarTodos());

            DialogResult opcaoEscolhida = telaTemaForm.ShowDialog();

            if(opcaoEscolhida == DialogResult.OK)
            {
                Tema tema = telaTemaForm.ObterTema();

                decimal valor = tema.CalcularValor();

                tema.valor = valor;

                repositorioTema.Inserir(tema);

                CarregarTemas();
            }
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
