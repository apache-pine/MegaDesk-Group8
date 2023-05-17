using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MegaDesk_Group8
{
    public class DeskQuote
    {
        public Desk desk;
        public const int BaseDeskPrice = 200;
        public const int DrawerPrice = 50;
        public string CurrentDate { get; set; }
        public string CustomerName { get; set; }
        public string Shipping { get; set; }
        public decimal QuotePrice { get; set; }
        public Desk Desk { get; set; }

        public DeskQuote(string customerName, string shipping, decimal quotePrice, Desk desk)
        {

        }

        public decimal GetQuotePrice(int width, int depth, int numDrawers, DesktopMaterial material, int rushOrder)
        {
            // TODO:
            decimal price = 0;

            price += BaseDeskPrice;
            price += width * depth;
            price += numDrawers * DrawerPrice;
            price += GetMaterialPrice(material);
            if (rushOrder != 3)
            {
                price += GetRushOrderPrice(width, depth, rushOrder);
            }
            return price;
        }

        private int GetMaterialPrice(DesktopMaterial material)
        {
            int price = 0;
            switch (material)
            {
                case DesktopMaterial.Oak:
                    price = 200;
                    break;
                case DesktopMaterial.Laminate:
                    price = 100;
                    break;
                case DesktopMaterial.Pine:
                    price = 50;
                    break;
                case DesktopMaterial.Rosewood:
                    price = 300;
                    break;
                case DesktopMaterial.Veneer:
                    price = 125;
                    break;
                default:
                    break;
            }
            return price;
        }

        private int GetRushOrderPrice(int width, int depth, int rushOrder)
        {
            int price = 0;

            string path = @"bin\Debug\rushOrderPrices.txt";
            string[] lines = File.ReadAllLines(path);

            int[,] rushOrderPrices = new int[3, 3];

            int i = 0;

            foreach (string line in lines)
            {
                string[] values = line.Split(',');
                for (int j = 0; j < 3; j++)
                {
                    rushOrderPrices[i, j] = int.Parse(values[j]);
                }
                i++;
            }

            if (width * depth < 1000)
            {
                price = rushOrderPrices[0, rushOrder];
            }
            else if (width * depth >= 1000 && width * depth <= 2000)
            {
                price = rushOrderPrices[1, rushOrder];
            }
            else if (width * depth > 2000)
            {
                price = rushOrderPrices[2, rushOrder];
            }
            return price;
        }
    }
}
