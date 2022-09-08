using SistemaLogin.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLogin.Usuarios
{
    class Coordenador : UsuarioPermitido
    {
        public Coordenador(string login) 
            : base(login){}
    }
}
