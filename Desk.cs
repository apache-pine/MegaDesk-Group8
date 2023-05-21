namespace MegaDesk_Group8
{
    // Represents a desk
    public class Desk
    {
        public const int DESK_MIN_WIDTH = 24;
        public const int DESK_MAX_WIDTH = 96;
        public const int DESK_MIN_DEPTH = 12;
        public const int DESK_MAX_DEPTH = 48;

        // Properties
        public int DeskWidth { get; set; }
        public int DeskDepth { get; set; }
        public int NumDrawers { get; set; }
        public DesktopMaterial DesktopMaterial { get; set; }
    }

    // Represents the available desktop materials
    public enum DesktopMaterial
    {
        Oak,
        Laminate,
        Pine,
        Rosewood,
        Veneer
    }
}
