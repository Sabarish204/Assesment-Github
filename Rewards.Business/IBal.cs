using System;

namespace Rewards.Business
{
    public interface IBal
    {
         Int64 CalculateRewardPoints(decimal spentMoney);
    }
}
