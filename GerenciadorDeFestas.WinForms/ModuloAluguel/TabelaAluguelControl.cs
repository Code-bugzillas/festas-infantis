using GerenciadorDeFestas.Dominio.ModuloAluguel;
using GerenciadorDeFestas.WinForms.Compartilhado;

namespace GerenciadorDeFestas.WinForms.ModuloAluguel
{
    public partial class TabelaAluguelControl : UserControl
    {
        public TabelaAluguelControl()
        {
            InitializeComponent();

            ConfigurarColunas();

            grid.ConfigurarGridZebrado();

            grid.ConfigurarGridSomenteLeitura();
        }

        public void AtualizarRegistros(List<Aluguel> alugueis)
        {
            grid.Rows.Clear();

            foreach (Aluguel aluguel in alugueis)
            {
                grid.Rows.Add(aluguel.id, aluguel.cliente, aluguel.tema, aluguel.data, aluguel.cep, aluguel.dataFechamento, aluguel.porcentagemPaga, aluguel.ValorAhPagar);
            }
            TelaPrincipalForm.Instancia.AtualizarRodape($"Visualizando {alugueis.Count} alugueis");
        }


        private void ConfigurarColunas()
        {
            DataGridViewColumn[] colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn()
                {
                    Name = "id",
                    HeaderText = "Id"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "cliente",
                    HeaderText = "Cliente"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "tema",
                    HeaderText = "Tema"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "data",
                    HeaderText = "Data"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "cep",
                    HeaderText = "CEP"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "dataFechamento",
                    HeaderText = "Fechamento"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "pago",
                    HeaderText = "% paga"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "valorAhPagar",
                    HeaderText = "Valor a Pagar"
                }
            };
            grid.Columns.AddRange(colunas);
        }

        public int ObterIdSelecionado()
        {
            int id;

            try
            {
                id = Convert.ToInt32(grid.SelectedRows[0].Cells["id"].Value);
            }
            catch
            {
                id = -1;
            }

            return id;
        }

    }
}
