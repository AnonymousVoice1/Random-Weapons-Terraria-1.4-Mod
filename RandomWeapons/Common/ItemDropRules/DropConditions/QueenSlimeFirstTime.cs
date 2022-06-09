using Terraria;
using Terraria.GameContent.ItemDropRules;

namespace RandomWeapons.Common.ItemDropRules.DropConditions
{
    public class QueenSlimeFirstTime : IItemDropRuleCondition
    {
        public bool CanDrop(DropAttemptInfo info) => !NPC.downedQueenSlime;
        public bool CanShowItemDropInUI() => true;
        public string GetConditionDescription() => null;
    }
}
