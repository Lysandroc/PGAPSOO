using System.Collections.Generic;

namespace Work.APSOO.Dominio
{
    public class Curso
    {
        public int Id { get; set; }
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Aluno> Alunos { get; set; }
        public virtual ICollection<Disciplina> Disciplinas { get; set; } 
    }
}
