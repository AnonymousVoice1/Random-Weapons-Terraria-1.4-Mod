using Terraria;
using Terraria.GameContent.ItemDropRules;

namespace RandomWeapons.Common.ItemDropRules.DropConditions
{
    public class SkeletronFirstTime : IItemDropRuleCondition
    {
        public bool CanDrop(DropAttemptInfo info) => !NPC.downedBoss3;
        public bool CanShowItemDropInUI() => true;
        public string GetConditionDescription() => null;
    }
}
