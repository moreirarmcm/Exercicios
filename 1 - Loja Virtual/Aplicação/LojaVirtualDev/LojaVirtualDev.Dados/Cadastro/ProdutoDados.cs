using Dapper;
using LojaVirtualDev.Dados.Base;
using LojaVirtualDev.Dados.Interfaces.Cadastro;
using LojaVirtualDev.Entidades.Cadastro;
using System.Runtime.CompilerServices;

namespace LojaVirtualDev.Dados.Cadastro
{
    public class ProdutoDados : IProdutoDados
    {
        private readonly LojaVirtualDevConexao _conexao;

        public ProdutoDados(LojaVirtualDevConexao conexao)
        {
            _conexao = conexao;
        }

        public async Task<int> InserirProduto(Produto produto)
        {
            using var conexao = _conexao.EstabelecerConexao();

            var parametros = new
            {
                produto.Nome,
                produto.Preco
            };

            var resultado = await conexao.ExecuteScalarAsync<int>(
                "cadastro.InserirProduto",
                parametros,
                commandType: System.Data.CommandType.StoredProcedure
                );

            return resultado;
        }

        public async Task<Produto> BuscarProduto(int codigo, string nome)
        {
            using var conexao = _conexao.EstabelecerConexao();
            var parametros = new
            {
                Codigo = codigo,
                Nome = nome
            };

            var resultado = await conexao.QueryFirstOrDefaultAsync<Produto>(
                "cadastro.BuscarProduto",
                parametros,
                commandType: System.Data.CommandType.StoredProcedure);

            return resultado;
        }
       
        public async Task<IEnumerable<Produto>> ListarProdutos()
        {
            using var conexao = _conexao.EstabelecerConexao();

            var listaProdutos = await conexao.QueryAsync<Produto>(
                "cadastro.BuscarProduto",
                new
                {
                    Codigo = (int?)null
                },
                commandType: System.Data.CommandType.StoredProcedure);

            return listaProdutos;

        }
    }
}