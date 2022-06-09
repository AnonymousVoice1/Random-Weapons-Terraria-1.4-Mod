using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Collections.Generic;
using RandomWeapons.Content.Items;

namespace RandomWeapons.Common
{
    public class InventorySpawn : ModPlayer
    {
        public override IEnumerable<Item> AddStartingItems(bool mediumCoreDeath)
        {
            return new[]
            {
                new Item(ModContent.ItemType<MagicItemBag>()),
                new Item(ModContent.ItemType<RerollStone>())
            };
        }
    }
}
