using AwesomeMixVol.Entities;
using AwesomeMixVol.Models;
using AwesomeMixVol.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AwesomeMixVol.Services
{
    public class SongService
    {
        private SongRepository songRepository;
        private SongContext songContext;

        public SongService(SongRepository songRepository, SongContext songContext)
        {
            this.songRepository = songRepository;
            this.songContext = songContext;
        }

        public void AddSong(Song song)
        {
            songRepository.AddSong(song);
        }

        public void DeleteSong(int SongId)
        {
            var song = songContext.Songs.Find(SongId);
            if (song == null)
            {
                throw new ArgumentException($"Song with id {SongId} not found");
            }            
            songRepository.DeleteSong(SongId);
        }
    }
}
