using GerenciadorDeFestas.Dominio.Compartilhado;
using GerenciadorDeFestas.Dominio.ModuloCliente;
using GerenciadorDeFestas.Dominio.ModuloTema;

namespace GerenciadorDeFestas.Dominio.ModuloAluguel
{
    public class Aluguel : EntidadeBase<Aluguel>
    {

        public Cliente cliente;
        public Tema tema;
        public DateTime data;
        public DateTime horaInicio;
        public DateTime horaFinal;
        public string cep;
        public string numero;
        public string rua;

        public DateTime dataFechamento;
        public decimal porcentagemPaga;
        public decimal ValorAhPagar;

        public Aluguel(Cliente cliente, Tema tema, DateTime data, DateTime horaInicio, DateTime horaFinal, string cep, string numero, string rua)
        {
            this.cliente = cliente;
            this.tema = tema;
            this.data = data;
            this.horaInicio = horaInicio;
            this.horaFinal = horaFinal;
            this.cep = cep;
            this.numero = numero;
            this.rua = rua;
        }

        public Aluguel()
        {

        }

        public override void AtualizarInformacoes(Aluguel registroAtualizado)
        {
            this.id = registroAtualizado.id;
            this.cliente = registroAtualizado.cliente;
            this.tema = registroAtualizado.tema;
            this.data = registroAtualizado.data;
            this.horaInicio = registroAtualizado.horaInicio;
            this.horaFinal = registroAtualizado.horaFinal;
            this.rua = registroAtualizado.rua;
            this.cep = registroAtualizado.cep;
            this.numero = registroAtualizado.numero;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(cep))
                erros.Add("O campo 'CEP' é obrigatório");

            if (string.IsNullOrEmpty(rua))
                erros.Add("O campo 'Rua' é obrigatório");

            if (string.IsNullOrEmpty(numero))
                erros.Add("O campo 'Numero' é obrigatório");

            return erros.ToArray();
        }

        public decimal CalcularDesconto()
        {
            if (cliente.clienteAntigo)
            {
                return tema.valorTotal * (decimal)0.90;
            }
            return tema.valorTotal;
        }

        public decimal CalcularValorAhPagar()
        {
            decimal valorAhPagar = CalcularDesconto();

            valorAhPagar = valorAhPagar - (valorAhPagar * porcentagemPaga / 100);

            return valorAhPagar;
        }
    }
}
