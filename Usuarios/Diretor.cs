using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLogin.Usuarios
{
    class Diretor : UsuarioPermitido
    {
        public Diretor(string login) 
            : base(login){}
    }
}
