using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales_Tracker
{
    public class SellerEntry
    {
        public DateTime SaleStartTime {  get; set; }
        public DateTime SaleEndTime { get; set; }
        public int TicketCount { get; set; }

        public double CalculateEfficiency()
        {
            double efficiency;
            int daydiff = (SaleEndTime.Date - SaleStartTime.Date).Days + 1;
            if (daydiff > 0)
            {
                efficiency = TicketCount / daydiff;
            }
            else
            {
                efficiency = 0;
            }

            return efficiency;
        }
    }
}
