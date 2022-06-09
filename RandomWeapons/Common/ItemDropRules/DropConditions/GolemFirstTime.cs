using Terraria;
using Terraria.GameContent.ItemDropRules;

namespace RandomWeapons.Common.ItemDropRules.DropConditions
{
    public class GolemFirstTime : IItemDropRuleCondition
    {
        public bool CanDrop(DropAttemptInfo info) => !NPC.downedGolemBoss;
        public bool CanShowItemDropInUI() => true;
        public string GetConditionDescription() => null;
    }
}
