using System.Security.Cryptography.X509Certificates;
using AncibleObjectLib.Directions;

namespace AncibleObjectLib.Interfaces
{
    public interface ICanSwing
    {
        DirectionalObject SwingDirection { get; set; }
    }
}