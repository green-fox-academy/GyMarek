using AwesomeMixVol.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AwesomeMixVol.Entities
{
    public class SongContext : DbContext
    {
        public SongContext (DbContextOptions<SongContext> options) : base(options)
        {

        }

        private DbSet<Song> Songs { get; set; }

        public void AddSong(Song song)
        {
            Songs.Add(song);
            SaveChanges();
        }
    }
}
