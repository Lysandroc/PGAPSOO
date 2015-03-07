using System.Collections.Generic;
using Work.APSOO.Dominio;
using Work.APSOO.Repositorio.Cruds;

namespace Work.APSOO.RegraNegocio
{
    public class CursoRN
    {
        private readonly Crud<Curso> repositorio;

        public CursoRN()
        {
            repositorio = new Crud<Curso>();
        }

        public IEnumerable<Curso> ListarTodos()
        {
            return repositorio.GetAllList();
        }

        public string Deletar(Curso objeto)
        {
               return repositorio.Delete(objeto);
        }

        public string Alterar(Curso objeto)
        {
                return repositorio.Update(objeto);
        }

        public string Criar(Curso objeto)
        {
                return repositorio.Create(objeto);
        }
    }
}
