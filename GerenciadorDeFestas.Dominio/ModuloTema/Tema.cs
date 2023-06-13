using GerenciadorDeFestas.Dominio.Compartilhado;
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
        public decimal Resultado;

        public Tema()
        {
            
        }

        public Tema(string nome, int valor)
        {
            this.nome = nome;
            this.valor = valor;
            this.itens = new List<Item>();
        }

        public decimal CalcularValor()
        {
            valorTotal = 0;

            foreach (Item item in itens)
            {
                valorTotal += item.valor;
            }

            Resultado = valor + valorTotal;

            return Resultado;
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
                erros.Add("O campo nome é obrigatório");

            if (valor == -1)
                erros.Add("O campo valor é obrigatório");

            if (itens.Count == 0)
                erros.Add("É necessário incluir um Item.");

            return erros.ToArray();
        }
    }
}
