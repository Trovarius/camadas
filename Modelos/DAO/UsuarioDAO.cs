using System;
using System.Collections.Generic;
using System.Text;
using Reserva.Banco;
using Reserva.Modelos.Interface;

namespace Reserva.Modelos.DAO
{
    internal class UsuarioDAO : IRepository<Usuario>
    {
        public Usuario Inserir(Usuario user)
        {
            String query = "INSERT INTO usuario(nm_nome, nm_login, nm_senha, id_tp_usuario) VALUES (@nm_nome, @nm_login, @nm_senha, @id_tp_usuario)";

            BD.ExecuteNonQuery(query);

            return new Usuario();
        }

        public Usuario Atualizar(Usuario user)
        {
            throw new ExecptionDAO();
        }

        public void Deletar(Usuario user)
        {
            throw new ExecptionDAO();
        }
    }
}
