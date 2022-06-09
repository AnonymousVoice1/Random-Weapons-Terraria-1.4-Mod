using Terraria;
using Terraria.ModLoader;
using RandomWeapons.Common.RandomConfig;
using Terraria.ID;
using System.Collections.Generic;

namespace RandomWeapons.Content.Items
{
    
    public class RerollStone : ModItem
    {
        public static int RerollsLeft = ModContent.GetInstance<RandomConfig>().RerollNum;
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Reroll Stone");
            Tooltip.SetDefault("Allows to reroll if you got bad rng.\nYou can change the maximum in config.");
        }
        public override void SetDefaults()
        {
            Item.maxStack = 1;
            Item.consumable = false;
            Item.height = 8;
            Item.width = 8;
            Item.rare = ItemRarityID.Blue;
            Item.useStyle = ItemUseStyleID.HoldUp;
        }
        public override bool? UseItem(Player player)
        {
            
            player.QuickSpawnItem(player.GetSource_FromThis("From Reroll"), ModContent.ItemType<MagicItemBag>(), 1);
            if (RerollsLeft == 1)
            {
                Item.consumable = true;
            }
            RerollsLeft--;
            return true;
        }
        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            TooltipLine tooltip = new TooltipLine(Mod, "RandomWeapons : RerollStone", $"You have {RerollsLeft} rerolls left.");
            tooltips.Add(tooltip);
        }
    }
}
