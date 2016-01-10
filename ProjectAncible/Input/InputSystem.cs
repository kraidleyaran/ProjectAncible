using System.Collections.Generic;
using AncibleObjectLib.AncibleObjects;

namespace ProjectAncible.Input
{
    public class InputSystem
    {
        private Dictionary<Player, InputConfig> inputConfigs = new Dictionary<Player, InputConfig>();

        public bool AddInputConfig(Player player, InputConfig config)
        {
            if (inputConfigs.ContainsKey(player)) return false;
            inputConfigs.Add(player, config);
            return true;
        }

        public bool RemoveInputConfig(Player player)
        {
            return inputConfigs.Remove(player);
        }

        public bool SetInputConfig(Player player, InputConfig config)
        {
            if (!inputConfigs.ContainsKey(player)) return false;
            inputConfigs[player] = config;
            return true;
        }
    }
}