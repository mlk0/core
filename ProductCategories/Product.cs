namespace Bridge.ProductCategories
{

    public class Product
    {
        public string Name {get;set;}

        public virtual decimal GetCommission(ICommissionCalculator commissionCalculator)
        {
            return 0m;
        }
    }


}