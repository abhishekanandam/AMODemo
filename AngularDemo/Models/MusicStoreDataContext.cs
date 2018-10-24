using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace Demo.Models
{
    public class MusicStoreDataContext : DbContext
    {
        public MusicStoreDataContext() : base("name=MusicStoreConnection")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<MusicStoreDataContext>());
        }

        public DbSet<Artist> Artists { get; set; }

        public DbSet<Album> Albums { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public System.Data.Entity.DbSet<Demo.Models.ArtistDetails> ArtistDetails { get; set; }
    }
}