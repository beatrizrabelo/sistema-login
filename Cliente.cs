﻿using SistemaLogin.Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLogin
{
    public class Cliente : IPermissao
    {
        public string Login { get; set; }
        public string Senha { get; set; }

        public Cliente(string login)
        {
            Login = login;
        }

        public bool Verificar(string senha)
        {
            return Senha == senha;
        }
    }
}