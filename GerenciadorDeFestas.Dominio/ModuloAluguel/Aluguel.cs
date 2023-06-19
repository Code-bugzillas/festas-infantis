using GerenciadorDeFestas.Dominio.Compartilhado;
using GerenciadorDeFestas.Dominio.ModuloCliente;
using GerenciadorDeFestas.Dominio.ModuloTema;

namespace GerenciadorDeFestas.Dominio.ModuloAluguel
{
    [Serializable]
    public class Aluguel : EntidadeBase<Aluguel>
    {

        public Cliente cliente;
        public Tema tema;
        public DateTime data;
        public DateTime horaInicio;
        public DateTime horaFinal;
        public string cidade;
        public string numero;
        public string rua;
        public bool pagamentoFinalizado;

        public DateTime dataFechamento;
        public decimal porcentagemPaga;
        public decimal valorAhPagar;
        public decimal desconto;
        public decimal valorTotal;

        public Aluguel(Cliente cliente, Tema tema, DateTime data, DateTime horaInicio, DateTime horaFinal, string cidade, string numero, string rua)
        {
            this.cliente = cliente;
            this.tema = tema;
            this.data = data;
            this.horaInicio = horaInicio;
            this.horaFinal = horaFinal;
            this.cidade = cidade;
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
            this.cidade = registroAtualizado.cidade;
            this.numero = registroAtualizado.numero;
            this.valorAhPagar = registroAtualizado.valorAhPagar;
            this.dataFechamento = registroAtualizado.dataFechamento;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();


            if (cliente == null)
                erros.Add("O campo 'cliente' é obrigatório");

            if (tema == null)
                erros.Add("O campo 'tema' é obrigatório");

            if (data == DateTime.Now.Date)
                erros.Add("O campo data deve possuir uma data maior do que a de hoje");

            if (horaInicio > horaFinal)
                erros.Add("A hora inicial não pode ser maior que a hora final");

            if (string.IsNullOrEmpty(cidade))
                erros.Add("O campo 'Cidade' é obrigatório");

            if (string.IsNullOrEmpty(numero))
                erros.Add("O campo 'Numero' é obrigatório");

            if (string.IsNullOrEmpty(rua))
                erros.Add("O campo 'Rua' é obrigatório");

            return erros.ToArray();
        }

        public decimal CalcularDesconto()
        {
            int quantidadePedidos = cliente.alugueis.Count;

            switch (quantidadePedidos)
            {
                case 1: return valorTotal * 0.975m;
                case 2: return valorTotal * 0.96m;
                case 3: return valorTotal * 0.945m;
                case 4: return valorTotal * 0.93m;
                case 5: return valorTotal * 0.915m;
                case 6: return valorTotal * 0.9m;
                case 7: return valorTotal * 0.885m;
                case 8: return valorTotal * 0.87m;
            }

            if (quantidadePedidos >= 9)
            {
                return valorTotal * 0.855m;
            }

            return valorTotal * 0.99m;
        }


        public decimal CalcularValorAPagar()
        {
            valorAhPagar = valorTotal;

            valorAhPagar = valorAhPagar - (valorAhPagar * (porcentagemPaga / 100));

            return valorAhPagar;
        }

        public decimal CalcularValorTotal()
        {
            return valorTotal = CalcularDesconto();
        }


        public void AtualizarPagamento(Aluguel aluguelAtualizado)
        {
            porcentagemPaga = aluguelAtualizado.porcentagemPaga;
        }

        public void FinalizarPagamento()
        {
            if(porcentagemPaga == 100)
            {
                dataFechamento = DateTime.Now.Date;
                pagamentoFinalizado = true;
            }
        }

        public override string ToString()
        {
            return $"Tema: {tema.nome}\n" +
                   $"Data: {data.ToString("dd/MM/yyyy")}\n" +
                   $"Hora Inicio: {horaInicio.ToString("HH:mm")}\n" +
                   $"Hora Final: {horaFinal.ToString("HH:mm")}\n" +
                   $"Cidade: {cidade}\n" +
                   $"Rua: {rua}\n" +
                   $"Numero: {numero}";
        }
    }
}
