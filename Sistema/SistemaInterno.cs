using SistemaLogin.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLogin.Sistema
{
    /// <summary>
    /// Define o o Sistema Interno para o acesso.
    /// </summary>
    class SistemaInterno
    {
        /// <summary>
        /// Executa o acesso ao sistema.
        /// </summary>
        /// <param name="usuario"> Representa o argumento criado. </param>
        /// <param name="senha"> Representa o argumento criado e precisa ser igual a definição. </param>
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
