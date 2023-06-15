using GerenciadorDeFestas.Dominio.Compartilhado;

namespace GerenciadorDeFestas.Dominio.ModuloItem
{
    [Serializable]
    public class Item : EntidadeBase<Item>
    {
        public string nome;
        public int valor;

        public Item(string nome, int valor)
        {
            this.nome = nome;
            this.valor = valor;
        }

        public Item()
        {

        }

        public override void AtualizarInformacoes(Item registroAtualizado)
        {
            nome = registroAtualizado.nome;
            valor = registroAtualizado.valor;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(nome))
                erros.Add("O campo nome é obrigatório!");

            if (valor == -1)
                erros.Add("O campo valor é obrigatório!");

            if (valor < 0)
                erros.Add("O campo valor não pode ser menor que zero!");

            return erros.ToArray();
        }

        public override string ToString()
        {
            return $"{nome}";
        }
    }
}
