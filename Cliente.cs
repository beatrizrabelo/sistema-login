using SistemaLogin.Sistema;
using SistemaLogin.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLogin
{
    /// <summary>
    /// Define um Cliente no Sistema Login.
    /// </summary>
    public class Cliente : IPermissao
    {
        public string Login { get; private set; }
        public string Senha { get; set; }

        /// <summary>
        /// Cria uma instância de Cliente. 
        /// </summary>
        /// <param name="login"> Representa a propriedade <see cref= "Login"/> e deve ser preenchido.</param>
        public Cliente (string login)
        {
            if (string.IsNullOrEmpty(login)){
                Console.WriteLine("Preencha o campo.");
            }

            Login = login;
        }

        /// <summary>
        /// Verifica a senha do sistema.
        /// </summary>
        /// <param name="senha"> Representa a propriedade <see cref="Senha"/> e deve ser igual a senha definida.</param>
        public bool Verificar (string senha)
        {
            return Senha == senha;
        }
    }
}
