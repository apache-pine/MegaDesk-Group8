using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Group8
{
    internal class DeskQuote
    {
        public string CustomerName { get; set; }

        public string Shipping { get; set; }

        public decimal QuotePrice { get; set; }

        public Desk Desk { get; set; }

        public decimal getQuotePrice()
        {
            // TODO:
            decimal price = 0;
            return price;
        }
    }
}
