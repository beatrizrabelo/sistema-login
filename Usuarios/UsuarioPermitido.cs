using SistemaLogin.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLogin.Usuarios
{
    class UsuarioPermitido : Usuario, IPermissao
    {
        public string Senha { get; set; }
        public UsuarioPermitido (string login) 
            : base(login){}

        public bool Verificar(string senha)
        {
            return Senha == senha;
        }
    }
}
