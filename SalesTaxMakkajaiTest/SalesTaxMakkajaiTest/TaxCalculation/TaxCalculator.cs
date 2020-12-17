using System;

namespace SalesTaxMakkajaiTest.TaxCalculation
{
    class TaxCalculator
    {
       
        public double SalesTax { get;}
        public double ItemPrice { get;}
        
        public TaxCalculator(double inputprice, double Tax)
        {
            SalesTax = Math.Ceiling(Tax * inputprice / 100 * 20) / 20;
            ItemPrice = inputprice+ SalesTax;

        }
    
       
    }
}
