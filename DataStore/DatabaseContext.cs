using Microsoft.EntityFrameworkCore;

namespace dn_mvc_loc
{
    /// <summary>
    /// This class handles the sqlite database
    /// </summary>
    public class DatabaseContext : DbContext
    {
        /// <summary>
        /// This property allows to manipoulate the video games table
        /// </summary>
        public DbSet<VideoGame> VideoGames { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Location> Locations { get; set; }

        public DbSet<Item> Items { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Specify the path of the database here
            optionsBuilder.UseSqlite("Filename=./db_context.sqlite");
        }
    }
}