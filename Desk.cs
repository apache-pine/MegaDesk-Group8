using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Group8
{
    public class Desk
    {

        public const int DeskMinWidth = 24;
        public const int DeskMaxWidth = 96;
        public const int DeskMinDepth = 12;
        public const int DeskMaxDepth = 48;

        public int Width { get; set; }
        public int Depth { get; set; }
        public int NumDrawers { get; set; }
        public DesktopMaterial DeskMaterial { get; set; }

        public Desk(int width, int depth, int numDrawers, DesktopMaterial deskMaterial)
        {
            Width = width;
            Depth = depth;
            NumDrawers = numDrawers;
            DeskMaterial = deskMaterial;
        }
    }

    public enum DesktopMaterial
    {
        None=0,
        Oak=200,
        Laminate=100,
        Pine=50,
        Rosewood=300,
        Veneer=125
    }
}
