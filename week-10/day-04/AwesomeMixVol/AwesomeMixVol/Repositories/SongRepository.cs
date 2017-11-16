using AwesomeMixVol.Entities;
using AwesomeMixVol.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AwesomeMixVol.Repositories
{
    public class SongRepository
    {
        private SongContext SongContext;

        public SongRepository(SongContext songContext)
        {
            SongContext = songContext;
        }

        public void AddSong(Song song)
        {
            SongContext.AddSong(song);
        }
    }
} 
