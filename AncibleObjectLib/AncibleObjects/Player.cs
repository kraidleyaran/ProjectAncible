using System.Collections.Generic;
using AncibleObjectLib.Directions;
using AncibleObjectLib.Interfaces;
using CollisionEngineLib.Objects;
using GameGraphicsLib;

namespace AncibleObjectLib.AncibleObjects
{
    public class Player : IAncibleObject, IAnimated, ICollidable, IControllable, ICanShoot, ICanSwing, IDirectional, IMovable
    {
        public Player()
        {
            
        }

        public Player(string name)
        {
            Name = name;
            MoveSpeed = 0;
            Position = new Position(0,0);
            ControllableType = ControllableType.Local;            
        }
        public string Name { get; set; }
        public bool IsVisible { get; set; }
        public float MoveSpeed { get; set; }
        private Position position { get; set; }
        private Animation currentAnimation { get; set; }
        public Position Position
        {
            get { return position; }
            set
            {
                position = value;
                if (currentAnimation == null) return;
                currentAnimation.X = position.X;
                currentAnimation.Y = position.Y;
            }
        }
        public Animation CurrentAnimation
        {
            get { return currentAnimation; }
            set
            {
                currentAnimation = value;
                currentAnimation.X = position.X;
                currentAnimation.Y = position.Y;
            } 
        }
        public bool IsCollidable { get; set; }
        public bool IsSolid { get; set; }
        public CollidableType CollidableType { get { return CollidableType.HurtBox;} }
        public ObjectType ObjectType { get { return ObjectType.Player; } }
        public ControllableType ControllableType { get; set; }
        public Directions.Direction Direction { get; set; }
        public FacingDirection FacingDirection { get; set; }
        public Dictionary<string, QuadTreePositionItem> CollisionBoxes { get; set; }
        public Dictionary<string, Animation> Animations { get; set; }
        public DirectionalObject SwingDirection { get; set; }
        public DirectionalObject ShootDirection { get; set; }
        
    }
}