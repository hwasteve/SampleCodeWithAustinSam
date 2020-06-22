using MyApi.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstApi.Service
{
    public class StoreService
    {
        /// <summary>
        /// Get the list of stores we have in the database
        /// </summary>
        /// <returns></returns>
        public List<Store> GetStores()
        {
            List<Store> stores = new List<Store>();

            Store s = new Store();
            s.Name = "Terp #2";
            s.Street = "Baltimore Pike";
            stores.Add(s);

            s = new Store();
            s.Name = "Turtle #3";
            s.Street = "College Road";
            stores.Add(s);

            s = new Store();
            s.Name = "Prince George #3";
            s.Street = "CGI Road";
            stores.Add(s);

            return stores;
        }
    }
}
