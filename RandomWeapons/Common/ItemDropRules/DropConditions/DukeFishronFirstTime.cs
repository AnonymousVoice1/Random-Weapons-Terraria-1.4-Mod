using Terraria;
using Terraria.GameContent.ItemDropRules;

namespace RandomWeapons.Common.ItemDropRules.DropConditions
{
    public class DukeFishronFirstTime : IItemDropRuleCondition
    {
        public bool CanDrop(DropAttemptInfo info) => !NPC.downedFishron;
        public bool CanShowItemDropInUI() => true;
        public string GetConditionDescription() => null;
    }
}
