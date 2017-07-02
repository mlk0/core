using System;
using Bridge.ProductCategories;

namespace core
{
    class Program
    {
        static void Main(string[] args)
        {
            var myThing = System.Environment.MachineName;
            var message = String.Format("Hi mirko at {0}", myThing);
            Console.WriteLine(message);
            
            Console.WriteLine("Bridge Pattern");
            Console.WriteLine("Set the number of sold tools ");
            Tool soldTools = null;
            var numberOfSoldToolsFromConsole =  Console.ReadLine();
            int numberOfSoldTools = 0;
            if(Int32.TryParse(numberOfSoldToolsFromConsole, out numberOfSoldTools)){
                soldTools = new Tool(numberOfSoldTools);
            } 
            else
            {
                Console.WriteLine("Invalid input - expected input was integer, 0 tools will be used instead");
                soldTools = new Tool(numberOfSoldTools);
            }


  
                Console.WriteLine("tool.GetCommission : {0} for {1} sold items", soldTools.GetCommission().ToString(), soldTools.NumberOfSoldTools.ToString());


            
             Console.WriteLine("Set the number of sold lumber");
            
             Lumber soldLumber = null;
             var numberOfSoldLumberFromConsole =  Console.ReadLine();
             int numberOfSoldLumber = 0;
            if(Int32.TryParse(numberOfSoldLumberFromConsole, out numberOfSoldLumber)){
                soldLumber = new Lumber(numberOfSoldLumber);
            } 
            else
            {
                Console.WriteLine("Invalid input - expected input was integer, 0 lumber will be used instead");
                soldLumber = new Lumber(numberOfSoldTools);
            }


           
           
            Console.WriteLine("lumber.GetCommission : {0} for {1} sold items", soldLumber.GetCommission().ToString(), soldLumber.NumberOfSoldLumber.ToString());
            Console.WriteLine("Implementation with ICommissionCalcuator passed to the GetCommissiion\r\n press key to continue ...");
            Console.ReadLine();

            soldTools.Name = "Tool";
            Console.WriteLine("Product : {0}, sold quantity : {1}, following is the commission calculation:", soldTools.Name, soldTools.NumberOfSoldTools);
            var defaultCommissionCalculator = new DefaultCommisionCalculator();
            var defaultToolCommission = soldTools.GetCommission(defaultCommissionCalculator);

            var incentiveCommissionCalculator = new IncentiveCommissionCalculator();
            var incetiveToolCommission = soldTools.GetCommission(incentiveCommissionCalculator);

            var toolsCommissionCalculator = new ToolsCommissionCalculator();
            var toolToolCommission = soldTools.GetCommission(toolsCommissionCalculator);

            Console.WriteLine("defaultToolCommission : {0}, incetiveToolCommission : {1}, toolToolCommission : {2}", defaultToolCommission, incetiveToolCommission, toolToolCommission);


            soldLumber.Name = "Lumber";
            Console.WriteLine("Product : {0}, sold quantity : {1}, following is the commission calculation:", soldLumber.Name, soldLumber.NumberOfSoldLumber);
            
            var defaultLumberCommission = soldTools.GetCommission(defaultCommissionCalculator);

            
            var incetiveLumberCommission = soldTools.GetCommission(incentiveCommissionCalculator);

            var lumberCommissionCalculator = new LumberCommissionCalculator();
            var lumberLumberCommission = soldTools.GetCommission(lumberCommissionCalculator);

            Console.WriteLine("defaultLumberCommission : {0}, incetiveLumberCommission : {1}, lumberLumberCommission : {2}",
             defaultLumberCommission, incetiveLumberCommission, lumberLumberCommission);


             var toolBridge = new ToolBridge(defaultCommissionCalculator);
             toolBridge.SoldItems = numberOfSoldTools;
             Console.WriteLine("toolBridge.SoldItem : {0}, defaultCommissionCalculator commission : {1}", toolBridge.SoldItems, toolBridge.GetCommission());
            
            var toolBridge2 = new ToolBridge(incentiveCommissionCalculator);
             toolBridge2.SoldItems = numberOfSoldTools;
             Console.WriteLine("toolBridge2.SoldItem : {0}, incentiveCommissionCalculator commission : {1}", toolBridge2.SoldItems, toolBridge2.GetCommission());

        }
    }
}
