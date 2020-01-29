using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BlacksmithManagerWeb.BLL
{
    interface IRepository<T> where T:class
    {
        public bool Guardar(T entity);
        public bool Modificar(T entity);
        //public bool Eliminar(T entity);
        public T Buscar(int Id);
    }
}
