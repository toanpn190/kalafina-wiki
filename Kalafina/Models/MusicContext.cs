using Kalafina.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

namespace Kalafina.Models
{
    public class MusicContext : DbContext
    {
        public MusicContext() : base("KalafinaMusicContext") { }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Concert> Concerts { get; set; }
        public DbSet<ConcertList> ConcertLists { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}