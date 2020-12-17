

namespace SalesTaxMakkajaiTest.Items
{
    class BookItems : ItemProperty
    {
        public BookItems() : base()
        {

        }
        public BookItems(int quantity, bool isImported,double itemPrice) : base(quantity, isImported, itemPrice)
        {

        }
        public override ItemProperty Getcat(int quantity, bool isImported, double itemPrice)
        {
            return new BookItems(quantity,isImported,itemPrice);
        }
       
    }
}
