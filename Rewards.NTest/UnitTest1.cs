using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using Rewards.API.Models;
using Rewards.API.RewardPointsAPI;
using Rewards.Business;
using System;

namespace Rewards.NTest
{
    [TestFixture]
    public class Tests
    {
        Mock<IBal> _iBal;


        [TestCase("120", 90)]
        [TestCase("130", 110)]
        [TestCase("280", 410)]
        [TestCase("-230", 0)]
        [TestCase("0", 0)]
        [TestCase("175.7", 200)]
        [TestCase(null, 0)]
        public void CalculateRewardPoints_With_ReturnsOk(string money, long expectedResult)
        {
            _iBal = new Mock<IBal>(MockBehavior.Strict);
            _iBal.Setup(p => p.CalculateRewardPoints(money)).Returns(expectedResult);
            var loggermock = new Mock<ILogger<RewardsController>>();
            var rewardsController = new RewardsController(_iBal.Object, loggermock.Object);
            var result = rewardsController.CalculateRewardPoints(money);
            var okResult = result as OkObjectResult;
            RewardPoints model = okResult.Value as RewardPoints;
            Assert.AreEqual(expectedResult, model.Points);
        }
        [TestCase("qwerty")]
        public void CalculateRewardPoints_With_BadRequest(string money)
        {
            _iBal = new Mock<IBal>(MockBehavior.Strict);
            _iBal.Setup(p => p.CalculateRewardPoints(money)).Throws(new FormatException());
            var loggermock = new Mock<ILogger<RewardsController>>();
            var rewardsController = new RewardsController(_iBal.Object, loggermock.Object);
            Assert.Throws<FormatException>(() => rewardsController.CalculateRewardPoints(money));
        }
    }
}