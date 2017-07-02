namespace Bridge.ProductCategories
{
    public class ToolsCommissionCalculator : ICommissionCalculator
    {
        public decimal CalcuateCommision(int soldItems)
        {
            decimal commission = 0m;

            if (soldItems > 0)
            {

                if (soldItems < 100)
                {
                    commission = 4.56m;
                }
                else
                {
                    if (soldItems < 500)
                    {
                        commission = 7.85m;
                    }
                    else
                    {
                        if (soldItems < 1000)
                        {
                            commission = 11.39m;
                        }
                        else
                        {
                            commission = 15m;
                        }
                    }
                }


            }

            return commission;
        }
    }


}