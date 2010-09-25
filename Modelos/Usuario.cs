using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelos
{
    public class Usuario : UsuarioDAO
    {
        private String nm_nome, nm_login, nm_senha;
        private Int32 id_tp_usuario;

        public Int32 TipoUsuario
        {
            get { return id_tp_usuario; }
            set { id_tp_usuario = value; }
        }

        public String Senha
        {
            get { return nm_senha; }
            set { nm_senha = value; }
        }

        public String Login
        {
            get { return nm_login; }
            set { nm_login = value; }
        }

        public String Nome
        {
            get { return nm_nome; }
            set { nm_nome = value; }
        }

    }
}
