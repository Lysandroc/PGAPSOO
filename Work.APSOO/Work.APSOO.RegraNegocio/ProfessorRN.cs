using System.Collections.Generic;
using Work.APSOO.Repositorio.Cruds;
using Work.APSOO.Dominio;

namespace Work.APSOO.RegraNegocio
{
    public class ProfessorRN
    {
        private readonly Crud<Professor> repositorio;

        public ProfessorRN()
        {
            repositorio = new Crud<Professor>();
        }

        public IEnumerable<Professor> ListarTodos()
        {
            return repositorio.GetAllList();
        }

        public string Deletar(Professor objeto)
        {
               return repositorio.Delete(objeto);
        }

        public string Alterar(Professor objeto)
        {
                return repositorio.Update(objeto);
        }

        public string Criar(Professor objeto)
        {
                return repositorio.Create(objeto);
        }
    }
}
