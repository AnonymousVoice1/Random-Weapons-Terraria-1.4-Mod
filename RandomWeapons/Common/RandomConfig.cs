using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace RandomWeapons.Common.RandomConfig
{
    public class RandomConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ServerSide;
        [Label("Rerolls")]
        [Tooltip("These are the amount of rerolls you are allowed to use.")]
        [DefaultValue(6)]
        public int RerollNum;
    }
}
