
namespace Work.APSOO.Dominio
{
    public class Aluno
    {
        public int Id { get; set; }
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public Curso Curso { get; set; }
    }
}
