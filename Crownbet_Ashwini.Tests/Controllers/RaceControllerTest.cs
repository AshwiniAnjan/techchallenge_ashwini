using Crownbet_Ashwini.Helpers;
using Crownbet_Common;
using Crownbet_Web.Controllers;
using CrownbetModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;

namespace Crownbet_Ashwini.Tests.Controllers
{
    [TestClass]
    public class RaceControllerTest
    {
        [TestMethod]
        public void RaceControllerGetRaces_NameEmpty_ThrowError()
        {
            var _raceHelperTest = new Mock<IRaceHelper>().Object;
            var _logHelperTest = new Mock<ILogger>().Object;

            RaceController raceController = new RaceController(_raceHelperTest, _logHelperTest);
            StandardResponse response = raceController.GetRaces();

            var resultResponse = (ErrorRespose)response.Response;
            Assert.AreEqual(resultResponse.ErrorReason, "Name is Empty");
        }

        [TestMethod]
        public void RaceControllerGetRaces_GetRaces_ReturnRaces()
        {
            var _raceHelperTest = new Mock<IRaceHelper>();
            var _logHelperTest = new Mock<ILogger>();

            StandardResponse response = new StandardResponse();
            var raceList = new List<Race>();
            raceList.Add(new Race {Id = 1,Name ="Melbourne Cup", Stake=100,Status="Pending"});
            response.Response = raceList;

            _raceHelperTest.Setup(race => race.GetRaces()).Returns(response);

            RaceController raceController = new RaceController(_raceHelperTest.Object, _logHelperTest.Object);
            StandardResponse helperResponse = raceController.GetRaces("ashwini");

            var resultRace = (List<Race>)helperResponse.Response;
            Assert.AreEqual(resultRace.Count, 1);
        }

        [TestMethod]
        public void RaceControllerGetCustomers_NameEmpty_ThrowError()
        {
            var _raceHelperTest = new Mock<IRaceHelper>().Object;
            var _logHelperTest = new Mock<ILogger>().Object;

            RaceController raceController = new RaceController(_raceHelperTest, _logHelperTest);
            StandardResponse response = raceController.GetCustomers();

            var resultResponse = (ErrorRespose)response.Response;
            Assert.AreEqual(resultResponse.ErrorReason, "Name is Empty");
        }

        [TestMethod]
        public void RaceControllerGetCustomers_ReturnCustomers()
        {
            var _raceHelperTest = new Mock<IRaceHelper>();
            var _logHelperTest = new Mock<ILogger>();

            StandardResponse response = new StandardResponse();

            var customerList = new List<Customer>();
            customerList.Add(new Customer { Id = 1, Name = "Ashwini", BetAmount = 100, BetCount = 2, RiskIndicator = true });
            response.Response = customerList;

            _raceHelperTest.Setup(race => race.GetCustomers()).Returns(response);

            RaceController raceController = new RaceController(_raceHelperTest.Object, _logHelperTest.Object);
            StandardResponse helperResponse = raceController.GetCustomers("ashwini");

            var resultRace = (List<Customer>)helperResponse.Response;
            Assert.AreEqual(resultRace.Count, 1);
        }

        [TestMethod]
        public void RaceControllerGetBets_NameEmpty_ThrowError()
        {
            var _raceHelperTest = new Mock<IRaceHelper>().Object;
            var _logHelperTest = new Mock<ILogger>().Object;

            RaceController raceController = new RaceController(_raceHelperTest, _logHelperTest);
            StandardResponse response = raceController.GetBets();

            var resultResponse = (ErrorRespose)response.Response;
            Assert.AreEqual(resultResponse.ErrorReason, "Name is Empty");
        }

        [TestMethod]
        public void RaceControllerGetBets_ReturnTotalBet()
        {
            var _raceHelperTest = new Mock<IRaceHelper>();
            var _logHelperTest = new Mock<ILogger>();

            StandardResponse response = new StandardResponse();

            var totalBet = new TotalBets();
            totalBet.TotalAmount = 100;

            response.Response = totalBet;

            _raceHelperTest.Setup(race => race.GetBets()).Returns(response);

            RaceController raceController = new RaceController(_raceHelperTest.Object, _logHelperTest.Object);
            StandardResponse helperResponse = raceController.GetBets("ashwini");

            var result = (TotalBets)helperResponse.Response;
            Assert.AreEqual(result.TotalAmount, 100);
        }
    }
}
