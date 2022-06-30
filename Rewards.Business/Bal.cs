using Newtonsoft.Json;
using Rewards.Contract;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Rewards.Business
{
    public class Bal : IBal
    {
        public long CalculateRewardPoints(string spentMoney)
        {
            long points = 0;
            try
            {
                decimal money = decimal.Parse(spentMoney);
                long spentMoneyTemp = (long)money;
                if (spentMoneyTemp > 50 && spentMoneyTemp <= 100)
                {
                    points = spentMoneyTemp * 1;
                }
                if (spentMoneyTemp > 100)
                {
                    points = (spentMoneyTemp - 50) * 1 + (spentMoneyTemp - 100) * 1;
                }
                return points;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                throw;
            }
        }


        public List<CustomerMonthlyWise> CustomerRewardsReport()
        {
            Customer customerdata = ReadDatafromJson();
            //Calculate reward points based on amount
            customerdata.Customers.ForEach(x =>
            {
                x.Rewards = CalculateRewardPoints(x.Amount);
            });
            //Group by month and get total rewards
            List<CustomerMonthlyWise> customermonthlyresult = customerdata.Customers.GroupBy(x => new { x.Name, x.TransactionDate.Month }, (key, group) => new CustomerMonthlyWise()
            {
                Name = key.Name,
                Month = CultureInfo.CurrentCulture.DateTimeFormat.GetAbbreviatedMonthName(key.Month),
                TransactionCount = group.Count(),
                TotalRewards = group.Sum(k => k.Rewards),
                Customers = group.OrderBy(g => g.TransactionDate).ToList()
            }).Reverse().ToList();

            return customermonthlyresult;
        }

        private Customer ReadDatafromJson()
        {
            Customer customer = null;
            using (StreamReader r = new StreamReader("Resources/CustomerData.json"))
            {
                string json = r.ReadToEnd();
                customer = JsonConvert.DeserializeObject<Customer>(json);
            }
            return customer;
        }

    }
}
