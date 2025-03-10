﻿using Rewards.Contract;
using System;
using System.Collections.Generic;

namespace Rewards.Business
{
    public interface IBal
    {
        Int64 CalculateRewardPoints(string spentMoney);
        List<CustomerMonthlyWise> CustomerRewardsReport();
    }
}
