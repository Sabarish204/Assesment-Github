using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Rewards.API.Models;
using Rewards.Business;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Rewards.API.RewardPointsAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class RewardsController : ControllerBase
    {
        private readonly IBal _iBal;
        protected readonly ILogger<RewardsController> _logger;
        public RewardsController(IBal ibal, [NotNull] ILogger<RewardsController> logger)
        {
            _iBal = ibal;
            _logger = logger;
        }

       

        [HttpGet("CalculateRewardPoints/{spentMoney}")]
        public IActionResult CalculateRewardPoints(string spentMoney)
        {
            _logger.LogInformation("Running endpoint {endpoint} {verb}", "/api/Rewards", "GET");
            try
            {
              
                long points = _iBal.CalculateRewardPoints(spentMoney);
                RewardPoints pts = new RewardPoints() { Points = points };
                return Ok(pts);
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                throw;
            }
        }
    }
}
