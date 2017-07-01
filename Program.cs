using System;

namespace core
{
    class Program
    {
        static void Main(string[] args)
        {
            var myThing = System.Environment.MachineName;
            var message = String.Format("Hi mirko at {0}", myThing);
            Console.WriteLine(message);
            


        }
    }
}
