using System;
using System.Collections.Generic;
using System.Text;
using Reserva.Banco;
using Reserva.Modelos.Interface;
using System.Data.SqlClient;

namespace Reserva.Modelos.DAO
{
    public class UsuarioDAO : IRepository<Usuario>
    {
        public Usuario Inserir(Usuario user)
        {
            String query = "INSERT INTO usuario(nm_nome, nm_login, nm_senha, id_tp_usuario) VALUES (@nm_nome, @nm_login, @nm_senha, @id_tp_usuario)";

            BD.ExecuteNonQuery(query, new SqlParameter[]{
              new SqlParameter("@nm_nome", user.Nome),
                new SqlParameter("@nm_login", user.Login),
                new SqlParameter("@nm_senha", user.Senha),
                new SqlParameter("@id_tp_usuario", user.TipoUsuario)
            });

            return user;
        }

        public IList<Usuario> Buscar() { throw new Exception(); }

        public IList<Usuario> Buscar(Func<Usuario, Boolean> expression) { throw new Exception(); }

        public Usuario Atualizar(Usuario user)
        {
            String query = "UPDATE usuario SET nm_nome = @nm_nome, nm_login = @nm_login, nm_senha = @nm_senha, id_tp_usuario = @id_tp_usuario WHERE id_usuario = @id_usuario";

            BD.ExecuteNonQuery(query, new SqlParameter[]{
              new SqlParameter("@nm_nome", user.Nome),
                new SqlParameter("@nm_login", user.Login),
                new SqlParameter("@nm_senha", user.Senha),
                new SqlParameter("@id_tp_usuario", user.TipoUsuario),
                new SqlParameter("@id_usuario", user.ID)
            });

            return user;
        }

        public void Deletar(Usuario user)
        {
            String query = "DELETE FROM usuario WHERE id_usuario = @id_usuario";

            BD.ExecuteNonQuery(query, new SqlParameter[]{
                new SqlParameter("@id_usuario", user.ID)
            });
        }
    }
}
