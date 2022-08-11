using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using TAL.DAL.Models;
using TAL.DAL.Repository;
using TAL.LoggerService;
using TAL.UnitTest.DBContext;
using TAL_API.Controllers;
using FluentAssertions;
using TAL.Common.Models;

namespace TAL.UnitTest.Controller
{

    public class MonthlyPremiumControllerTest
    {
        private MonthlyPremiumController _controller;
        private Mock<ILoggerManager> _ILoggerManager;
        private ITALRepository _repository;
        private TALDBContextMock _TALDBContextMock;

        [SetUp]
        public void Setup()
        {
            _ILoggerManager = new Mock<ILoggerManager>();
            _TALDBContextMock = new TALDBContextMock();         
        }

        [Test]
        public void Get_WhenCalled_ReturnsOkResult()
        {
            //SetUp
            _repository = new TALRepository(_TALDBContextMock.MockDBContext());
            _controller = new MonthlyPremiumController(_ILoggerManager.Object, _repository);

            var mockObject = new Occupation
            {
                OccupationId = 2,
                OccupationName = Constants.TAL_DAL_Entity_Occupations_Doctor,
                OccupationRatingRefId = 1,
                OccupationRating =
               new OccupationRating
               {
                   OccupationRatingId = 1,
                   OccupationRatingName = Constants.TAL_DAL_Entity_OccupationRating_Professional,
                   Factor = 1.0M
               }
            };

            // Act
            var okResult = _controller.Get();

            // Assert
            var result = okResult as OkObjectResult;
            var resultVal = result.Value as List<Occupation>;

            Assert.True(resultVal.Count == 6);
            var occupation = resultVal.FirstOrDefault(a => a.OccupationId == 2);

            occupation.Should().BeEquivalentTo(mockObject);

        }

        [Test]
        public void Get_WhenCalled_ReturnsException()
        {
            //SetUp
            _repository = null;
            _controller = new MonthlyPremiumController(_ILoggerManager.Object, _repository);

            // Act
            Assert.Throws<NullReferenceException>(() => _controller.Get());

        }

    }
}

