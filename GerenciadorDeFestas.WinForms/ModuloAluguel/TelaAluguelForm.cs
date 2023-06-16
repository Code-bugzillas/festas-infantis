using GerenciadorDeFestas.Dominio.ModuloAluguel;
using GerenciadorDeFestas.Dominio.ModuloCliente;
using GerenciadorDeFestas.Dominio.ModuloTema;
using GerenciadorDeFestas.Infra.Dados.Arquivo.Compartilhado;
using GerenciadorDeFestas.WinForms.Compartilhado;

namespace GerenciadorDeFestas.WinForms.ModuloAluguel
{
    public partial class TelaAluguelForm : Form
    {
        public TelaAluguelForm(List<Cliente> clientes, List<Tema> temas)
        {
            InitializeComponent();
            this.ConfigurarDialog();

            ConfigurarComboBoxClientes(clientes);
            ConfigurarComboBoxTema(temas);
        }

        public Aluguel ObterAluguel()
        {
            int id = int.Parse(txtId.Text);
            Cliente cliente = (Cliente)cbCliente.SelectedItem;
            Tema tema = (Tema)cbTema.SelectedItem;
            DateTime data = dtData.Value;
            DateTime horaInicio = dtHoraInicio.Value;
            DateTime horaFinal = dtHoraFinal.Value;
            string Cidade = txtCidade.Text;
            string numero = txtNum.Text;
            string nomeRua = txtRua.Text;

            Aluguel aluguel = new Aluguel(cliente, tema, data, horaInicio, horaFinal, Cidade, numero, nomeRua);
            aluguel.id = id;

            if (tema != null)
            {
                aluguel.valorAhPagar = tema.resultado;
                aluguel.valorAhPagar = aluguel.CalcularValorAPagar();
            }

            return aluguel;
        }

        public void ConfigurarTela(Aluguel aluguelSelecionado)
        {
            txtId.Text = aluguelSelecionado.id.ToString();
            cbCliente.Text = aluguelSelecionado.cliente.ToString();
            cbTema.Text = aluguelSelecionado.tema.ToString();
            dtData.Value = aluguelSelecionado.data;
            dtHoraInicio.Value = aluguelSelecionado.horaInicio;
            dtHoraFinal.Value = aluguelSelecionado.horaFinal;
            txtCidade.Text = aluguelSelecionado.cidade;
            txtNum.Text = aluguelSelecionado.numero;
            txtRua.Text = aluguelSelecionado.rua;
            cbCliente.Enabled = false;
            cbTema.Enabled = false;
        }

        public void ConfigurarComboBoxClientes(List<Cliente> clientes)
        {
            foreach (Cliente cliente in clientes)
            {
                cbCliente.Items.Add(cliente);
            }
        }

        public void ConfigurarComboBoxTema(List<Tema> temas)
        {
            foreach (Tema tema in temas)
            {
                cbTema.Items.Add(tema);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Aluguel aluguel = ObterAluguel();

            ValidarErros(aluguel);
        }

        private void ValidarErros(Aluguel aluguel)
        {
            if (aluguel == null) return;

            string[] erros = aluguel.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
        }

    }
}