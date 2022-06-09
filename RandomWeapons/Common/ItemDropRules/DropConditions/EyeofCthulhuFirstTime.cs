using Terraria;
using Terraria.GameContent.ItemDropRules;

namespace RandomWeapons.Common.ItemDropRules.DropConditions
{
    public class EyeofCthulhuFirstTime : IItemDropRuleCondition
    {
        public bool CanDrop(DropAttemptInfo info) => !NPC.downedBoss1;
        public bool CanShowItemDropInUI() => true;
        public string GetConditionDescription() => null;
    }
}
