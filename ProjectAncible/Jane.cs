using System.Collections.Generic;
using System.Linq;
using AncibleObjectLib.AncibleObjects;
using AncibleObjectLib.Interfaces;
using ProjectAncible.Actions;
using ProjectAncible.Input;

namespace ProjectAncible
{
    public class Jane
    {
        private Dictionary<string, IAncibleObject> ancibleObjects = new Dictionary<string, IAncibleObject>();
        
        private List<string> animatedObjects = new List<string>();
        private List<string> movableObjects = new List<string>();
        private List<string> collidableObjects = new List<string>();
        
        private ActionSystem actionSystem = new ActionSystem();
        private InputSystem inputSystem = new InputSystem();

        public bool AddObject(IAncibleObject ancibleObject)
        {
            if (ancibleObjects.ContainsKey(ancibleObject.Name)) return false;
            ancibleObjects.Add(ancibleObject.Name, ancibleObject);
            if (ancibleObject is IAnimated) animatedObjects.Add(ancibleObject.Name);
            if (ancibleObject is IMovable) movableObjects.Add(ancibleObject.Name);
            if (ancibleObject is ICollidable) collidableObjects.Add(ancibleObject.Name);
            return true;
        }

        public bool RemoveObject(string objectName)
        {
            if (!ancibleObjects.ContainsKey(objectName)) return false;
            if (ancibleObjects[objectName] is IAnimated) animatedObjects.Remove(objectName);
            if (ancibleObjects[objectName] is IMovable) movableObjects.Remove(objectName);
            if (ancibleObjects[objectName] is ICollidable) movableObjects.Remove(objectName);
            return ancibleObjects.Remove(objectName);
        }

        public bool SetObject(IAncibleObject ancibleObject)
        {
            if (!ancibleObjects.ContainsKey(ancibleObject.Name)) return false;
            ancibleObjects[ancibleObject.Name] = ancibleObject;
            return true;
        }

        public List<string> GetObjectNames()
        {
            return ancibleObjects.Keys.ToList();
        }

    }
}