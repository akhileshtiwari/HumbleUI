using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HumbleUI
{
    public class Service
    {
        internal static IDictionary<int, string> GetCountries()
        {
            var countries = new Dictionary<int, string>(3);

            countries.Add(1, "USA");
            countries.Add(2, "India");
            countries.Add(3, "China");
            countries.Add(4, "Brazil");

            return countries;
        }

        internal static IDictionary<int, string> GetRegions()
        {
            var regions = new Dictionary<int, string>(3);
            regions.Add(1, "America");
            regions.Add(2, "Asia");
            return regions;
        }

        internal static IDictionary<int,string> GetProductCatalog(IList<int> countryIds)
        {
            var products = new Dictionary<int, string>(3);

            products.Add(1, "Birthday Cake");
            products.Add(2, "Cup Cake");
            products.Add(3, "Muffins");
            products.Add(4, "Choco Cake");

            return products;
        }

        internal static IDictionary<int, string> GetFilteredCountries(int regionId)
        {
            var countries = new Dictionary<int, string>(3);

            if (regionId == 1)
            {
                countries.Add(1, "USA");
                countries.Add(4, "Brazil");
            }
            else
            {
                countries.Add(2, "India");
                countries.Add(3, "China");
            }

            return countries;
        }
    }
}