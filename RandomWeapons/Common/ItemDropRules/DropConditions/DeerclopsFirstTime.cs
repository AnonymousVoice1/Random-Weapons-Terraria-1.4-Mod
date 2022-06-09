using Terraria;
using Terraria.GameContent.ItemDropRules;

namespace RandomWeapons.Common.ItemDropRules.DropConditions
{
    public class DeerclopsFirstTime : IItemDropRuleCondition
    {
        public bool CanDrop(DropAttemptInfo info) => !NPC.downedDeerclops;
        public bool CanShowItemDropInUI() => true;
        public string GetConditionDescription() => null;
    }
}
