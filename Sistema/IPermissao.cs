using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLogin.Sistema
{
    interface IPermissao
    {
        public bool Verificar (string senha);

    }
}
