using System;
using System.Collections.Generic;
using SalesTaxMakkajaiTest.TaxCalculation;

namespace SalesTaxMakkajaiTest.Items
{
    class CartStorage
    {
        private double ItemPriceWithTax;
        private double ItemTax;
        private string Imported;
        private readonly Dictionary<string, ItemProperty> ItemStore;

        public CartStorage()
        {
            ItemStore = new Dictionary<string, ItemProperty>
            {
                { "book", new BookItems() },
                { "chocolate bar", new FoodItems() },
                { "box of chocolates", new FoodItems() },
                { "packet of headache pills", new MedicalItems() },
                { "bottle of perfume", new OtherItems() },
                { "music CD", new OtherItems() }
            };

        }

        public Tuple<double,double> CartProcess(string itemName, int quantity, bool isImported, double itemPrice)
        {
            try
            {
                ItemProperty item = ItemStore[itemName].Getcat(quantity, isImported, itemPrice);
                TaxCalculator calculator = new TaxCalculator(item.ItemPrice, item.TaxCalculate());
                ItemPriceWithTax = calculator.ItemPrice;
                ItemTax = calculator.SalesTax;
                Imported = item.Imported();
                Console.WriteLine(quantity + " " + Imported + " " + itemName + " @" + " " + ItemPriceWithTax);
            }

            catch (KeyNotFoundException)
            {
                Console.WriteLine(itemName + " NotFound");
            }           
            return Tuple.Create(ItemPriceWithTax, ItemTax);
        }
        

    }
}
