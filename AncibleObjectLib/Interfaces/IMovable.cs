using AncibleObjectLib.Directions;

namespace AncibleObjectLib.Interfaces
{
    public interface IMovable
    {
        float MoveSpeed { get; set; }
        Position Position { get; set; }
    }
}