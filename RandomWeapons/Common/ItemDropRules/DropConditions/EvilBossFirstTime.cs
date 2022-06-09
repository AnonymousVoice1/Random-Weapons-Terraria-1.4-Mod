using Terraria;
using Terraria.GameContent.ItemDropRules;

namespace RandomWeapons.Common.ItemDropRules.DropConditions
{
    public class EvilBossFirstTime : IItemDropRuleCondition
    {
        public bool CanDrop(DropAttemptInfo info) => !NPC.downedBoss2;
        public bool CanShowItemDropInUI() => true;
        public string GetConditionDescription() => null;
    }
}
