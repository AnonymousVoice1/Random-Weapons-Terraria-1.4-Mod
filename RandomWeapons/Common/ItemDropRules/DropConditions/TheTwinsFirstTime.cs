using Terraria;
using Terraria.GameContent.ItemDropRules;

namespace RandomWeapons.Common.ItemDropRules.DropConditions
{
    public class TheTwinsFirstTime : IItemDropRuleCondition
    {
        public bool CanDrop(DropAttemptInfo info) => !NPC.downedMechBoss2;
        public bool CanShowItemDropInUI() => true;
        public string GetConditionDescription() => null;
    }
}
