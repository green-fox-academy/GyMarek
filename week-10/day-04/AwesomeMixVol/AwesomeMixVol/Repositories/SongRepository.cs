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
            SongContext.Songs.Add(song);
            SongContext.SaveChanges();
        }

        public void DeleteSong(int SongId)
        {
            var deleteItem = from deleteOne in SongContext.Songs
                             where deleteOne.SongId == SongId
                             select deleteOne;

            SongContext.Songs.Remove(deleteItem.FirstOrDefault());
            SongContext.SaveChanges();
        }
    }
} 
