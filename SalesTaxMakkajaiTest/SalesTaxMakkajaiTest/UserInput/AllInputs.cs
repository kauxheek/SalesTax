using System;


namespace SalesTaxMakkajaiTest.UserInput
{
    class AllInputs
    {
        public string InputItem()
        {
            bool tryAgain = true;
            string ItemName = "";
            while (tryAgain)
            {
                try
                {
                    ItemName   = Console.ReadLine();
                    tryAgain = false;
                    
                }
                catch
                {
                    Console.WriteLine("Wrong input. Please Try Again...");
                }

                
            }
            return ItemName;
        }

        public int InputQuanity()
        {
            bool tryAgain = true;
            int itemQuantity = 0;
            while (tryAgain)
            {
                try
                {
                    itemQuantity = int.Parse(Console.ReadLine());
                    tryAgain = false;

                }
                catch
                {
                    Console.WriteLine("Wrong input. Please Try Again...");
                }


            }
            return itemQuantity;
        }


        public double InputPrice()
        {
            bool tryAgain = true;
            double inputPrice = 0;
            while (tryAgain)
            {
                try
                {
                    inputPrice = double.Parse(Console.ReadLine());
                    tryAgain = false;

                }
                catch
                {
                    Console.WriteLine("Wrong input. Please Try Again...");
                }


            }
            return inputPrice;
        }

        public bool InputYesNo()
        {
           
            ConsoleKeyInfo key = Console.ReadKey();

            if(key.Key == ConsoleKey.Y)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
