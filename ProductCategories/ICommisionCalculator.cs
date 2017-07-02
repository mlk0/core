using System;

namespace Bridge.ProductCategories
{
    public interface ICommissionCalculator
    {
        decimal CalcuateCommision(int soldItems);
    }
}