using System.Collections.Generic;
using Work.APSOO.Repositorio.Cruds;
using Work.APSOO.Dominio;

namespace Work.APSOO.RegraNegocio
{
    public class TurmaRN
    {
        private readonly Crud<Turma> repositorio;

        public TurmaRN()
        {
            repositorio = new Crud<Turma>();
        }

        public IEnumerable<Turma> ListarTodos()
        {
            return repositorio.GetAllList();
        }

        public string Deletar(Turma objeto)
        {
               return repositorio.Delete(objeto);
        }

        public string Alterar(Turma objeto)
        {
                return repositorio.Update(objeto);
        }

        public string Criar(Turma objeto)
        {
                return repositorio.Create(objeto);
        }
    }
}
