//This class will help to migrate the Domain to MSSQL DB. This class is used in program class

using INWalks.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace INWalks.API.Data
{
    public class INWalksDbContext : DbContext
    {
        
        public INWalksDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions){
        }

        //Below properties will create table inside DB. It is a collection of entries
        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
    }
}
