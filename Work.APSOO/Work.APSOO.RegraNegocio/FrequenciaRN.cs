using System.Collections.Generic;
using Work.APSOO.Dominio;
using Work.APSOO.Repositorio.Cruds;


namespace Work.APSOO.RegraNegocio
{
    public class FrequenciaRN
    {
        private readonly Crud<Frequencia> repositorio;

        public FrequenciaRN()
        {
            repositorio = new Crud<Frequencia>();
        }

        public IEnumerable<Frequencia> ListarTodos()
        {
            return repositorio.GetAllList();
        }

        public string Deletar(Frequencia objeto)
        {
               return repositorio.Delete(objeto);
        }

        public string Alterar(Frequencia objeto)
        {
                return repositorio.Update(objeto);
        }

        public string Criar(Frequencia objeto)
        {
                return repositorio.Create(objeto);
        }

    }
}
