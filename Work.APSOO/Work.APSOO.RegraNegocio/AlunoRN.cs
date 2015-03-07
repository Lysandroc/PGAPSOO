using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Work.APSOO.Dominio;
using Work.APSOO.Repositorio.Cruds;

namespace Work.APSOO.RegraNegocio
{
    public class AlunoRN
    {
        private readonly Crud<Aluno> repositorio;

        public AlunoRN()
        {
            repositorio = new Crud<Aluno>();
        }

        public IEnumerable<Aluno> ListarTodos()
        {
            return repositorio.GetAllList();
        }

        public string Deletar(Aluno objeto)
        {
               return repositorio.Delete(objeto);
        }

        public string Alterar(Aluno objeto)
        {
                return repositorio.Update(objeto);
        }

        public string Criar(Aluno objeto)
        {
                return repositorio.Create(objeto);
        }
    }
}
