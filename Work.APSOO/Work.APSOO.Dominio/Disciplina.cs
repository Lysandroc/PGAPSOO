using System.Collections.Generic;

namespace Work.APSOO.Dominio
{
    public class Disciplina
    {
        public int Id { get; set; }
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Professor> Professores { get; set; }
        public virtual ICollection<Turma> Turmas { get; set; }
        public virtual ICollection<Curso> Cursos { get; set; } 
    }
}
