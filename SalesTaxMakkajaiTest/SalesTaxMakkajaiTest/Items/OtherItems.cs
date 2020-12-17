
namespace SalesTaxMakkajaiTest.Items
{
    class OtherItems:ItemProperty
    {

        public OtherItems() : base(){

        }
        public OtherItems(int quantity, bool isImported, double itemPrice) : base(quantity, isImported, itemPrice)
        {

        }

        public override float TaxCalculate()
        {
            float tax = 10f;
            if (IsImported == true)
            {
                tax+=5f;
            }
            return tax;
        }

        public override ItemProperty Getcat( int quantity, bool isImported, double itemPrice)
        {
            return new OtherItems(quantity, isImported, itemPrice);
        }


    }
}
