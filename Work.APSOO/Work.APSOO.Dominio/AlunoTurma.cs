using System.Collections.Generic;

namespace Work.APSOO.Dominio
{
    public class AlunoTurma
    {
        public int Id { get; set; }
        public double Nota { get; set; }
        public Turma Turma { get; set; }
        public Aluno Aluno { get; set; }
        public virtual ICollection<Frequencia> Frequencias { get; set; } 
    }
}
