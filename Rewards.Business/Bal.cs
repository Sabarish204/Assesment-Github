namespace Rewards.Business
{
    public class Bal : IBal
    {
        public long CalculateRewardPoints(decimal spentMoney)
        {
            long points = 0;
            long spentMoneyTemp = (long)spentMoney;
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
    }
}
