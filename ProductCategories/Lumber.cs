using System;

namespace Bridge.ProductCategories
{
    public class Lumber : IProduct
    {
        private int numberOfSoldItems;

        public Lumber(int numberOfSoldLumber)
        {
            this.numberOfSoldItems = numberOfSoldLumber;
        }

        public int NumberOfSoldLumber { get { return this.numberOfSoldItems; } }

        public string Name { get; set; }
        public decimal GetCommission()
        {
            decimal comission = 0;
            if (this.numberOfSoldItems < 20)
            {
                comission = 2.13m;
            }
            else
            {
                if (this.numberOfSoldItems < 300)
                {
                    comission = 4.1m;
                }
                else
                {
                    comission = 6m;
                }
            }
            return comission;
        }

        public decimal GetCommission(ICommissionCalculator commissionCalculator)
        {
            return commissionCalculator.CalcuateCommision(this.numberOfSoldItems);
        }
    }
}