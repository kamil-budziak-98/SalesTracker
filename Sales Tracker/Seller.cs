using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Tracker
{
    public class Seller
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public City HomeCity { get; set; }
        public Seller Manager { get; set; }
    }
}
