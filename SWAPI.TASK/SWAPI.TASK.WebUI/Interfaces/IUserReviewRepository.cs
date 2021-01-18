using SWAPI.TASK.WebUI.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SWAPI.TASK.WebUI.Interfaces
{
    public interface IUserReviewRepository
    {
        Task<List<UserReview>> GetMovieVotes(int movieId);
        Task SaveUserVote(UserReview userReview);
    }
}
