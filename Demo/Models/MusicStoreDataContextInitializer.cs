﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Demo.Models
{
    public class MusicStoreDataContextInitializer : DropCreateDatabaseAlways<MusicStoreDataContext>
    {
        protected override void Seed(MusicStoreDataContext context)
        {
            Artist artist = new Artist() { Name = "Fist Artist" };
            context.Artists.Add(artist);
            context.Albums.Add(new Album() { Artist = artist, Title = "First Album" });
            context.Albums.Add(new Album() { Artist = artist, Title = "Second Album" });

            context.Albums.Add(new Album
            {
                Artist = context.Artists.Add(new Artist() { Name = "Second Artist" }),
                Title = "Third Album"
            });
            context.SaveChanges();
        }

    }
}