using GerenciadorDeFestas.Infra.Dados.Arquivo.Compartilhado;
using GerenciadorDeFestas.Infra.Dados.Arquivo.ModuloCliente;
using GerenciadorDeFestas.WinForms.Compartilhado;
using GerenciadorDeFestas.WinForms.ModuloAluguel;
using GerenciadorDeFestas.WinForms.ModuloCliente;
using GerenciadorDeFestas.WinForms.ModuloItem;
using GerenciadorDeFestas.WinForms.ModuloTema;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GerenciadorDeFestas.WinForms
{
    public partial class TelaPrincipalForm : Form
    {
        private static TelaPrincipalForm telaPrincipal;

        private ControladorBase controlador;

        static ContextoDados contexto = new ContextoDados(carregarDados: true);

        //aqui vai os instanciamentos dos repositorios

        public TelaPrincipalForm()
        {
            InitializeComponent();
            telaPrincipal = this;
        }
        public void AtualizarRodape(string mensagem)
        {
            labelRodape.Text = mensagem;
        }

        public static TelaPrincipalForm Instancia
        {
            get
            {
                if (telaPrincipal == null)
                    telaPrincipal = new TelaPrincipalForm();

                return telaPrincipal;
            }
        }

        private void ConfigurarTelaPrincipal(ControladorBase controladorBase)
        {
            toolBar.Enabled = true;

            labelTipoCadastro.Text = controladorBase.ObterTipoCadastro();

            ConfigurarBarraFerramentas(controlador);

            ConfigurarListagem(controlador);
        }

        private void ConfigurarListagem(ControladorBase controladorBase)
        {
            UserControl listagem = controladorBase.ObterListagem();

            listagem.Dock = DockStyle.Fill;

            panelRegistros.Controls.Clear();

            panelRegistros.Controls.Add(listagem);
        }

        private void ConfigurarBotoesHabilitados(ControladorBase controlador)
        {
            btnInserir.Enabled = controlador.InserirHabilitado;
            btnEditar.Enabled = controlador.EditarHabilitado;
            btnExcluir.Enabled = controlador.ExcluirHabilitado;
            btnPagamento.Enabled = controlador.PagamentoHabilitado;
        }

        private void ConfigurarToolTips(ControladorBase controlador)
        {
            btnInserir.ToolTipText = controlador.ToolTipInserir;
            btnEditar.ToolTipText = controlador.ToolTipEditar;
            btnExcluir.ToolTipText = controlador.ToolTipExcluir;
            btnPagamento.ToolTipText = controlador.ToolTipPagamento;
        }

        private void ConfigurarBarraFerramentas(ControladorBase controlador)
        {
            toolBar.Enabled = true;

            ConfigurarToolTips(controlador);

            ConfigurarBotoesHabilitados(controlador);
        }

        private void clientesMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorCliente();

            ConfigurarTelaPrincipal(controlador);
        }

        private void TemasMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorTema();

            ConfigurarTelaPrincipal(controlador);
        }

        private void ItensMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorItem();

            ConfigurarTelaPrincipal(controlador);
        }

        private void aluguelMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorAluguel();

            ConfigurarTelaPrincipal(controlador);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            controlador.Inserir();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            controlador.Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            controlador.Excluir();
        }

        private void btnPagamento_Click(object sender, EventArgs e)
        {
            controlador.Pagamento();
        }
    }
}