namespace Bridge.ProductCategories
{
    public class DefaultCommisionCalculator : ICommissionCalculator
    {
        public decimal CalcuateCommision(int soldItems)
        {
            decimal commision = 0m;

            if (soldItems > 0)
            {
                if (soldItems < 1000)
                {
                    commision = soldItems / 100;
                }
                else
                {
                    commision = 15;
                }
            }

            return commision;
        }
    }


}