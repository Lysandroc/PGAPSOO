using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Work.APSOO.Repositorio.Cruds.Generico;
using System.Data.Entity;
using Work.APSOO.Repositorio.Contexto;

namespace Work.APSOO.Repositorio.Cruds
{
    public class Crud<T> : ICrudGenerico<T> where T : class
    {
        public readonly ModeloContexto context;

        public Crud()
        {
            context = new ModeloContexto();
        }

        public string Update(T entity)
        {
            try
            {
                context.Entry<T>(entity).State = EntityState.Modified;
                context.SaveChanges();
                return "";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string Delete(T entity)
        {
            try
            {
                
                context.Entry(entity).State = EntityState.Deleted;
                context.Set<T>().Remove(entity);
                context.SaveChanges();
                return "";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string Create(T entity)
        {
            try
            {
                context.Set<T>().Add(entity);
                context.SaveChanges();
                return "";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public IQueryable<T> GetAll()
        {
            return context.Set<T>();
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> where)
        {
            return context.Set<T>().Where(where);
        }

        public List<T> GetAllList()
        {
            try
            {
                using (ModeloContexto context = new ModeloContexto())
                {
                    var busca = from e in context.Set<T>() select e;
                    return busca.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<T> FindList(Expression<Func<T, bool>> where)
        {
            return context.Set<T>().Where(where).ToList();
        }

        public T FindId(Expression<Func<T, bool>> where)
        {
            return context.Set<T>().Where(where).FirstOrDefault();
        }

    }
}
