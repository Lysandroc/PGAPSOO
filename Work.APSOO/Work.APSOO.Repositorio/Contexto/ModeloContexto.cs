using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Work.APSOO.Dominio;

namespace Work.APSOO.Repositorio.Contexto
{
    public class ModeloContexto : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<AlunoTurma> AlunoTurmas { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<Frequencia> Frequencias { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Turma> Turmas { get; set; }

        public ModeloContexto() : base("ctxConexao")
        {
            Configuration.LazyLoadingEnabled = false;
            Database.SetInitializer(new AppDataContextInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
    public class AppDataContextInitializer : DropCreateDatabaseIfModelChanges<ModeloContexto> { }

}
