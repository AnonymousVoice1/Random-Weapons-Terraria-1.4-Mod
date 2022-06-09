using Terraria;
using Terraria.GameContent.ItemDropRules;

namespace RandomWeapons.Common.ItemDropRules.DropConditions
{
    public class SkeletronPrimeFirstTime : IItemDropRuleCondition
    {
        public bool CanDrop(DropAttemptInfo info) => !NPC.downedMechBoss3;
        public bool CanShowItemDropInUI() => true;
        public string GetConditionDescription() => null;
    }
}
