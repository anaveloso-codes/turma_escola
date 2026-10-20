namespace turma_escola.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using turma_escola.Models;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Aluno> Alunos { get; set; }
    public DbSet<Professor> Professores { get; set; }
    public DbSet<Turma> Turmas { get; set; }
}
