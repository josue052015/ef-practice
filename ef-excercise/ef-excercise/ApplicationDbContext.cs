using Microsoft.EntityFrameworkCore;

namespace ef_excercise
{
    public class ApplicationDbContext : DbContext
    {
        //options is for pass configurations through the class instance(like connection string)
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
