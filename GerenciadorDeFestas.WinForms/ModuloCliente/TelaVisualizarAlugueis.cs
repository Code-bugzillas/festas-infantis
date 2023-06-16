using GerenciadorDeFestas.Dominio.ModuloAluguel;
using GerenciadorDeFestas.Dominio.ModuloCliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorDeFestas.WinForms.ModuloCliente
{
    public partial class TelaVisualizarAlugueis : Form
    {
        public TelaVisualizarAlugueis(Cliente cliente)
        {
            InitializeComponent();

            AtualizarLista(cliente);
        }

        private void AtualizarLista(Cliente clienteSelecionado)
        {
            listAluguel.Items.Clear();

            foreach(Aluguel aluguel in clienteSelecionado.aluguels)
            {
                string[] atributos = aluguel.ToString().Split('\n');
                listAluguel.Items.AddRange(atributos);
            }
        }

        public void CarregarLabel(Cliente cliente)
        {
            lblFesta.Text = cliente.nome;
        }
    }
}
