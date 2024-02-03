using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Tracker
{
    public class TicketBatch
    {
        public int BatchNumber { get; set; }
        public int TicketCount { get; set; }
        public double TicketPrice { get; set; }
        public double SellerCommission { get; set; }

        // TODO seller entries
    }
}
