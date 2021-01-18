using Microsoft.AspNetCore.Mvc;
using Moq;
using SWAPI.TASK.WebUI.Controllers;
using SWAPI.TASK.WebUI.DTO;
using SWAPI.TASK.WebUI.Infrastructure.Repository;
using SWAPI.TASK.WebUI.Interfaces;
using SWAPI.TASK.WebUI.Models;
using System.Collections.Generic;
using Xunit;

namespace SWAPI.TASK.Tests
{
    public class SwapiTests
    {
        [Fact]
        public void Calling_HomeController_Index_Method_Should_Return_Model_With_Swapi_Values()
        {
            //Arrange
            var mockRepository = new Mock<IUserReviewRepository>();
            var newSession = new HomeController(mockRepository.Object);

            //Act
            var response = newSession.Index();

            //Assert
            var viewResult = Assert.IsType<ViewResult>(response);
            var model = Assert.IsAssignableFrom<HomeViewModel>(viewResult.ViewData.Model);
            Assert.Equal(6, model.FilmDto.count);
        }

        [Fact]
        public void Fetching_Swapi_Should_Return_Movie_Details()
        {
            //Arrange
            var mockRepository = new Mock<IUserReviewRepository>();
            var newSession = new HomeController(mockRepository.Object);
            string url = "http://swapi.dev/api/films/2/";

            //Act
            var response = newSession.FilmDetails(url);

            //Assert
            var viewResult = Assert.IsType<ViewResult>(response);
            var model = Assert.IsAssignableFrom<FilmDetailsViewModel>(viewResult.ViewData.Model);
            Assert.IsAssignableFrom<FilmDetailsDto>(model.FilmDetailsDto);
            Assert.Equal(url, model.FilmDetailsDto.url);
        }

        //Fetch_Swapi_Films_Endpoint_Should_Return_Correct_Response()
    }
}
