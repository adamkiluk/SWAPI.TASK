using Microsoft.EntityFrameworkCore;
using SWAPI.TASK.WebUI.Domain;
using SWAPI.TASK.WebUI.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWAPI.TASK.WebUI.Infrastructure.Repository
{
    public class UserReviewRepository : Repository<UserReview>, IUserReviewRepository
    {
        public UserReviewRepository(SwapiDbContext context) : base(context)
        {

        }

        public async Task<List<UserReview>> GetMovieVotes(int movieId)
        {
            return await base._context.UserReviews.Where(x => x.EpisodeId == movieId).ToListAsync();
        }

        public async Task SaveUserVote(UserReview userReview)
        {
            await base._context.UserReviews.AddAsync(userReview);
            await _context.SaveChangesAsync();
        }
    }
}
