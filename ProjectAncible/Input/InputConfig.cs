using System.Collections.Generic;
using ProjectAncible.Actions;

namespace ProjectAncible.Input
{
    public class InputConfig
    {
        private Dictionary<InputButton, IAction> buttonConfig = new Dictionary<InputButton, IAction>();

        public bool AddAction(InputButton button, IAction action)
        {
            if (buttonConfig.ContainsKey(button)) return false;
            buttonConfig.Add(button, action);
            return true;
        }

        public bool RemoveAction(InputButton button)
        {
            return buttonConfig.Remove(button);
        }

        public bool SetAction(InputButton button, IAction action)
        {
            if (!buttonConfig.ContainsKey(button)) return false;
            buttonConfig[button] = action;
            return true;
        }
    }
}