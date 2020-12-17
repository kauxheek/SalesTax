using System;
using System.Collections.Generic;
using SalesTaxMakkajaiTest.Items;
namespace SalesTaxMakkajaiTest.Receipt
{
    class AddToCart                                                                         
    {

        private List<string> Item;
        private List<int> Quantity;
        private List<double> InputPrice;
        private List<bool> IsImported;
        
        public AddToCart()
        {
            Item = new List<string>();
            Quantity = new List<int>();
            InputPrice = new List<double>();
            IsImported = new List<bool>();

        }
        public void Additem(string items,int quantity,double inputPrice, bool isImported)
        {
           
            Item.Add(items);
            Quantity.Add(quantity);
            InputPrice.Add(inputPrice);
            IsImported.Add(isImported);
        }

        public void Checkout()
        {
            double totalPrice=0;
            double totalTax=0;
                    
            for (int i = 0; i < Item.Count; i++)
            {
                CartStorage item = new CartStorage();
                var gettax = item.CartProcess(Item[i], Quantity[i], IsImported[i], InputPrice[i]);
                totalPrice += gettax.Item1;
                totalTax += gettax.Item2;              
            }

            Console.WriteLine("Total Price: " + totalPrice);
            Console.WriteLine("Total Sales Tax: " + totalTax);          
        }
    }
}
