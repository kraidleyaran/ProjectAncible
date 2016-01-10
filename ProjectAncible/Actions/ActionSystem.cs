using AncibleObjectLib.Directions;
using AncibleObjectLib.Interfaces;

namespace ProjectAncible.Actions
{
    public class ActionSystem
    {
        public static void MoveObject(IMovable movableObject, Direction direction)
        {
            IMovable moveObject = movableObject;
            switch (direction)
            {
                case Direction.North:
                    moveObject.Position.Y -= moveObject.MoveSpeed;
                    break;
                case Direction.NorthEast:
                    moveObject.Position.X += moveObject.MoveSpeed/2;
                    moveObject.Position.Y += moveObject.MoveSpeed/2;
                    break;
                case Direction.East:
                    moveObject.Position.X += moveObject.MoveSpeed;
                    break;
                case Direction.SouthEast:
                    moveObject.Position.X += moveObject.MoveSpeed/2;
                    moveObject.Position.Y += moveObject.MoveSpeed/2;
                    break;
                case Direction.South:
                    moveObject.Position.Y += moveObject.MoveSpeed;
                    break;
                case Direction.SouthWest:
                    moveObject.Position.X -= moveObject.MoveSpeed/2;
                    moveObject.Position.Y += moveObject.MoveSpeed/2;
                    break;
                case Direction.West:
                    moveObject.Position.X -= moveObject.MoveSpeed;
                    break;
                case Direction.NorthWest:
                    moveObject.Position.X -= moveObject.MoveSpeed/2;
                    moveObject.Position.Y += moveObject.MoveSpeed/2;
                    break;
            }
        }

        public static void SwingWeapon(ICanSwing swingingObject, FacingDirection direction)
        {
            switch (direction)
            {
                case FacingDirection.North:
                    break;
                case FacingDirection.South:
                    break;
                case FacingDirection.East:
                    break;
                case FacingDirection.West:
                    break;

            }
        }
    }
}