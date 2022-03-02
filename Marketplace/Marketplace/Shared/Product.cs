using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace.Shared
{
    public class Product
    {
        int id { get; set; }
        int sellerId { get; set; }
        string name { get; set; }
        float price { get; set; }
        string desc { get; set; }
        string category { get; set; }
        string image { get; set; }

    }
}
