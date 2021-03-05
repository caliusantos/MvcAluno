using Microsoft.EntityFrameworkCore;
using mvcaluno.Models;

namespace mvcaluno.Data
{
    public class AlunoContext : DbContext
    {
        public AlunoContext (DbContextOptions<AlunoContext> options) : base(options) 
        {
        }
        public DbSet<Aluno> Aluno {get; set;}
    }
}