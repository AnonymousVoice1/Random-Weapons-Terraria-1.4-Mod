using Terraria;
using Terraria.GameContent.ItemDropRules;

namespace RandomWeapons.Common.ItemDropRules.DropConditions
{
    public class FrostMoonFirstTime : IItemDropRuleCondition
    {
        public bool CanDrop(DropAttemptInfo info) => NPC.downedChristmasTree && NPC.downedChristmasSantank && !NPC.downedChristmasIceQueen;
        public bool CanShowItemDropInUI() => true;
        public string GetConditionDescription() => null;
    }
}
