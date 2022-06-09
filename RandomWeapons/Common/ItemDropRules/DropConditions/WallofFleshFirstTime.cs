using Terraria;
using Terraria.GameContent.ItemDropRules;

namespace RandomWeapons.Common.ItemDropRules.DropConditions
{
    public class WallofFleshFirstTime : IItemDropRuleCondition
    {
        public bool CanDrop(DropAttemptInfo info) => !Main.hardMode;
        public bool CanShowItemDropInUI() => true;
        public string GetConditionDescription() => null;
    }
}
