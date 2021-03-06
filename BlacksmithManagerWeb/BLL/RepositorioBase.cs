﻿using Microsoft.EntityFrameworkCore;
using System;
using BlacksmithManagerWeb.Data;

namespace BlacksmithManagerWeb.BLL
{
    public class RepositorioBase<T> : IDisposable, IRepository<T> where T : class 
    {
        internal Contexto contexto;

        public RepositorioBase()
        {
            contexto = new Contexto();
        }

        public virtual bool Guardar(T entity)
        {

            bool paso = false;

            try
            {
                if (contexto.Set<T>().Add(entity) != null)
                    paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Dispose();
            }
            return paso;

        }

        public virtual bool Modificar(T entity)
        {

            bool paso = false;

            try
            {
                contexto.Entry(entity).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                Dispose();
            }

            return paso;

        }

        /*public virtual bool Eliminar(int id)
        {
            bool paso = false;

            try
            {
                T entity = contexto.Set<T>.Find(id);
                contexto.Set<T>().Remove(entity);
                paso = contexto.SaveChanges() > 0;
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                Dispose();
            }

            return paso;
        }*/

        public virtual T Buscar(int id)
        {
            T entity;

            try
            {
                entity = contexto.Set<T>().Find(id);
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                Dispose();
            }

            return entity;
        }

        public void Dispose()
        {
            contexto.Dispose();
        }

    }

}
