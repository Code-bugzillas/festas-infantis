using GerenciadorDeFestas.Dominio.ModuloAluguel;
using GerenciadorDeFestas.Dominio.ModuloCliente;
using GerenciadorDeFestas.Infra.Dados.Arquivo.Compartilhado;
using GerenciadorDeFestas.WinForms.Compartilhado;

namespace GerenciadorDeFestas.WinForms.ModuloCliente
{
    public partial class TelaClienteForm : Form
    {
        private Cliente cliente;
        private List<Cliente> clientes;

        public TelaClienteForm(List<Cliente> clientes)
        {
            this.clientes = clientes;

            InitializeComponent();

            this.ConfigurarDialog();
        }

        public Cliente ObterCliente()
        {
            int id = Convert.ToInt32(txtId.Text);
            string nome = txtNome.Text;
            string telefone = txtTelefone.Text;
            bool clienteAntigo = rdbAntigo.Checked;
            bool clienteNovo = rdbNovo.Checked;

            cliente = new Cliente(nome, telefone, clienteAntigo, clienteNovo);
            cliente.id = id;

            return cliente;
        }

        public void ConfigurarTela(Cliente clienteSelecionado)
        {
            txtId.Text = clienteSelecionado.id.ToString();
            txtNome.Text = clienteSelecionado.nome;
            txtTelefone.Text = clienteSelecionado.telefone;

            if (clienteSelecionado.clienteAntigo)
                rdbAntigo.Checked = true;
            else
                rdbNovo.Checked = true;
        }

        private void btnGravar_Click_1(object sender, EventArgs e)
        {
            Cliente cliente = ObterCliente();

            ValidarErros(cliente);
        }

        private void ValidarErros(Cliente cliente)
        {
            string[] erros = cliente.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }

            foreach (Cliente c in clientes)
            {
                if (cliente.nome == c.nome)
                {
                    MessageBox.Show("O nome ja esta em uso");

                    DialogResult = DialogResult.None;
                }
            }
        }

    }
}
