using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_task_2
{
    class Invoice
    {
        private string account;
        private string customer;
        private string provider;

        public string Article { get; set; }
        public int Quantity { get; set; }

        public Invoice(string account, string custumer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;


        }
        public double CostCalculation(bool needEdv)
        {   double price = 1;
            double Edv = price * 0.18;

            if (Article=="laptop")
            {
                price = 1400;
            }
            else if (Article=="SD-card")
            {
                price = 30;
            }
            else
            {
                price = 12;
                Article ="usb" ;
            }
           

            if (needEdv)
            {
                price = price * Quantity + Edv;
            }
            else
            {
                price = price * Quantity;
            }
            return price;
        } 
    }
}
