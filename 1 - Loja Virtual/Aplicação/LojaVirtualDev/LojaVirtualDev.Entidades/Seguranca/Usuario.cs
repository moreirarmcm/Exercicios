using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtualDev.Entidades.Seguranca
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public byte[] HashSenha { get; set; }
        public byte[] SaltSenha { get; set; }
        public int Situacao { get; set; }
        public DateTime Criacao { get; set; }

    }
}
