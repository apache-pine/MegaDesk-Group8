using System;
using System.IO;
using System.ComponentModel;

namespace MegaDesk_Group8
{
    // Represents the delivery options for a desk quote
    public enum Delivery
    {
        [Description("Rush 3 Days")]
        Rush3Days,

        [Description("Rush 5 Days")]
        Rush5Days,

        [Description("Rush 7 Days")]
        Rush7Days,

        [Description("No Rush (14 Days)")]
        Default14Days
    }

    // Represents a desk quote
    public class DeskQuote
    {
        private int[,] _rushOrderPrice;

        public const decimal BASE_DESK_PRICE = 200.00M;
        public const decimal DRAWER_PRICE = 50.00M;
        public const decimal SURFACE_AREA_PRICE = 1.00M;

        // Properties
        public Desk Desk { get; set; }
        public string CustomerName { get; set; }
        public DateTime QuoteDate { get; set; }
        public Delivery RushOrder { get; set; }
        public decimal QuotePrice { get; set; }

        // Calculate the quote price
        public decimal GetQuotePrice()
        {
            getRushOrderPrice();

            decimal quotePrice = BASE_DESK_PRICE;
            decimal surfaceArea = this.Desk.DeskDepth * this.Desk.DeskWidth;
            decimal surfacePrice = 0.00M;

            if (surfaceArea > 1000)
            {
                surfacePrice = (surfaceArea - 1000) * SURFACE_AREA_PRICE;
            }

            decimal drawerPrice = this.Desk.NumDrawers * DRAWER_PRICE;

            decimal materialPrice = getMaterialPrice(this.Desk.DesktopMaterial);

            decimal shippingPrice = 0.00M;

            int surfaceAreaCategory;

            if (surfaceArea < 1000)
            {
                surfaceAreaCategory = 0;
            }
            else if (surfaceArea <= 2000)
            {
                surfaceAreaCategory = 1;
            }
            else
            {
                surfaceAreaCategory = 2;
            }

            switch (this.RushOrder)
            {
                case Delivery.Rush3Days:
                    shippingPrice = _rushOrderPrice[0, surfaceAreaCategory];
                    break;

                case Delivery.Rush5Days:
                    shippingPrice = _rushOrderPrice[1, surfaceAreaCategory];
                    break;

                case Delivery.Rush7Days:
                    shippingPrice = _rushOrderPrice[2, surfaceAreaCategory];
                    break;
            }

            quotePrice = quotePrice + surfacePrice + drawerPrice + materialPrice + shippingPrice;

            return quotePrice;
        }

        // Get the price of a specific desktop material
        private decimal getMaterialPrice(DesktopMaterial material)
        {
            decimal price = 0;
            switch (material)
            {
                case DesktopMaterial.Oak:
                    price = 200.00M;
                    break;
                case DesktopMaterial.Laminate:
                    price = 100.00M;
                    break;
                case DesktopMaterial.Pine:
                    price = 50.00M;
                    break;
                case DesktopMaterial.Rosewood:
                    price = 300.00M;
                    break;
                case DesktopMaterial.Veneer:
                    price = 125.00M;
                    break;
                default:
                    break;
            }
            return price;
        }

        // Get the rush order prices from a file
        private void getRushOrderPrice()
        {
            _rushOrderPrice = new int[3, 3];

            var pricesFile = @"rushOrderPrices.txt";

            try
            {
                string[] prices = File.ReadAllLines(pricesFile);
                int i = 0, j = 0;

                foreach (string price in prices)
                {
                    _rushOrderPrice[i, j] = int.Parse(price);

                    if (j == 2)
                    {
                        i++;
                        j = 0;
                    }
                    else
                    {
                        j++;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
