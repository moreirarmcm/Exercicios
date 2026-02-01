using LojaVirtualDev.Entidades.Seguranca;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtualDev.Dados.Interfaces.Seguranca
{
    public interface IUsuarioDados
    {
        Task<int> InserirUsuario(Usuario usuario);
        Task<IEnumerable<Usuario>> ListarUsuarios ();
        Task<Usuario> BuscarUsuario(int codigo, string email);
        Task<Usuario> AutenticarUsuario(string email); 
    }
}
