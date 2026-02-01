using LojaVirtualDev.Entidades.Cadastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtualDev.Dados.Interfaces.Cadastro
{
    public interface IProdutoDados
    {

        Task<int> InserirProduto(Produto produto);
        Task<Produto> BuscarProduto(int codigo, string nome);
        Task<IEnumerable<Produto>> ListarProdutos();
    }
}
