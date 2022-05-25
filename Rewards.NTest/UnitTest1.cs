using NUnit.Framework;
using Rewards.Business;

namespace Rewards.NTest
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        private Bal bal = new Bal();

        [Test]
        public void CalculateRewardPoints()
        {
            Assert.AreEqual(90, bal.CalculateRewardPoints(120));
            Assert.AreEqual(110, bal.CalculateRewardPoints(130));
            Assert.AreEqual(410, bal.CalculateRewardPoints(280));
        }

        [Test]
        public void CalculateRewardPointsIsnotEqual()
        {
            Assert.AreNotEqual(100, bal.CalculateRewardPoints(120));
            
        }
    }
}