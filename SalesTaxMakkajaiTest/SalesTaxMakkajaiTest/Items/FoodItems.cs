

namespace SalesTaxMakkajaiTest.Items
{
    class FoodItems:ItemProperty
    {
        public FoodItems() : base()
        {
        }
        public FoodItems(int quantity, bool isImported, double itemPrice) : base(quantity, isImported, itemPrice)
        {
        }

        public override ItemProperty Getcat( int quantity, bool isImported, double itemPrice)
        {
            return new FoodItems(quantity,isImported,itemPrice);
        }

    }
}
