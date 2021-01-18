using System;
using System.Collections.Generic;

namespace SWAPI.TASK.WebUI.DTO
{
    public class FilmDto
    {
        public int count { get; set; }
        public List<FilmData> results { get; set; }
    }

    public class FilmData
    {
        public string title { get; set; }
        public int episode_id { get; set; }
        public string opening_crawl { get; set; }
        public string director { get; set; }
        public string producer { get; set; }
        public string release_date { get; set; }
        public DateTime created { get; set; }
        public DateTime edited { get; set; }
        public string url { get; set; }
    }
}
