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


    public class ProductBridge{
        protected ICommissionCalculator commissionCalculator;

        public ProductBridge(ICommissionCalculator commissionCalculator)
        {
            this.commissionCalculator = commissionCalculator;
        }

        public virtual decimal GetCommission(){
            return commissionCalculator.CalcuateCommision(SoldItems);
        }

        public int SoldItems {get;set;}
    }

    public class ToolBridge : ProductBridge
    {
        public ToolBridge(ICommissionCalculator commissionCalculator) : base(commissionCalculator)
        {
        }

        public override decimal GetCommission()
        {
            return base.commissionCalculator.CalcuateCommision(base.SoldItems/10);
        }
    }

    public class LumberBridge : ProductBridge
    {
        public int ReturnedItems {get;set;}
        public LumberBridge(ICommissionCalculator commissionCalculator) : base(commissionCalculator)
        {
        }


        public override decimal GetCommission()
        {
            return base.commissionCalculator.CalcuateCommision(base.SoldItems - this.ReturnedItems);
        }
    }

}