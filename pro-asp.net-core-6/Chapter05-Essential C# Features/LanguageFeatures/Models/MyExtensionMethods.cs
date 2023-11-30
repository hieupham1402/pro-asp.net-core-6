﻿using System.Runtime.CompilerServices;

namespace LanguageFeatures.Models
{
    public static class MyExtensionMethods
    {
        public static decimal TotalPrices(this IEnumerable<Product?> products)
        {
            decimal total = 0;
            foreach (Product? prod in products)
            {
                total += prod?.Price ?? 0;
            }
            return total;
        }
    }
}
