using System.Collections.Generic;

namespace Rewards.Contract
{
    public class CustomerMonthlyWise
    {
        public CustomerMonthlyWise()
        {
            Customers = new List<CustomerModel>();
        }

        public string Name { get; set; }
        public string Month { get; set; }
        public long TransactionCount { get; set; }
        public double TotalRewards { get; set; }
        public List<CustomerModel> Customers { get; set; }

    }
}
