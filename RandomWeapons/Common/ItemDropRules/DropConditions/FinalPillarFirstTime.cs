using Terraria;
using Terraria.GameContent.ItemDropRules;

namespace RandomWeapons.Common.ItemDropRules.DropConditions
{
    public class FinalPillarFirstTime : IItemDropRuleCondition
    {
        public bool CanDrop(DropAttemptInfo info) => 
            (!NPC.downedTowerSolar && NPC.downedTowerVortex && NPC.downedTowerNebula && NPC.downedTowerStardust) ||
            (NPC.downedTowerSolar && !NPC.downedTowerVortex && NPC.downedTowerNebula && NPC.downedTowerStardust) ||
            (NPC.downedTowerSolar && NPC.downedTowerVortex && !NPC.downedTowerNebula && NPC.downedTowerStardust) ||
            (NPC.downedTowerSolar && NPC.downedTowerVortex && NPC.downedTowerNebula && !NPC.downedTowerStardust);
        public bool CanShowItemDropInUI() => true;
        public string GetConditionDescription() => null;
    }
}
