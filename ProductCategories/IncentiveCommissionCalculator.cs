namespace Bridge.ProductCategories
{
    public class IncentiveCommissionCalculator : ICommissionCalculator
    {
        public decimal CalcuateCommision(int soldItems)
        {
            decimal comission = 0m;

            if (soldItems > 0)
            {
                if (soldItems < 500)
                {
                    comission = 5;
                }
                else
                {
                    comission = 15;
                }
            }

            return comission;
        }
    }
}