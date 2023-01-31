using Microsoft.EntityFrameworkCore;
using ProjetoPessoa;

namespace ProjetoPessoa
{
    public class appDbContext : DbContext
    {
        public appDbContext(DbContextOptions<appDbContext> options) : base(options)
        {

        }

        public DbSet<Pessoa> Pessoas { get; set; }


    }
}
 