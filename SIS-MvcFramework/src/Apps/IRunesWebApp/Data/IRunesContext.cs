using IRunesWebApp.Models;

using Microsoft.EntityFrameworkCore;
using SIS.HTTP.Common;

namespace IRunesWebApp.Data
{
    public class IRunesContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Album> Albums { get; set; }

        public DbSet<Track> Tracks { get; set; }

        public DbSet<TrackAlbum> TracksAlbums { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(Configuration.Connection)
                .UseLazyLoadingProxies();
        
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TrackAlbum>()
                .HasKey(ta => new { ta.AlbumId, ta.TrackId });
        }
    }
}
