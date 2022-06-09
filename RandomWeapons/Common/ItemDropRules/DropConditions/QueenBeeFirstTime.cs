using Terraria;
using Terraria.GameContent.ItemDropRules;

namespace RandomWeapons.Common.ItemDropRules.DropConditions
{
    public class QueenBeeFirstTime : IItemDropRuleCondition
    {
        public bool CanDrop(DropAttemptInfo info) => !NPC.downedQueenBee;
        public bool CanShowItemDropInUI() => true;
        public string GetConditionDescription() => null;
    }
}
