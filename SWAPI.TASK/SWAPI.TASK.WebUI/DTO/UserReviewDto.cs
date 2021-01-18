using System;

namespace SWAPI.TASK.WebUI.DTO
{
    public class UserReviewDto
    {
        public int EpisodeId { get; set; }
        public string Url { get; set; }
        public int UserRating { get; set; }
        public DateTime VoteDate { get; set; }
    }
}
