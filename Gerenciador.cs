using SistemaLogin.Sistema;
using SistemaLogin.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLogin
{
    class Gerenciador
    {
        public static void Main(string[] args)
        {
            Cliente maria = new Cliente("cl.maria");
            maria.Senha = "cliente@123";

            SistemaInterno sistema = new SistemaInterno();

            sistema.Logar(maria, "cliente@123");
        }
    }
}