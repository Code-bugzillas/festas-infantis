using GerenciadorDeFestas.Dominio.Compartilhado;

namespace GerenciadorDeFestas.Dominio.ModuloCliente
{
    public class Cliente : EntidadeBase<Cliente>
    {
       
        public string nome;
        public string telefone;
        public bool clienteAntigo;
        private object clienteAntigo1;

        public Cliente() 
        {

        }

        public Cliente(int id, string nome, string telefone,bool clienteAntigo)
        {
            this.id = id;
            this.nome = nome;
            this.telefone = telefone;
            this.clienteAntigo = clienteAntigo;
            
        }

        public Cliente( string nome, string telefone, bool clienteAntigo)
        {
            this.nome = nome;
            this.telefone = telefone;
            this.clienteAntigo= clienteAntigo;
           
        }

        public Cliente(string nome, object clienteAntigo1)
        {
            this.nome = nome;
            this.clienteAntigo1 = clienteAntigo1;
        }

        public override void AtualizarInformacoes(Cliente registroAtualizado)
        {
            this.nome = registroAtualizado.nome;
            this.telefone = registroAtualizado.telefone;
            this.clienteAntigo = registroAtualizado.clienteAntigo;
            
        }

        public override string ToString()
        {
            return "Id: " + id + ", " + nome + ", Telefone: " + telefone;
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if(string.IsNullOrEmpty(nome))
                erros.Add("O campo  'nome' é obrigatorio");

            if (string.IsNullOrEmpty(telefone))
                erros.Add("O campo  'nome' é obrigatorio");

           
           
            return erros.ToArray();
        }

        public override bool Equals(object? obj)
        {
            return obj is Cliente contato &&
                   id == contato.id &&
                   nome == contato.nome &&
                   telefone == contato.telefone;
                  
        }
    }
}
