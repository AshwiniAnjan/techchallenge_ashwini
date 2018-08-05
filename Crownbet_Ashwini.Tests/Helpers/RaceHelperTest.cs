using Crownbet_Ashwini.Helpers;
using Crownbet_Common;
using Crownbet_Databse;
using Crownbet_Web.Controllers;
using CrownbetModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crownbet_Ashwini.Tests.Helpers
{
    [TestClass]
    public class RaceHelperTest
    {
        [TestMethod]
        public void RaceControllerGetRaces()
        {
            var _raceDBTest = new Mock<IRaceDBConnector>();
            var _logHelperTest = new Mock<ILogger>().Object;
            AutoMapperConfig.Initialize();

            _raceDBTest.Setup(race => race.GetRaces()).Returns(new List<SP_GetRaceDetails_Result>());
            var _raceHelperTest = new RaceHelper(_raceDBTest.Object, _logHelperTest);
            RaceController raceController = new RaceController(_raceHelperTest,_logHelperTest);
            StandardResponse response = raceController.GetRaces("Ashwini");

            var helperResponse = (List<Race>)response.Response;
            Assert.AreEqual(helperResponse.Count,0);
        }

        [TestMethod]
        public void RaceControllerGetBets()
        {
            var _raceDBTest = new Mock<IRaceDBConnector>();
            var _logHelperTest = new Mock<ILogger>().Object;
            AutoMapperConfig.Initialize();

            _raceDBTest.Setup(race => race.GetBets()).Returns(10);
            var _raceHelperTest = new RaceHelper(_raceDBTest.Object, _logHelperTest);
            RaceController raceController = new RaceController(_raceHelperTest, _logHelperTest);
            StandardResponse response = raceController.GetBets("Ashwini");

            var helperResponse = (TotalBets)response.Response;
            Assert.AreEqual(helperResponse.TotalAmount, 10);
        }

        [TestMethod]
        public void RaceControllerGetCustomers()
        {
            var _raceDBTest = new Mock<IRaceDBConnector>();
            var _logHelperTest = new Mock<ILogger>().Object;
            AutoMapperConfig.Initialize();

            _raceDBTest.Setup(race => race.GetCustomer()).Returns(new List<SP_GetCustomerDetails_Result>());
            var _raceHelperTest = new RaceHelper(_raceDBTest.Object, _logHelperTest);
            RaceController raceController = new RaceController(_raceHelperTest, _logHelperTest);
            StandardResponse response = raceController.GetCustomers("Ashwini");

            var helperResponse = (List<Customer>)response.Response;
            Assert.AreEqual(helperResponse.Count, 0);
        }
    }
}
