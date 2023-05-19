using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Group8
{
    public class Desk
    {
        public const int DESK_MIN_WIDTH = 24;
        public const int DESK_MAX_WIDTH = 96;
        public const int DESK_MIN_DEPTH = 12;
        public const int DESK_MAX_DEPTH = 48;

        public int DeskWidth { get; set; }
        public int DeskDepth { get; set; }
        public int NumDrawers { get; set; }
        public DesktopMaterial DesktopMaterial { get; set; }
    }

    public enum DesktopMaterial
    {
        Oak,
        Laminate,
        Pine,
        Rosewood,
        Veneer
    }
}
