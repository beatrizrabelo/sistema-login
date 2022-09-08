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
            maria.Senha = "maria@123";

            Coordenador julio = new Coordenador("c.julio");

            Diretor angela = new Diretor("d.angela");

            SistemaInterno sistema = new SistemaInterno();

            sistema.Logar(maria, "maria@123");

            int totalUsuarios = Usuario.TotalDeUsuarios;

            Console.WriteLine(totalUsuarios);
            Console.ReadLine();
        }
    }
}
