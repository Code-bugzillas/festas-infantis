using GerenciadorDeFestas.WinForms.ModuloTema;

namespace GerenciadorDeFestas.WinForms.Compartilhado
{
    public abstract class ControladorBase
    {
        public abstract string ToolTipInserir { get; }

        public abstract string ToolTipEditar { get; }

        public abstract string ToolTipExcluir { get; }

        public virtual string ToolTipPagamento { get; }

        public virtual bool InserirHabilitado { get { return true; } }

        public virtual bool EditarHabilitado { get { return true; } }

        public virtual bool ExcluirHabilitado { get { return true; } }

        public virtual bool PagamentoHabilitado { get { return true; } }

        public abstract void Inserir();

        public abstract void Editar();

        public abstract void Excluir();

        public virtual void Pagamento()
        {

        }

        public abstract UserControl ObterListagem();

        public abstract string ObterTipoCadastro();

    }
}
