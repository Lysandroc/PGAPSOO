using System.Collections.Generic;
using Work.APSOO.Repositorio.Cruds;
using Work.APSOO.Dominio;

namespace Work.APSOO.RegraNegocio
{
    public class DisciplinaRN
    {
        private readonly Crud<Disciplina> repositorio;

        public DisciplinaRN()
        {
            repositorio = new Crud<Disciplina>();
        }

        public IEnumerable<Disciplina> ListarTodos()
        {
            return repositorio.GetAllList();
        }

        public string Deletar(Disciplina objeto)
        {
               return repositorio.Delete(objeto);
        }

        public string Alterar(Disciplina objeto)
        {
                return repositorio.Update(objeto);
        }

        public string Criar(Disciplina objeto)
        {
                return repositorio.Create(objeto);
        }
    }
}
