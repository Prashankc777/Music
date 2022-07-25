using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Music_APi.Models;

namespace Music_APi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongsController : ControllerBase
    {
        private static List<Song> songs = new List<Song>()
        {
            new Song()
            {
                Id = 1,
                Language = "Nepali",
                Title = "Romantic"
            },
            new Song()
            {
                Id = 2,
                Language = "Nepali",
                Title = "Romantic"

            }

        };

        [HttpGet, Route("Songs")]
        public IEnumerable<Song> Get()
        {
            return songs;
        }

        [HttpPost]
        public void Insert(Song song)
        {
            songs.Add(song);
        }
    }
}
