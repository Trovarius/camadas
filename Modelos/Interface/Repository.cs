using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Reserva.Banco;
using System.Data;

namespace Reserva.Modelos.Interface
{
    public class Repository<T> : IRepository<T> where T : class
    {
        DataTable table;

        public DataTable Table
        {
            get
            {
                if (Convert.Equals(table, null))
                    table = BD.DataTable(String.Format("select * from {0}", Entity.Name.ToLower()));

                return table;
            }
            set { table = value; }
        }

        private Type Entity
        {
            get { return typeof(T); }
        }


        public IList<T> Buscar() { throw new Exception(); }

        public IList<T> Buscar(Func<T, Boolean> expression) { throw new Exception(); }
        public T Inserir(T klass) { throw new Exception(); }
        public T Atualizar(T klass) { throw new Exception(); }
        public void Deletar(T klass) { throw new Exception(); }
    }
}
