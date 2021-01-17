using System;
using System.ComponentModel.DataAnnotations;

namespace SWAPI.TASK.WebUI.Domain
{
    public class UserReview
    {
        [Key]
        public int Id { get; set; }
        public int EpisodeId { get; set; }
        public string Url { get; set; }
        public int UserRating { get; set; }
        public DateTime VoteDate { get; set; }
    }
}
