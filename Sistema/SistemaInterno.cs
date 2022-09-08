using SistemaLogin.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLogin.Sistema
{
    class SistemaInterno
    {
        public bool Logar (IPermissao usuario, string senha)
        {
            bool usuarioAutenticado = usuario.Verificar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Bem-Vindo ao Sistema!");
                return true;
            } else
            {
                Console.WriteLine("Senha Incorreta.");
                return false;
            }
        }
    }
}
