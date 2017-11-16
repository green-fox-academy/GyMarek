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

        public SongService(SongRepository songRepository)
        {
            this.songRepository = songRepository;
        }

        public void AddSong(Song song)
        {
            songRepository.AddSong(song);
        }

    }
}
