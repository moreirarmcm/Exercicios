using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtualDev.Entidades.Cadastro
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome {  get; set; }
        public float Preco { get; set; }
        public int Ativo { get; set; }
    }
}
