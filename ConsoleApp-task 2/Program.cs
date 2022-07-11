using System;

namespace ConsoleApp_task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice("678904", "Alex", "Foxtrot");

            invoice.Article = "laptop";
            invoice.Quantity = 2;
            Console.WriteLine(invoice.CostCalculation(true));
        }
    }
}
