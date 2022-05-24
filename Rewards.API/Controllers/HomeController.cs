using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Rewards.API.Models;
using Rewards.API.ViewModels;
using Rewards.Business;
using Rewards.Contract;
using System.Collections.Generic;
using System.Diagnostics;

namespace Rewards.API.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBal _iBal;
        public HomeController(ILogger<HomeController> logger, IBal ibal)
        {
            _logger = logger;
            _iBal = ibal;
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult CustomerRewardsReport()
        {
            List<CustomerMonthlyWise> data = _iBal.CustomerRewardsReport();
            ReportViewModel model = new ReportViewModel() { CustomerMonthlyList = data };
            return View(model);
        }
    }
}
