using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marketplace.Shared
{
    public class Seller
    {
        public int id { get; set; }
        public int addressId { get; set; }
        public string emailAdrress { get; set; }
        public string shopName { get; set; }
        public string phoneNumber { get; set; }
        public string password { get; set; }

    }
}
