namespace Bridge.ProductCategories
{
    public interface IProduct{
        string Name {get;set;}
        decimal GetCommission(ICommissionCalculator commissionCalculator);

    }


}