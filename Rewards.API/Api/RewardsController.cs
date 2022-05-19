using Microsoft.AspNetCore.Mvc;
using Rewards.API.Models;
using Rewards.Business;

namespace Rewards.API.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class RewardsController : ControllerBase
    {
        private readonly IBal _iBal;
        public RewardsController(IBal ibal)
        {
            _iBal = ibal;
        }

        [HttpGet("CalculateRewardPoints/{spentMoney}")]
        public IActionResult CalculateRewardPoints(decimal spentMoney)
        {
            try
            {

            }
            catch (System.DivideByZeroException)
            {

                throw;
            }
            catch (System.Exception)
            {

                throw;
            }
            long points = _iBal.CalculateRewardPoints(spentMoney);
            RewardPoints pts = new RewardPoints() { Points = points };
            return Ok(pts);
        }
    }
}
