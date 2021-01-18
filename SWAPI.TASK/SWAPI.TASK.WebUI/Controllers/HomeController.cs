using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using SWAPI.TASK.WebUI.Domain;
using SWAPI.TASK.WebUI.DTO;
using SWAPI.TASK.WebUI.Interfaces;
using SWAPI.TASK.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace SWAPI.TASK.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserReviewRepository _userReviewRepository;

        public HomeController(IUserReviewRepository userReviewRepository)
        {
            _userReviewRepository = userReviewRepository;
        }

        public IActionResult Index()
        {
            HomeViewModel model = new HomeViewModel();
            string url = $"https://swapi.dev/api/films/";
            FilmDto filmDto = FetchSwapiData<FilmDto>(url);

            model.FilmDto = filmDto;
            return View(model);
        }

        [HttpGet]
        public IActionResult FilmDetails(string url)
        {
            FilmDetailsViewModel model = new FilmDetailsViewModel();
            FilmDetailsDto result = FetchSwapiData<FilmDetailsDto>(url);
            model.FilmDetailsDto = result;

            List<UserReview> reviews = _userReviewRepository.GetMovieVotes(result.episode_id).Result;
            List<UserReviewDto> rewiesDto = new List<UserReviewDto>();
            
            if(reviews != null)
            {
                foreach (UserReview review in reviews)
                {
                    rewiesDto.Add(new UserReviewDto()
                    {
                        EpisodeId = review.EpisodeId,
                        Url = review.Url,
                        UserRating = review.UserRating,
                        VoteDate = review.VoteDate
                    });
                }
            }

            model.FilmReviewsDto = rewiesDto;

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> SendVoteValue(string url, int selectedUserVote, int episode_id)
        {
            UserReview review = new UserReview()
            {
                EpisodeId = episode_id,
                Url = url,
                UserRating = selectedUserVote,
                VoteDate = DateTime.Now
            };

            await _userReviewRepository.SaveUserVote(review);

            return RedirectToAction("Index", "");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private static T1 FetchSwapiData<T1>(string url)
        {
            HttpClient client = new HttpClient();
            var response = client.GetAsync(url).Result;
            string content = response.Content.ReadAsStringAsync().Result;
            var result = JsonConvert.DeserializeObject<T1>(content);
            return result;
        }
    }
}
