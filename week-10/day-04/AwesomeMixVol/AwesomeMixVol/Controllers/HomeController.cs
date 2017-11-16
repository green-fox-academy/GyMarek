using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AwesomeMixVol.Services;
using AwesomeMixVol.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AwesomeMixVol.Controllers
{
    public class HomeController : Controller
    {
        private SongService songService;

        public HomeController(SongService songService)
        {
            this.songService = songService;                
        }

        [Route("addsong")]
        public IActionResult AddSong([FromBody] Song song)
        {
            songService.AddSong(song);
            return Ok();
        }
    }
}
