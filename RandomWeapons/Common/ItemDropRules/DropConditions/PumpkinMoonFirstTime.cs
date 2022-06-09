using Terraria;
using Terraria.GameContent.ItemDropRules;

namespace RandomWeapons.Common.ItemDropRules.DropConditions
{
    public class PumpkinMoonFirstTime : IItemDropRuleCondition
    {
        public bool CanDrop(DropAttemptInfo info) => !NPC.downedHalloweenKing && NPC.downedHalloweenTree;
        public bool CanShowItemDropInUI() => true;
        public string GetConditionDescription() => null;
    }
}
