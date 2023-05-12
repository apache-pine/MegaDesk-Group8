using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Group8
{
    internal class Desk
    {
        // set the width and depth maximum and minimum constraints (4) as constants stored within the Desk.cs class.

        public const decimal MINWIDTH = 24;
        public const decimal MAXWIDTH = 96;
        public const decimal MINDEPTH = 12;
        public const decimal MAXDEPTH = 48;

        public decimal Width { get; set; }

        public decimal Depth { get; set; }

        public int NumDrawers { get; set; }
    }
    public enum SurfaceMaterial
    {
        Oak,
        Laminate,
        Pine,
        Rosewood,
        Veneer
    }
}
