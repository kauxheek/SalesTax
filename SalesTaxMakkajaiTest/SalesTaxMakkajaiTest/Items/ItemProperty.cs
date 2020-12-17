

namespace SalesTaxMakkajaiTest.Items
{
    public abstract class ItemProperty
    {

        private int Quantity { get; }
        public bool IsImported { get; }
        private double price;
        public double ItemPrice
        {
            private set { price = value; }
            get { return price * Quantity; }
        }

        public ItemProperty()
        {

            Quantity = 0;
            IsImported = false;
            ItemPrice =0;

        }


        public ItemProperty( int quantity, bool isImported, double itemPrice)
        {

            Quantity = quantity;
            IsImported = isImported;
            ItemPrice = itemPrice;

        }
        

        public virtual float TaxCalculate()
        {
            float tax = 0f;
            if(IsImported == true)
            {
                tax = 5f;
            }
            return tax;
        }

        public string Imported()
        {
            if(IsImported == true)
            {
                return "imported";
            }
            return "";

        }


        public abstract ItemProperty Getcat( int quantity, bool isImported, double itemPrice);

        
    }
}
