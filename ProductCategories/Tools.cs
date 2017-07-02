using System;

namespace Bridge.ProductCategories
{
    public class Tool : IProduct
    {
        private int numberOfSoldItems;

        public Tool(int numberOfSoldTools)
        {
            this.numberOfSoldItems = numberOfSoldTools;
        }

        public string Material { get; set; }
        public int NumberOfSoldTools { get { return this.numberOfSoldItems; } }

        public string Name { get; set; }

        public decimal GetCommission()
        {
            decimal commission = 0m;
            if (numberOfSoldItems < 100)
            {
                commission = 4.56m;
            }
            else {
                if(numberOfSoldItems < 500){
                    commission = 7.85m;
                }
                else{
                    if(numberOfSoldItems < 1000){
                        commission = 11.39m;
                    }
                    else {
                        commission = 15m;
                    }
                }
            }

            return commission;
        }

        public decimal GetCommission(ICommissionCalculator commissionCalculator)
        {
            return commissionCalculator.CalcuateCommision(this.numberOfSoldItems);
        }
    }
}
