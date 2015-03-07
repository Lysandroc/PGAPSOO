using System.Collections.Generic;

namespace Work.APSOO.Dominio
{
    public class Professor
    {
        public int Id { get; set; }
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Turma> Turmas { get; set; }
        public virtual ICollection<Disciplina> Disciplinas { get; set; } 
    }
}
