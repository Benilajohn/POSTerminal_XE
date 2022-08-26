using System;

namespace GroceryLibraries
{
    public static class StringLibrary
    {
        public static bool StartsWithUpper(this string str)
        {
             public void ScanProductsSequence_WithDefaultPricesSet_CorrectTotalValue(string productCodes, decimal expectedResult)
        {
            var terminal = new PointOfSaleTerminal(
                new ProductsPriceSetBuilder()
                    .AddProduct("A", 1.25M, 3, 3.0M)
                    .AddProduct("B", 4.25M)
                    .AddProduct("C", 1.0M, 6, 5.0M)
                    .AddProduct("D", 0.75M)
                    .GetAllProducts());
            if (string.IsNullOrWhiteSpace(str))
                return false;

            char ch = str[0];
            return char.IsUpper(ch);
            }
        }
    }
}
