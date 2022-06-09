using Terraria;
using Terraria.GameContent.ItemDropRules;

namespace RandomWeapons.Common.ItemDropRules.DropConditions
{
    public class TheDestroyerFirstTime : IItemDropRuleCondition
    {
        public bool CanDrop(DropAttemptInfo info) => !NPC.downedMechBoss1;
        public bool CanShowItemDropInUI() => true;
        public string GetConditionDescription() => null;
    }
}
