using Terraria;
using Terraria.GameContent.ItemDropRules;

namespace RandomWeapons.Common.ItemDropRules.DropConditions
{
    public class MoonLordFirstTime : IItemDropRuleCondition
    {
        public bool CanDrop(DropAttemptInfo info) => !NPC.downedMoonlord;
        public bool CanShowItemDropInUI() => true;
        public string GetConditionDescription() => null;
    }
}
