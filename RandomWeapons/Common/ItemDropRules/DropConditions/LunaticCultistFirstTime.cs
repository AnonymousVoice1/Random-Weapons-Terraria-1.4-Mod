using Terraria;
using Terraria.GameContent.ItemDropRules;

namespace RandomWeapons.Common.ItemDropRules.DropConditions
{
    public class LunaticCultistFirstTime : IItemDropRuleCondition
    {
        public bool CanDrop(DropAttemptInfo info) => !NPC.downedAncientCultist;
        public bool CanShowItemDropInUI() => true;
        public string GetConditionDescription() => null;
    }
}
