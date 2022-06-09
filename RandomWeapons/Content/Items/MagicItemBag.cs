using System.Collections.Generic;
using System.Numerics;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace RandomWeapons.Content.Items
{
    public class MagicItemBag : ModItem
    {

        static int[] preboss = new int[] {
                ItemID.CopperShortsword, ItemID.TinShortsword, ItemID.IronShortsword, ItemID.LeadShortsword,
                ItemID.SilverShortsword, ItemID.TungstenShortsword, ItemID.GoldShortsword, ItemID.PlatinumShortsword,
                ItemID.WoodenSword, ItemID.BorealWoodSword, ItemID.PalmWoodSword, ItemID.RichMahoganySword, ItemID.CactusSword,
                ItemID.EbonwoodSword, ItemID.ShadewoodSword, ItemID.CopperBroadsword, ItemID.TinBroadsword, ItemID.IronBroadsword,
                ItemID.LeadBroadsword, ItemID.SilverBroadsword, ItemID.TungstenBroadsword, ItemID.GoldBroadsword, ItemID.PlatinumBroadsword,
                ItemID.BladedGlove, ItemID.ZombieArm, ItemID.AntlionClaw, ItemID.StylistKilLaKillScissorsIWish, ItemID.Ruler, ItemID.Umbrella,
                ItemID.TragicUmbrella, ItemID.BreathingReed, ItemID.Gladius, ItemID.BoneSword, ItemID.BatBat, ItemID.TentacleSpike,
                ItemID.CandyCaneSword, ItemID.Katana, ItemID.IceBlade, ItemID.LightsBane, ItemID.BloodButcherer, ItemID.Starfury, ItemID.EnchantedSword,
                ItemID.PurpleClubberfish, ItemID.FalconBlade, ItemID.BladeofGrass, ItemID.WoodYoyo, ItemID.Rally, ItemID.CorruptYoyo, ItemID.CrimsonYoyo,
                ItemID.JungleYoyo, ItemID.Spear, ItemID.Trident, ItemID.ThunderSpear, ItemID.TheRottedFork, ItemID.Swordfish, ItemID.WoodenBoomerang,
                ItemID.EnchantedBoomerang, ItemID.FruitcakeChakram, ItemID.BloodyMachete, ItemID.Shroomerang, ItemID.IceBoomerang, ItemID.ThornChakram,
                ItemID.ChainKnife, ItemID.Mace, ItemID.FlamingMace, ItemID.BallOHurt, ItemID.WoodenBow, ItemID.BorealWoodBow, ItemID.RichMahoganyBow,
                ItemID.PalmWoodBow, ItemID.EbonwoodBow, ItemID.ShadewoodBow, ItemID.CopperBow, ItemID.TinBow, ItemID.IronBow, ItemID.LeadBow, ItemID.SilverBow,
                ItemID.TungstenBow, ItemID.GoldBow, ItemID.PlatinumBow, ItemID.DemonBow, ItemID.TendonBow, ItemID.BloodRainBow, ItemID.RedRyder, ItemID.FlintlockPistol,
                ItemID.Musket, ItemID.TheUndertaker, ItemID.Sandgun, ItemID.Revolver, ItemID.Minishark, ItemID.Boomstick, ItemID.PaperAirplaneA, ItemID.PaperAirplaneB,
                ItemID.Shuriken, ItemID.ThrowingKnife, ItemID.PoisonedKnife, ItemID.Snowball, ItemID.SpikyBall, ItemID.RottenEgg, ItemID.StarAnise, ItemID.MolotovCocktail,
                ItemID.FrostDaggerfish, ItemID.Javelin, ItemID.BoneJavelin, ItemID.BoneDagger, ItemID.Grenade, ItemID.StickyGrenade, ItemID.BouncyGrenade,
                ItemID.PartyGirlGrenade, ItemID.FlareGun, ItemID.Blowpipe, ItemID.SnowballCannon, ItemID.PainterPaintballGun, ItemID.Harpoon, ItemID.WandofSparking,
                ItemID.ThunderStaff, ItemID.AmethystStaff, ItemID.TopazStaff, ItemID.SapphireStaff, ItemID.EmeraldStaff,
                ItemID.RubyStaff, ItemID.DiamondStaff, ItemID.AmberStaff, ItemID.Vilethorn, ItemID.CrimsonRod, ItemID.BabyBirdStaff, ItemID.SlimeStaff, ItemID.FlinxStaff,
                ItemID.AbigailsFlower, ItemID.VampireFrogStaff, ItemID.BlandWhip, ItemID.ThornWhip, ItemID.Terragrim, ItemID.ExoticEasternChewToy, ItemID.DemonScythe

            };
        static int[] postEoC = new int[] { ItemID.Code1, ItemID.ZapinatorGray };
        static int[] postEoWorBoC = new int[]
        {
            ItemID.FieryGreatsword, ItemID.PurplePhaseblade, ItemID.YellowPhaseblade, ItemID.BluePhaseblade, ItemID.GreenPhaseblade, ItemID.RedPhaseblade, ItemID.WhitePhaseblade,
            ItemID.OrangePhaseblade, ItemID.Flamarang, ItemID.TheMeatball, ItemID.MoltenFury, ItemID.StarCannon, ItemID.AleThrowingGlove, ItemID.SpaceGun, ItemID.ImpStaff
        };
        static int[] postQB = new int[] { ItemID.BeeKeeper, ItemID.BeesKnees, ItemID.Blowgun, ItemID.BeeGun, ItemID.Beenade, ItemID.HornetStaff };
        static int[] postSkel = new int[]
        {
            ItemID.Muramasa, ItemID.NightsEdge, ItemID.Valor, ItemID.Cascade, ItemID.DarkLance, ItemID.CombatWrench, ItemID.BlueMoon,
            ItemID.Sunfury, ItemID.HellwingBow, ItemID.QuadBarrelShotgun, ItemID.Handgun, ItemID.PhoenixBlaster, ItemID.MagicMissile,
            ItemID.AquaScepter, ItemID.FlowerofFire, ItemID.Flamelash, ItemID.WaterBolt, ItemID.BookofSkulls, ItemID.DD2LightningAuraT1Popper,
            ItemID.DD2FlameburstTowerT1Popper, ItemID.DD2ExplosiveTrapT1Popper, ItemID.DD2BallistraTowerT1Popper, ItemID.BoneWhip
        };
        static int[] postDeer = new int[] { ItemID.PewMaticHorn, ItemID.WeatherPain, ItemID.HoundiusShootius };
        static int[] preMechs = new int[]
        {
            ItemID.PearlwoodSword, ItemID.TaxCollectorsStickOfDoom, ItemID.SlapHand, ItemID.CobaltSword, ItemID.PalladiumSword, ItemID.MythrilSword,
            ItemID.OrichalcumSword, ItemID.AdamantiteSword, ItemID.TitaniumSword, ItemID.BreakerBlade, ItemID.IceSickle, ItemID.Cutlass, ItemID.Frostbrand,
            ItemID.BeamSword, ItemID.FetidBaghnakhs, ItemID.Bladetongue, ItemID.HamBat, ItemID.FormatC, ItemID.Gradient, ItemID.Chik, ItemID.HelFire,
            ItemID.Amarok, ItemID.CobaltNaginata, ItemID.PalladiumPike, ItemID.MythrilHalberd, ItemID.OrichalcumHalberd, ItemID.AdamantiteGlaive,
            ItemID.TitaniumTrident, ItemID.FlyingKnife, ItemID.BouncingShield, ItemID.Bananarang, ItemID.Anchor, ItemID.KOCannon, ItemID.DripplerFlail,
            ItemID.ChainGuillotines, ItemID.DaoofPow, ItemID.JoustingLance, ItemID.ShadowFlameKnife, ItemID.PearlwoodBow, ItemID.Marrow, ItemID.IceBow,
            ItemID.DaedalusStormbow, ItemID.ShadowFlameBow, ItemID.CobaltRepeater, ItemID.PalladiumRepeater, ItemID.MythrilRepeater, ItemID.OrichalcumRepeater,
            ItemID.AdamantiteRepeater, ItemID.TitaniumRepeater, ItemID.ClockworkAssaultRifle, ItemID.Gatligator, ItemID.Shotgun, ItemID.OnyxBlaster, ItemID.OnyxBlaster,
            ItemID.CoinGun, ItemID.Uzi, ItemID.Toxikarp, ItemID.DartPistol, ItemID.DartRifle, ItemID.SkyFracture, ItemID.CrystalSerpent, ItemID.FlowerofFrost,
            ItemID.FrostStaff, ItemID.CrystalVileShard, ItemID.SoulDrain, ItemID.MeteorStaff, ItemID.PoisonStaff, ItemID.LaserRifle, ItemID.ZapinatorOrange,
            ItemID.CursedFlames, ItemID.GoldenShower, ItemID.CrystalStorm, ItemID.IceRod, ItemID.ClingerStaff, ItemID.NimbusRod, ItemID.MagicDagger, ItemID.MedusaHead,
            ItemID.SpiritFlame, ItemID.SharpTears, ItemID.SpiderStaff, ItemID.PirateStaff, ItemID.SanguineStaff, ItemID.QueenSpiderStaff, ItemID.FireWhip, ItemID.CoolWhip,
            ItemID.ObsidianSwordfish
        };
        static int[] postQS = new int[] { ItemID.RedsYoyo, ItemID.ValkyrieYoyo, ItemID.Arkhalis, ItemID.Smolstar };
        static int[] post1mech = new int[]
        {
            ItemID.Excalibur, ItemID.Code2, ItemID.Yelets, ItemID.Gungnir, ItemID.MushroomSpear, ItemID.LightDisc, ItemID.HallowJoustingLance, ItemID.HallowedRepeater,
            ItemID.UnholyTrident, ItemID.SwordWhip, ItemID.SuperStarCannon
        };
        static int[] postDest = new int[] { ItemID.Megashark };
        static int[] postTwin = new int[] { ItemID.RainbowRod, ItemID.MagicalHarp, ItemID.OpticStaff };
        static int[] postSP = new int[] { ItemID.Flamethrower };
        static int[] postAllMechs = new int[]
        {
            ItemID.TrueExcalibur, ItemID.ChlorophyteSaber, ItemID.DeathSickle, ItemID.ChlorophyteClaymore, ItemID.TrueNightsEdge, ItemID.ChlorophytePartisan, ItemID.ChlorophyteShotbow,
            ItemID.VenomStaff, ItemID.DD2SquireDemonSword, ItemID.MonkStaffT2, ItemID.MonkStaffT1, ItemID.DD2PhoenixBow, ItemID.BookStaff, ItemID.DD2LightningAuraT2Popper, ItemID.DD2FlameburstTowerT2Popper,
            ItemID.DD2ExplosiveTrapT2Popper, ItemID.DD2BallistraTowerT2Popper
        };
        static int[] postPlant = new int[]
        {
            ItemID.PsychoKnife, ItemID.Keybrand, ItemID.Seedler, ItemID.TerraBlade, ItemID.PaladinsHammer, ItemID.FlowerPow, ItemID.ScourgeoftheCorruptor,
            ItemID.ShadowJoustingLance, ItemID.VampireKnives, ItemID.PulseBow, ItemID.VenusMagnum, ItemID.TacticalShotgun, ItemID.SniperRifle, ItemID.GrenadeLauncher, ItemID.ProximityMineLauncher,
            ItemID.RocketLauncher, ItemID.NailGun, ItemID.PiranhaGun, ItemID.NettleBurst, ItemID.InfernoFork, ItemID.SpectreStaff, ItemID.PrincessWeapon, ItemID.WaspGun, ItemID.LeafBlower,
            ItemID.RainbowGun, ItemID.ToxicFlask, ItemID.DeadlySphereStaff, ItemID.PygmyStaff, ItemID.StormTigerStaff, ItemID.StaffoftheFrostHydra, ItemID.MaceWhip, ItemID.Kraken, ItemID.TheEyeOfCthulhu,
            ItemID.MagnetSphere
        };
        static int[] postGolem = new int[] { ItemID.PossessedHatchet, ItemID.GolemFist, ItemID.Stynger, ItemID.StaffofEarth, ItemID.HeatRay, ItemID.FireworksLauncher };
        static int[] postPM = new int[]
        {
            ItemID.TheHorsemansBlade, ItemID.StakeLauncher, ItemID.CandyCornRifle, ItemID.JackOLanternLauncher, ItemID.BatScepter, ItemID.RavenStaff, ItemID.ScytheWhip
        };
        static int[] postFM = new int[]
        {
            ItemID.ChristmasTreeSword, ItemID.NorthPole, ItemID.ChainGun, ItemID.SnowmanCannon, ItemID.EldMelter, ItemID.BlizzardStaff, ItemID.Razorpine,
            ItemID.InfluxWaver, ItemID.Xenopopper, ItemID.ElectrosphereLauncher, ItemID.ChargedBlasterCannon, ItemID.LaserMachinegun, ItemID.XenoStaff
        };
        static int[] postDF = new int[] { ItemID.Flairon, ItemID.Tsunami, ItemID.RazorbladeTyphoon, ItemID.TempestStaff, ItemID.BubbleGun };
        static int[] postEoL = new int[]
        {
            ItemID.DD2SquireBetsySword, ItemID.MonkStaffT3, ItemID.DD2BetsyBow, ItemID.FairyQueenRangedItem, ItemID.ApprenticeStaffT3, ItemID.FairyQueenMagicItem,
            ItemID.SparkleGuitar, ItemID.DD2LightningAuraT3Popper, ItemID.DD2FlameburstTowerT3Popper, ItemID.DD2ExplosiveTrapT3Popper,
            ItemID.DD2BallistraTowerT3Popper, ItemID.RainbowWhip
        };
        static int[] postPillars = new int[]
        {
            ItemID.DayBreak, ItemID.SolarEruption, ItemID.Phantasm, ItemID.VortexBeater, ItemID.NebulaArcanum, ItemID.NebulaBlaze, ItemID.StardustCellStaff,
            ItemID.StardustDragonStaff
        };
        static int[] postML = new int[]
        {
            ItemID.StarWrath, ItemID.Meowmere, ItemID.Zenith, ItemID.Terrarian, ItemID.SDMG, ItemID.Celeb2, ItemID.LunarFlareBook, ItemID.LastPrism, ItemID.EmpressBlade,
            ItemID.RainbowCrystalStaff, ItemID.MoonlordTurretStaff
        };
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Magic Item Bag");
            Tooltip.SetDefault("Gives random item depending upon world progression.\nRight click to open.\n");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }
        
        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
            int mechBossesKilled = 0;
            if (NPC.downedMechBoss1)
            {
                mechBossesKilled += 1;
            }
            if (NPC.downedMechBoss2)
            {
                mechBossesKilled += 1;
            }
            if (NPC.downedMechBoss3)
            {
                mechBossesKilled += 1;
            }
            string nextEvent;
            int eventNum;

            if (NPC.downedMoonlord)
            {
                TooltipLine tooltip = new TooltipLine(Mod, "Random Weapon : Magic Item Bag", $"Congratulations! You have defeated the challenge!\nProgress: 20 / 20");
                tooltips.Add(tooltip);
            }
            else
            {
                if (NPC.downedTowers)
                {
                    nextEvent = "Moon Lord";
                    eventNum = 29;
                }
                else if (NPC.downedAncientCultist)
                {
                    nextEvent = "Celestial Pillars";
                    eventNum = 18;
                }
                else if (NPC.downedEmpressOfLight)
                {
                    nextEvent = "Lunatic Cultist and optionally Old One's Army Tier 3";
                    eventNum = 17;
                }
                else if (NPC.downedFishron)
                {
                    nextEvent = "Empress of Light";
                    eventNum = 16;
                }
                else if (NPC.downedChristmasTree && NPC.downedChristmasSantank && NPC.downedChristmasIceQueen)
                {
                    nextEvent = "Duke Fishron and Optionally Martian Madness";
                    eventNum = 15;
                }
                else if (NPC.downedHalloweenTree && NPC.downedHalloweenKing)
                {
                    nextEvent = "Frost Moon";
                    eventNum = 14;
                }
                else if (NPC.downedGolemBoss)
                {
                    nextEvent = "Pumpkin Moon";
                    eventNum = 13;
                }
                else if (NPC.downedPlantBoss)
                {
                    nextEvent = "Golem";
                    eventNum = 12;
                }
                else if (mechBossesKilled == 3)
                {
                    nextEvent = "Plantera and optionally Old One's Army Tier 2";
                    eventNum = 11;
                }
                else if (mechBossesKilled == 2)
                {
                    nextEvent = "Third Mechanical Boss";
                    eventNum = 10;
                }
                else if (NPC.downedMechBossAny)
                {
                    nextEvent = "Second Mechanical Boss";
                    eventNum = 9;
                }
                else if (NPC.downedQueenSlime)
                {
                    nextEvent = "First Mechanical Boss";
                    eventNum = 8;
                }
                else if (Main.hardMode)
                {
                    nextEvent = "Queen Slime";
                    eventNum = 7;
                }
                else if (NPC.downedDeerclops)
                {
                    nextEvent = "Wall of Flesh";
                    eventNum = 6;
                }
                else if (NPC.downedBoss3)
                {
                    nextEvent = "Deerclops and optionally Old One's Army Tier 1";
                    eventNum = 5;
                }
                else if (NPC.downedQueenBee)
                {
                    nextEvent = "Skeletron";
                    eventNum = 4;
                }
                else if (NPC.downedBoss2)
                {
                    nextEvent = "Queen Bee";
                    eventNum = 3;
                }
                else if (NPC.downedBoss1)
                {
                    if (WorldGen.crimson == false)
                    {
                        nextEvent = "Eater of Worlds";
                    }
                    else
                    {
                        nextEvent = "Brain of Cthulhu";
                    }
                    eventNum = 2;
                }
                else if (NPC.downedSlimeKing)
                {
                    nextEvent = "Eye of Cthulhu";
                    eventNum = 1;
                }
                else
                {
                    nextEvent = "King Slime";
                    eventNum = 0;
                }

                TooltipLine tooltip = new TooltipLine(Mod, "RandomWeapons : MagicItemBag", $"Next Challenge is {nextEvent}.\nProgress: {eventNum} / 20.");
                tooltips.Add(tooltip);
            }
        }
        public override void SetDefaults()
        {
            Item.maxStack = 999;
            Item.consumable = true;
            Item.width = 24;
            Item.height = 24;
            Item.rare = ItemRarityID.Blue;
        }
        public override bool CanRightClick()
        {
            return true;
        }
        public override void RightClick(Player player)
        {
            List<int> prehardmode = new List<int>();
            List<int> hardmode = new List<int>();
            List<int> postmoonlord = new List<int>();
            postmoonlord.AddRange(postML);
            hardmode.AddRange(preMechs);
            if (NPC.downedQueenSlime)
            {
                hardmode.AddRange(postQS);
            }
            if (NPC.downedMechBossAny)
            {
                hardmode.AddRange(post1mech);
            }
            if (NPC.downedMechBoss1)
            {
                hardmode.AddRange(postDest);
            }
            if (NPC.downedMechBoss2)
            {
                hardmode.AddRange(postTwin);
            }
            if (NPC.downedMechBoss3)
            {
                hardmode.AddRange(postSP);
            }
            if (NPC.downedMechBoss1 && NPC.downedMechBoss2 && NPC.downedMechBoss3)
            {
                hardmode.AddRange(postAllMechs);
            }
            if (NPC.downedPlantBoss)
            {
                hardmode.AddRange(postPlant);
            }
            if (NPC.downedGolemBoss)
            {
                hardmode.AddRange(postGolem);
            }
            if (NPC.downedHalloweenKing && NPC.downedHalloweenTree)
            {
                hardmode.AddRange(postPM);
            }
            if (NPC.downedChristmasTree && NPC.downedChristmasSantank && NPC.downedChristmasIceQueen)
            {
                hardmode.AddRange(postFM);
            }
            if (NPC.downedFishron)
            {
                hardmode.AddRange(postDF);
            }
            if (NPC.downedEmpressOfLight)
            {
                hardmode.AddRange(postEoL);
            }
            if (NPC.downedTowers)
            {
                hardmode.AddRange(postPillars);
            }
            prehardmode.AddRange(preboss);
            if (NPC.downedBoss1)
            {
                prehardmode.AddRange(postEoC);
            }
            if (NPC.downedBoss2)
            {
                prehardmode.AddRange(postEoWorBoC);
            }
            if (NPC.downedQueenBee)
            {
                prehardmode.AddRange(postQB);
            }
            if (NPC.downedBoss3)
            {
                prehardmode.AddRange(postSkel);
            }
            if (NPC.downedDeerclops)
            {
                prehardmode.AddRange(postDeer);
            }
            int chosenWeapon;
            if (NPC.downedMoonlord)
            {
                chosenWeapon = Main.rand.NextFromCollection<int>(postmoonlord);
            }
            else if (Main.hardMode)
            {
                chosenWeapon = Main.rand.NextFromCollection<int>(hardmode);
            }
            else
            {
                chosenWeapon = Main.rand.NextFromCollection<int>(prehardmode);
            }
            Item item = new Item(chosenWeapon);
            int ammoId = item.useAmmo;
            int maxStack = item.maxStack;
            //Choses random weapon

            player.QuickSpawnItem(player.GetSource_OpenItem(ModContent.ItemType<MagicItemBag>(), "Opened Bag"), chosenWeapon, maxStack);
            if (ammoId == AmmoID.Arrow)
            {
                player.QuickSpawnItem(player.GetSource_OpenItem(ModContent.ItemType<MagicItemBag>(), "Opened Bag"), ItemID.WoodenArrow, 999);
            }
            if (ammoId == AmmoID.Bullet)
            {
                player.QuickSpawnItem(player.GetSource_OpenItem(ModContent.ItemType<MagicItemBag>(), "Opened Bag"), ItemID.MusketBall, 999);
            }
            if (ammoId == AmmoID.Rocket)
            {
                player.QuickSpawnItem(player.GetSource_OpenItem(ModContent.ItemType<MagicItemBag>(), "Opened Bag"), ItemID.RocketI, 999);
            }
            if (ammoId == AmmoID.Flare)
            {
                player.QuickSpawnItem(player.GetSource_OpenItem(ModContent.ItemType<MagicItemBag>(), "Opened Bag"), ItemID.Flare, 999);
            }
            if (ammoId == AmmoID.Dart)
            {
                player.QuickSpawnItem(player.GetSource_OpenItem(ModContent.ItemType<MagicItemBag>(), "Opened Bag"), ItemID.PoisonDart, 999);
            }
            if (ammoId == AmmoID.Snowball)
            {
                player.QuickSpawnItem(player.GetSource_OpenItem(ModContent.ItemType<MagicItemBag>(), "Opened Bag"), ItemID.Snowball, 999);
            }
            if (ammoId == AmmoID.Sand)
            {
                player.QuickSpawnItem(player.GetSource_OpenItem(ModContent.ItemType<MagicItemBag>(), "Opened Bag"), ItemID.SandBlock, 999);
            }
            if (ammoId == AmmoID.FallenStar)
            {
                player.QuickSpawnItem(player.GetSource_OpenItem(ModContent.ItemType<MagicItemBag>(), "Opened Bag"), ItemID.FallenStar, 15);
            }
            if (ammoId == AmmoID.Coin)
            {
                player.QuickSpawnItem(player.GetSource_OpenItem(ModContent.ItemType<MagicItemBag>(), "Opened Bag"), ItemID.PlatinumCoin, 1);
            }
            if (chosenWeapon == ItemID.AleThrowingGlove)
            {
                player.QuickSpawnItem(player.GetSource_OpenItem(ModContent.ItemType<MagicItemBag>(), "Opened Bag"), ItemID.Ale, 15);
            }
            if (ammoId == AmmoID.NailFriendly)
            {
                player.QuickSpawnItem(player.GetSource_OpenItem(ModContent.ItemType<MagicItemBag>(), "Opened Bag"), ItemID.Nail, 999);
            }
            if (ammoId == AmmoID.StyngerBolt)
            {
                player.QuickSpawnItem(player.GetSource_OpenItem(ModContent.ItemType<MagicItemBag>(), "Opened Bag"), ItemID.StyngerBolt, 999);
            }
            if (ammoId == AmmoID.Gel)
            {
                player.QuickSpawnItem(player.GetSource_OpenItem(ModContent.ItemType<MagicItemBag>(), "Opened Bag"), ItemID.Gel, 999);
            }
            if (ammoId == AmmoID.Stake)
            {
                player.QuickSpawnItem(player.GetSource_OpenItem(ModContent.ItemType<MagicItemBag>(), "Opened Bag"), ItemID.Stake, 999);
            }
            if (ammoId == AmmoID.CandyCorn)
            {
                player.QuickSpawnItem(player.GetSource_OpenItem(ModContent.ItemType<MagicItemBag>(), "Opened Bag"), ItemID.CandyCorn, 999);
            }
            if (ammoId == AmmoID.JackOLantern)
            {
                player.QuickSpawnItem(player.GetSource_OpenItem(ModContent.ItemType<MagicItemBag>(), "Opened Bag"), ItemID.ExplosiveJackOLantern, 999);
            } 
        }
    }
}
