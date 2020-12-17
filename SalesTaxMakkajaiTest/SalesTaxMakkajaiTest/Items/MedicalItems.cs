

namespace SalesTaxMakkajaiTest.Items
{
    class MedicalItems:ItemProperty
    {

        public MedicalItems() : base()
        {

        }

        public MedicalItems( int quantity, bool isImported, double itemPrice) : base(quantity, isImported, itemPrice)
        {

        }

        public override ItemProperty Getcat(int quantity, bool isImported, double itemPrice)
        {
            return new MedicalItems( quantity, isImported, itemPrice);
        }


    }
}
