using AncibleObjectLib.Directions;

namespace AncibleObjectLib.Interfaces
{
    public interface IDirectional
    {
        Direction Direction { get; set; }
        FacingDirection FacingDirection { get; set; }
    }
}