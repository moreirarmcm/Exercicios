using Dapper;
using LojaVirtualDev.Dados.Base;
using LojaVirtualDev.Dados.Interfaces.Seguranca;
using LojaVirtualDev.Entidades.Seguranca;

namespace LojaVirtualDev.Dados.Seguranca
{
    public class UsuarioDados: IUsuarioDados
    {
        private readonly LojaVirtualDevConexao _conexao;
        public UsuarioDados(LojaVirtualDevConexao conexao)
        {
            _conexao = conexao;
        }

        public async Task<int> InserirUsuario(Usuario usuario)
        {
            using var conexao = _conexao.EstabelecerConexao();
            var parametros = new
            {
                usuario.Nome,
                usuario.Email,
                usuario.HashSenha,
                usuario.SaltSenha
            };

            var resultado = await conexao.ExecuteScalarAsync<int>(
                "seguranca.InserirUsuario",
                parametros,
                commandType: System.Data.CommandType.StoredProcedure);

            return resultado;
        }
        public async Task<Usuario> BuscarUsuario(int codigo, string email)
        {
            using var conexao = _conexao.EstabelecerConexao();
            var parametros = new
            {
                Codigo = codigo,
                Email = email,
            };

            var resultado = await conexao.QueryFirstOrDefaultAsync<Usuario>(
                "seguranca.BuscarUsuario",
                parametros,
                commandType: System.Data.CommandType.StoredProcedure);

            return resultado;
        }
        public async Task<IEnumerable<Usuario>> ListarUsuarios()
        {
            using var conexao = _conexao.EstabelecerConexao();
           
            var listaUsuarios = await conexao.QueryAsync<Usuario>(
                "seguranca.BuscarUsuario",
                new {codigo = (int?)null},
                commandType: System.Data.CommandType.StoredProcedure);
          
            return listaUsuarios;
        }



        public Task<Usuario> AutenticarUsuario(string email)
        {
            using var conexao = _conexao.EstabelecerConexao();

            var resultado = conexao.QueryFirstOrDefaultAsync<Usuario>(
                "seguranca.AutenticarUsuario",
                new { Email = email },
                commandType: System.Data.CommandType.StoredProcedure
                );
            return resultado;
        
        }
    }
}
