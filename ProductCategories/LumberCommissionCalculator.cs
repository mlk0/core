namespace Bridge.ProductCategories
{
    public class LumberCommissionCalculator : ICommissionCalculator
    {
        public decimal CalcuateCommision(int soldItems)
        {
            decimal comission = 0m;

            if (soldItems > 0)
            {
                if (soldItems < 20)
                {
                    comission = 2.13m;
                }
                else
                {
                    if (soldItems < 300)
                    {
                        comission = 4.1m;
                    }
                    else
                    {
                        comission = 6m;
                    }
                }
            }

            return comission;
        }
    }


}