using System.Collections.Generic;
using Work.APSOO.Dominio;
using Work.APSOO.Repositorio.Cruds;

namespace Work.APSOO.RegraNegocio
{
    public class AlunoTurmaRN
    {
        private readonly Crud<AlunoTurma> repositorio;

        public AlunoTurmaRN()
        {
            repositorio = new Crud<AlunoTurma>();
        }
        
        public IEnumerable<AlunoTurma> ListarTodos()
        {
            return repositorio.GetAllList();
        }

        public string Deletar(AlunoTurma objeto)
        {
            return repositorio.Delete(objeto);
        }

        public string Alterar(AlunoTurma objeto)
        {
            return repositorio.Update(objeto);
        }

        public string Criar(AlunoTurma objeto)
        {
            return repositorio.Create(objeto);
        }
    }
}
