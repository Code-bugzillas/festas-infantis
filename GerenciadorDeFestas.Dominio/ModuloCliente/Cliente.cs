using GerenciadorDeFestas.Dominio.Compartilhado;

namespace GerenciadorDeFestas.Dominio.ModuloCliente
{
    [Serializable]  
    public class Cliente : EntidadeBase<Cliente>
    {
        public string nome;
        public string telefone;
        public bool clienteAntigo;

        public Cliente( string nome, string telefone, bool clienteAntigo)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.clienteAntigo= clienteAntigo;
        }
        public Cliente()
        {

        }

        public override void AtualizarInformacoes(Cliente registroAtualizado)
        {
            this.nome = registroAtualizado.nome;
            this.telefone = registroAtualizado.telefone;
            this.clienteAntigo = registroAtualizado.clienteAntigo;
        }

        public override string ToString()
        {
            return nome;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if(string.IsNullOrEmpty(nome))
                erros.Add("O campo  'nome' é obrigatorio");

            if (string.IsNullOrEmpty(telefone))
                erros.Add("O campo  'telefone' é obrigatorio");

            return erros.ToArray();
        }

        public override bool Equals(object? obj)
        {
            return obj is Cliente cliente &&
                   id == cliente.id &&
                   nome == cliente.nome &&
                   telefone == cliente.telefone;
        }
    }
}
