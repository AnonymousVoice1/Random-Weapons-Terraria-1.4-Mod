using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using RandomWeapons.Content.Items;
using Terraria.GameContent.ItemDropRules;
using RandomWeapons.Common.ItemDropRules.DropConditions;

namespace RandomWeapons.Common
{
    
    public class ChangeLoot : GlobalNPC
    {

        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if (npc.type == NPCID.KingSlime)
            {
                npcLoot.Add(new ItemDropWithConditionRule(ModContent.ItemType<MagicItemBag>(), 1, 1, 1, new KingSlimeFirstTime(), 1));
            }
            if (npc.type == NPCID.EyeofCthulhu)
            {
                npcLoot.Add(new ItemDropWithConditionRule(ModContent.ItemType<MagicItemBag>(), 1, 1, 1, new EyeofCthulhuFirstTime(), 1));
            }
            if (System.Array.IndexOf(new int[] { NPCID.EaterofWorldsBody, NPCID.EaterofWorldsHead, NPCID.EaterofWorldsTail }, npc.type) > -1) {
                LeadingConditionRule idklol = new(new Conditions.LegacyHack_IsABoss());
                LeadingConditionRule EaterofWorldsFirstTimeRule = new(new EvilBossFirstTime());
                IItemDropRule eowdropbag = ItemDropRule.Common(ModContent.ItemType<MagicItemBag>());
                npcLoot.Add(idklol);
                idklol.OnSuccess(EaterofWorldsFirstTimeRule);
                EaterofWorldsFirstTimeRule.OnSuccess(eowdropbag);

            }
            if (npc.type == NPCID.BrainofCthulhu)
            {
                npcLoot.Add(new ItemDropWithConditionRule(ModContent.ItemType<MagicItemBag>(), 1, 1, 1, new EvilBossFirstTime(), 1));
            }
            if (npc.type == NPCID.QueenBee)
            {
                npcLoot.Add(new ItemDropWithConditionRule(ModContent.ItemType<MagicItemBag>(), 1, 1, 1, new QueenBeeFirstTime(), 1));
            }
            if (npc.type == NPCID.SkeletronHead)
            {
                npcLoot.Add(new ItemDropWithConditionRule(ModContent.ItemType<MagicItemBag>(), 1, 1, 1, new SkeletronFirstTime(), 1));
            }
            if (npc.type == NPCID.Deerclops)
            {
                npcLoot.Add(new ItemDropWithConditionRule(ModContent.ItemType<MagicItemBag>(), 1, 1, 1, new DeerclopsFirstTime(), 1));
            }
            if (npc.type == NPCID.WallofFlesh)
            {
                npcLoot.Add(new ItemDropWithConditionRule(ModContent.ItemType<MagicItemBag>(), 1, 1, 1, new WallofFleshFirstTime(), 1));
            }
            if (npc.type == NPCID.QueenSlimeBoss)
            {
                npcLoot.Add(new ItemDropWithConditionRule(ModContent.ItemType<MagicItemBag>(), 1, 1, 1, new QueenSlimeFirstTime(), 1));
            }
            if (npc.type == NPCID.TheDestroyer)
            {
                npcLoot.Add(new ItemDropWithConditionRule(ModContent.ItemType<MagicItemBag>(), 1, 1, 1, new TheDestroyerFirstTime(), 1));
            }
            if (npc.type == NPCID.Retinazer || npc.type == NPCID.Spazmatism)
            {
                LeadingConditionRule FirstTwinDead = new(new Conditions.MissingTwin());
                LeadingConditionRule TwinsFirstTimeRule = new(new TheTwinsFirstTime());
                IItemDropRule twinsdropbag = ItemDropRule.Common(ModContent.ItemType<MagicItemBag>());
                npcLoot.Add(FirstTwinDead);
                FirstTwinDead.OnSuccess(TwinsFirstTimeRule);
                TwinsFirstTimeRule.OnSuccess(twinsdropbag);
            }
            if (npc.type == NPCID.SkeletronPrime)
            {
                npcLoot.Add(new ItemDropWithConditionRule(ModContent.ItemType<MagicItemBag>(), 1, 1, 1, new SkeletronPrimeFirstTime(), 1));
            }
            if (npc.type == NPCID.Plantera)
            {
                npcLoot.Add(new ItemDropWithConditionRule(ModContent.ItemType<MagicItemBag>(), 1, 1, 1, new Conditions.FirstTimeKillingPlantera(), 1));
            }
            if (npc.type == NPCID.Golem)
            {
                npcLoot.Add(new ItemDropWithConditionRule(ModContent.ItemType<MagicItemBag>(), 1, 1, 1, new GolemFirstTime(), 1));
            }
            if (npc.type == NPCID.Pumpking)
            {
                npcLoot.Add(new ItemDropWithConditionRule(ModContent.ItemType<MagicItemBag>(), 1, 1, 1, new PumpkinMoonFirstTime(), 1));
            }
            if (npc.type == NPCID.IceQueen)
            {
                npcLoot.Add(new ItemDropWithConditionRule(ModContent.ItemType<MagicItemBag>(), 1, 1, 1, new FrostMoonFirstTime(), 1));
            }
            if (npc.type == NPCID.DukeFishron)
            {
                npcLoot.Add(new ItemDropWithConditionRule(ModContent.ItemType<MagicItemBag>(), 1, 1, 1, new DukeFishronFirstTime(), 1));
            }
            if (npc.type == NPCID.HallowBoss)
            {
                npcLoot.Add(new ItemDropWithConditionRule(ModContent.ItemType<MagicItemBag>(), 1, 1, 1, new EmpressofLightFirstTime(), 1));
            }
            if (npc.type == NPCID.CultistBoss)
            {
                npcLoot.Add(new ItemDropWithConditionRule(ModContent.ItemType<MagicItemBag>(), 1, 1, 1, new LunaticCultistFirstTime(), 1));
            }
            if (npc.type == NPCID.LunarTowerSolar)
            {
                npcLoot.Add(new ItemDropWithConditionRule(ModContent.ItemType<MagicItemBag>(), 1, 1, 1, new FinalPillarFirstTime(), 1));
            }
            if (npc.type == NPCID.LunarTowerVortex)
            {
                npcLoot.Add(new ItemDropWithConditionRule(ModContent.ItemType<MagicItemBag>(), 1, 1, 1, new FinalPillarFirstTime(), 1));
            }
            if (npc.type == NPCID.LunarTowerNebula)
            {
                npcLoot.Add(new ItemDropWithConditionRule(ModContent.ItemType<MagicItemBag>(), 1, 1, 1, new FinalPillarFirstTime(), 1));
            }
            if (npc.type == NPCID.LunarTowerStardust)
            {
                npcLoot.Add(new ItemDropWithConditionRule(ModContent.ItemType<MagicItemBag>(), 1, 1, 1, new FinalPillarFirstTime(), 1));
            }
            if (npc.type == NPCID.MoonLordCore)
            {
                npcLoot.Add(new ItemDropWithConditionRule(ModContent.ItemType<MagicItemBag>(), 1, 1, 1, new MoonLordFirstTime(), 1));
            }
        }
    }
}
