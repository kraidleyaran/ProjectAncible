using System.Collections.Generic;
using CollisionEngineLib.Objects;

namespace AncibleObjectLib.Interfaces
{
    public interface ICollidable
    {
        bool IsCollidable { get; set; }
        bool IsSolid { get; set; }
        CollidableType CollidableType { get; }
        Dictionary<string, QuadTreePositionItem> CollisionBoxes { get; set; }
    }
}