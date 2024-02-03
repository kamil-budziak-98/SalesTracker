using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Tracker
{
    public class City
    {
        public string Name { get; set; }
        public List<Seller> Sellers { get; set; }
    }
}
