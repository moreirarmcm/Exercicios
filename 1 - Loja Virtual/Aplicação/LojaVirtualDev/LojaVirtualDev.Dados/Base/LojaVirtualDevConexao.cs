using Microsoft.Extensions.Configuration;
using System.Data;
using Microsoft.Data.SqlClient;

namespace LojaVirtualDev.Dados.Base
{
    public class LojaVirtualDevConexao
    {
        private readonly string stringConexao;

        public LojaVirtualDevConexao(IConfiguration configuration)
        {
            stringConexao = configuration.GetConnectionString("LojaVirtualDev");
        }

        public IDbConnection EstabelecerConexao()
        {
            return new SqlConnection(stringConexao);

        }
    }
}