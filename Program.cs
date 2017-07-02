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

        }
    }
}
