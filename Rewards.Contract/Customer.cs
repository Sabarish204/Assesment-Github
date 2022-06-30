using System;
using System.Collections.Generic;

namespace Rewards.Contract
{
    public class Customer
    {
        public List<CustomerModel> Customers { get; set; }
    }
    public class CustomerModel
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Amount { get; set; }
        public DateTime TransactionDate { get; set; }
        public double Rewards { get; set; }
    }
}
