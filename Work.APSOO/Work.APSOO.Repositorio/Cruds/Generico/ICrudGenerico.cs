using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Work.APSOO.Repositorio.Cruds.Generico
{
    public interface ICrudGenerico<T> where T : class
    {
       
        string Update(T entity);
        string Delete(T entity);
        string Create(T entity);
        IQueryable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> where);
        T FindId(Expression<Func<T, bool>> where);

        List<T> FindList(Expression<Func<T, bool>> where);
        List<T> GetAllList();
    }
}
