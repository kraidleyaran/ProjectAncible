using System.Collections.Generic;
using AncibleObjectLib.Directions;
using GameGraphicsLib;

namespace AncibleObjectLib.Interfaces
{
    public interface IAnimated
    {
        bool IsVisible { get; set; }Position Position { get; set; }
        Dictionary<string, Animation> Animations { get; set; }
        Animation CurrentAnimation { get; set; }
    }
}