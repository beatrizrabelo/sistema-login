using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLogin.Usuarios
{
    public abstract class Usuario
    {
        public string Login { get; }
        public static int TotalDeUsuarios { get; private set;}

        public Usuario(string login)
        {
            if (string.IsNullOrEmpty(login))
            {
                Console.WriteLine("Preencha o campo.");
            }

            Login = login;

            TotalDeUsuarios++;
        }
    }
}
