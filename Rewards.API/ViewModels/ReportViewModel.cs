using Rewards.Contract;
using System.Collections.Generic;

namespace Rewards.API.ViewModels
{
    public class ReportViewModel
    {
        public ReportViewModel()
        {
            CustomerMonthlyList = new List<CustomerMonthlyWise>();
        }
        public List<CustomerMonthlyWise> CustomerMonthlyList { get; set; }
      
    }
}
