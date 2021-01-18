using SWAPI.TASK.WebUI.DTO;
using System.Collections.Generic;

namespace SWAPI.TASK.WebUI.Models
{
    public class FilmDetailsViewModel
    {
        public int SelectedUserVote { get; set; }
        public FilmDetailsDto FilmDetailsDto { get; set; }
        public List<UserReviewDto> FilmReviewsDto { get; set; }
    }
}
