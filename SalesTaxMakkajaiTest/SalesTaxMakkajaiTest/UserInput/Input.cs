using System;
using SalesTaxMakkajaiTest.Receipt;

namespace SalesTaxMakkajaiTest.UserInput
{
    class Input
    {
        AddToCart cart = new AddToCart();  
        AllInputs inputs = new AllInputs();
        public string item;
        public int quantity;
        public bool isImported;
        public double itemPrice;
       
        public void UserInput()
        {

            
            Console.WriteLine("Enter product name");
            item = inputs.InputItem();
            Console.WriteLine("Enter product quantity");
            quantity = inputs.InputQuanity();
            Console.WriteLine("\nIs the item imported? Press Y for YES or press any key for NO");
            isImported = inputs.InputYesNo();
            Console.WriteLine("\nEnter product price:");
            itemPrice = inputs.InputPrice();

            cart.Additem(item,quantity,itemPrice,isImported);

            Console.WriteLine("\nPress C for checkout or press any key to add another item");

            if (Console.ReadKey().Key == ConsoleKey.C)
            {
                Console.WriteLine("\n");
                cart.Checkout();
                
            }
            else
            {
                
                Console.WriteLine("\n");             
                UserInput();
                
            }           
                     
        }

       
    }
}