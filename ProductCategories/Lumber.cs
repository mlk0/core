namespace Bridge.ProductCategories
{
    public class Lumber : Product
    {
        private int numberOfSoldItem;

        public Lumber(int numberOfSoldLumber)
        {
            this.numberOfSoldItem = numberOfSoldLumber;
        }

        public int NumberOfSoldLumber { get { return this.numberOfSoldItem; } }

        public decimal GetCommission(){
            decimal comission = 0;
            if(this.numberOfSoldItem < 20){
                comission = 2.13m;
            }
            else{
                if(this.numberOfSoldItem < 300){
                    comission = 4.1m;
                }
                else{
                    comission = 6m;
                }
            }
            return comission;
        }
    }
}