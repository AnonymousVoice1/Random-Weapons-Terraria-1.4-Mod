using Terraria;
using Terraria.GameContent.ItemDropRules;

namespace RandomWeapons.Common.ItemDropRules.DropConditions
{
    public class EmpressofLightFirstTime : IItemDropRuleCondition
    {
        public bool CanDrop(DropAttemptInfo info) => !NPC.downedEmpressOfLight;
        public bool CanShowItemDropInUI() => true;
        public string GetConditionDescription() => null;
    }
}
