using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reserva.Modelos.Interface
{
    public interface IRepository<T>
    {
        IList<T> Buscar();
        IList<T> Buscar(Func<T, Boolean> expression);
        T Inserir(T klass);
        T Atualizar(T klass);
        void Deletar(T klass);
    }
}
