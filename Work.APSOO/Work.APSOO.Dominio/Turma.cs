using System;

namespace Work.APSOO.Dominio
{
    public class Turma
    {
        public int Id { get; set; }
        public int Numero { get; set; }
        public DateTime Horario { get; set; }
        public Professor Professor { get; set; }
        public Disciplina Disciplina { get; set; }
    }
}
