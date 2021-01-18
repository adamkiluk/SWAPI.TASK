using SWAPI.TASK.WebUI.DTO;

namespace SWAPI.TASK.WebUI.Models
{
    public class HomeViewModel
    {
        public string url { get; set; }
        public int movieId { get; set; }
        public FilmDto FilmDto { get; set; }
    }
}
