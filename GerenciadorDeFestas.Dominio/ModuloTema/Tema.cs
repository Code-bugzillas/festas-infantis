using GerenciadorDeFestas.Dominio.Compartilhado;
using GerenciadorDeFestas.Dominio.ModuloAluguel;
using GerenciadorDeFestas.Dominio.ModuloItem;

namespace GerenciadorDeFestas.Dominio.ModuloTema
{
    [Serializable]
    public class Tema : EntidadeBase<Tema>
    {
        public int valorTotal;
        public string nome;
        public decimal valor;
        public List<Item> itens;
        public List<Aluguel> alugueis; 
        public decimal resultado;

        public Tema(string nome, int valor)
        {
            this.nome = nome;
            this.valor = valor;
            this.itens = new List<Item>();
            this.alugueis = new List<Aluguel>();    
        }

        public Tema()
        {

        }

        public decimal CalcularValor()
        {
            valorTotal = 0;

            foreach (Item item in itens)
            {
                valorTotal += item.valor;
            }

            resultado = valor + valorTotal;

            return resultado;
        }

        public override void AtualizarInformacoes(Tema registroAtualizado)
        {
            nome = registroAtualizado.nome;
            valor = registroAtualizado.valor;
            itens = registroAtualizado.itens;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(nome))
                erros.Add("O campo tema é obrigatório");

            if (valor == -1)
                erros.Add("O campo valor é obrigatório");

            if (itens.Count == 0)
                erros.Add("É necessário incluir um Item.");

            return erros.ToArray();
        }

        public override string ToString()
        {
            return nome;
        }
    }
}
