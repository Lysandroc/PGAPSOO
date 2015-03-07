using System;

namespace Work.APSOO.Dominio
{
    public class Frequencia
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public Boolean Presente { get; set; }
        public AlunoTurma AlunoTurma { get; set; }
    }
}
