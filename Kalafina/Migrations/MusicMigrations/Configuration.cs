namespace Kalafina.Migrations.MusicMigrations
{
    using Kalafina.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Kalafina.Models.MusicContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\MusicMigrations";
        }

        protected override void Seed(MusicContext context)
        {
            var albums = new List<Album>
            {
                new Album { Title = "The Best \"Red\"", ReleaseDate = DateTime.Parse("2014-07-16"), ImageUrl = " https://i.imgur.com/wqIFGCm.jpg" },
                new Album { Title = "The Best \"Blue\"", ReleaseDate = DateTime.Parse("2014-07-16"), ImageUrl = "https://i.imgur.com/S0zY5Se.jpg" }
            };

            albums.ForEach(s => context.Albums.AddOrUpdate(p => p.Title, s));
            context.SaveChanges();

            var songs = new List<Song>
            {
                new Song { TrackNo = 01, Title = "prelude",
                           AlbumID = albums.Single(i => i.Title == "The Best \"Red\"").ID },
                new Song { TrackNo = 02, Title = "misterioso",
                           AlbumID = albums.Single(i => i.Title == "The Best \"Red\"").ID },
                new Song { TrackNo = 03, Title = "Hikari no Senritsu",
                           AlbumID = albums.Single(i => i.Title == "The Best \"Red\"").ID },
                new Song { TrackNo = 04, Title = "Lacrimosa",
                           AlbumID = albums.Single(i => i.Title == "The Best \"Red\"").ID },
                new Song { TrackNo = 05, Title = "ARIA",
                           AlbumID = albums.Single(i => i.Title == "The Best \"Red\"").ID },
                new Song { TrackNo = 06, Title = "Kagayaku Sora no Shijima ni wa",
                           AlbumID = albums.Single(i => i.Title == "The Best \"Red\"").ID },
                new Song { TrackNo = 07, Title = "moonfesta",
                           AlbumID = albums.Single(i => i.Title == "The Best \"Red\"").ID },
                new Song { TrackNo = 08, Title = "Hikari Furu",
                           AlbumID = albums.Single(i => i.Title == "The Best \"Red\"").ID },
                new Song { TrackNo = 09, Title = "oblivious",
                           AlbumID = albums.Single(i => i.Title == "The Best \"Red\"").ID },
                new Song { TrackNo = 10, Title = "Ongaku",
                           AlbumID = albums.Single(i => i.Title == "The Best \"Red\"").ID },
                new Song { TrackNo = 11, Title = "consolation",
                           AlbumID = albums.Single(i => i.Title == "The Best \"Red\"").ID },
                new Song { TrackNo = 12, Title = "Mune no Yukue",
                           AlbumID = albums.Single(i => i.Title == "The Best \"Red\"").ID },
                new Song { TrackNo = 13, Title = "Yume no Daichi",
                           AlbumID = albums.Single(i => i.Title == "The Best \"Red\"").ID },
                new Song { TrackNo = 14, Title = "Eden",
                           AlbumID = albums.Single(i => i.Title == "The Best \"Red\"").ID },
                new Song { TrackNo = 15, Title = "Alleluia",
                           AlbumID = albums.Single(i => i.Title == "The Best \"Red\"").ID },

                new Song { TrackNo = 01, Title = "storia",
                           AlbumID = albums.Single(i => i.Title == "The Best \"Blue\"").ID },
                new Song { TrackNo = 02, Title = "Kimi no Gin no Niwa",
                           AlbumID = albums.Single(i => i.Title == "The Best \"Blue\"").ID },
                new Song { TrackNo = 03, Title = "red moon",
                           AlbumID = albums.Single(i => i.Title == "The Best \"Blue\"").ID },
                new Song { TrackNo = 04, Title = "Magia",
                           AlbumID = albums.Single(i => i.Title == "The Best \"Blue\"").ID },
                new Song { TrackNo = 05, Title = "seventh heaven",
                           AlbumID = albums.Single(i => i.Title == "The Best \"Blue\"").ID },
                new Song { TrackNo = 06, Title = "signal",
                           AlbumID = albums.Single(i => i.Title == "The Best \"Blue\"").ID },
                new Song { TrackNo = 07, Title = "Natsu no Ringo",
                           AlbumID = albums.Single(i => i.Title == "The Best \"Blue\"").ID },
                new Song { TrackNo = 08, Title = "sprinter",
                           AlbumID = albums.Single(i => i.Title == "The Best \"Blue\"").ID },
                new Song { TrackNo = 09, Title = "I have a dream",
                           AlbumID = albums.Single(i => i.Title == "The Best \"Blue\"").ID },
                new Song { TrackNo = 10, Title = "Mirai",
                           AlbumID = albums.Single(i => i.Title == "The Best \"Blue\"").ID },
                new Song { TrackNo = 11, Title = "Manten",
                           AlbumID = albums.Single(i => i.Title == "The Best \"Blue\"").ID },
                new Song { TrackNo = 12, Title = "snow falling",
                           AlbumID = albums.Single(i => i.Title == "The Best \"Blue\"").ID },
                new Song { TrackNo = 13, Title = "to the beginning",
                           AlbumID = albums.Single(i => i.Title == "The Best \"Blue\"").ID },
                new Song { TrackNo = 14, Title = "symphonia",
                           AlbumID = albums.Single(i => i.Title == "The Best \"Blue\"").ID },
                new Song { TrackNo = 15, Title = "heavenly blue",
                           AlbumID = albums.Single(i => i.Title == "The Best \"Blue\"").ID }
            };
            songs.ForEach(s => context.Songs.AddOrUpdate(p => p.Title, s));
            context.SaveChanges();
        }
    }
}
