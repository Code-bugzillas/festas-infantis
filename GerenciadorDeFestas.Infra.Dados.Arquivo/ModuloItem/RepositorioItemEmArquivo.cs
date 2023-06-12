using GerenciadorDeFestas.Dominio.ModuloItem;
using GerenciadorDeFestas.Infra.Dados.Arquivo.Compartilhado;

namespace GerenciadorDeFestas.Infra.Dados.Arquivo.ModuloItem
{
    public class RepositorioItemEmArquivo : RepositorioArquivoBase<Item>, IRepositorioItem
    {
        public RepositorioItemEmArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        protected override List<Item> ObterRegistros()
        {
            return contextoDados.itens;
        }
    }
}
