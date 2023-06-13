using System.Text.Json.Serialization;
using System.Text.Json;
using GerenciadorDeFestas.Dominio.ModuloCliente;
using GerenciadorDeFestas.Dominio.ModuloItem;
using GerenciadorDeFestas.Dominio.ModuloTema;
using GerenciadorDeFestas.Dominio.ModuloAluguel;

namespace GerenciadorDeFestas.Infra.Dados.Arquivo.Compartilhado
{
    public class ContextoDados
    {
        private const string NOME_ARQUIVO = "GerenciadorDeFestas.json";

        public List<Cliente> clientes;
        public List<Item> itens;
        public List<Tema> temas;
        public List<Aluguel> alugueis;

        public ContextoDados()
        {
            clientes = new List<Cliente>();
            itens = new List<Item>();
            temas = new List<Tema>();
            alugueis = new List<Aluguel>();
        }

        public ContextoDados(bool carregarDados) : this()
        {
            CarregarDoArquivoJson();
        }

        public void GravarEmArquivoJson()
        {
            JsonSerializerOptions config = ObterConfiguracoes();

            string registrosJson = JsonSerializer.Serialize(this, config);

            File.WriteAllText(NOME_ARQUIVO, registrosJson);
        }

        private void CarregarDoArquivoJson()
        {
            JsonSerializerOptions config = ObterConfiguracoes();

            if (File.Exists(NOME_ARQUIVO))
            {
                string registrosJson = File.ReadAllText(NOME_ARQUIVO);

                if (registrosJson.Length > 0)
                {
                    ContextoDados ctx = JsonSerializer.Deserialize<ContextoDados>(registrosJson, config);

                    this.clientes = ctx.clientes;
                    this.itens = ctx.itens;
                    this.temas = ctx.temas;
                    this.alugueis = ctx.alugueis;
                }
            }
        }

        private static JsonSerializerOptions ObterConfiguracoes()
        {
            JsonSerializerOptions opcoes = new JsonSerializerOptions();
            opcoes.IncludeFields = true;
            opcoes.WriteIndented = true;
            opcoes.ReferenceHandler = ReferenceHandler.Preserve;

            return opcoes;
        }
    }
}
