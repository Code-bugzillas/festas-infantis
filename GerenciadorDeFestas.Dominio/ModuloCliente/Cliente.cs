using GerenciadorDeFestas.Dominio.Compartilhado;
using GerenciadorDeFestas.Dominio.ModuloAluguel;
using System.Text.RegularExpressions;

namespace GerenciadorDeFestas.Dominio.ModuloCliente
{
    [Serializable]  
    public class Cliente : EntidadeBase<Cliente>
    {
        public string nome;
        public string telefone;

        public List<Aluguel> alugueis;

        public Cliente( string nome, string telefone)
        {
            this.nome = nome;
            this.telefone = telefone;
            alugueis = new List<Aluguel>();
        }

        public Cliente()
        {

        }

        public override void AtualizarInformacoes(Cliente registroAtualizado)
        {
            this.nome = registroAtualizado.nome;
            this.telefone = registroAtualizado.telefone;
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

            string apenasDigitos = Regex.Replace(telefone, "[^0-9]", "");

            if (string.IsNullOrEmpty(apenasDigitos))
                erros.Add("O campo 'telefone' é obrigatório");

            if (telefone.Length <= 13)
                erros.Add("O campo 'telefone' é obrigatório");

            if (nome.Length <= 2)
                erros.Add("O campo nome deve ter mais de 2 caracteres");

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
