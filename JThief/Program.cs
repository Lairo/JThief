using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JThief
{
    internal class Program 
    {
        static void Main()
        {
            VendingMachine vendingMachine = new AnimalFeedVendingMachine();
            Console.WriteLine(vendingMachine.Dispense(2.50M));
        }
    }
}
