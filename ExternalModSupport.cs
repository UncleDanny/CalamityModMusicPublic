using CalamityModMusic.Items.Placeables;
using System.Collections.Generic;
using Terraria.Localization;
using Terraria.ModLoader;

namespace CalamityModMusic
{
    public class ExternalModSupport : ModSystem
    {
        public override void PostSetupContent()
        {
            BossChecklistSetup();
            MusicDisplaySetup();
        }

        private void BossChecklistSetup()
        {
            Mod calamity = CalamityModMusic.Instance.calamity;
            Mod bossChecklist = CalamityModMusic.Instance.bossChecklist;

            if (calamity != null && bossChecklist != null)
            {
                bossChecklist.Call("SubmitEntryCollectibles", CalamityModMusic.Instance, new Dictionary<string, object>()
                {
                    { "CalamityMod DesertScourge", ModContent.ItemType<DesertScourgeMusicBox>() },
                    { "CalamityMod GiantClam", ModContent.ItemType<SunkenSeaMusicBox>() },
                    { "CalamityMod Crabulon", ModContent.ItemType<CrabulonMusicBox>() },
                    { "CalamityMod HiveMind", ModContent.ItemType<HiveMindMusicBox>() },
                    { "CalamityMod Perforators", ModContent.ItemType<PerforatorsMusicBox>() },
                    { "CalamityMod SlimeGod", ModContent.ItemType<SlimeGodMusicBox>() },
                    { "CalamityMod Cryogen", ModContent.ItemType<CryogenMusicBox>() },
                    { "CalamityMod AquaticScourge", ModContent.ItemType<AquaticScourgeMusicBox>() },
                    { "CalamityMod BrimstoneElemental", ModContent.ItemType<BrimstoneElementalMusicBox>() },
                    { "CalamityMod CalamitasClone", ModContent.ItemType<CalamitasCloneMusicBox>() },
                    { "CalamityMod Leviathan", new List<int>() { ModContent.ItemType<LeviathanMusicBox>(), ModContent.ItemType<AnahitaMusicBox>() } },
                    { "CalamityMod AstrumAureus", ModContent.ItemType<AstrumAureusMusicBox>() },
                    { "CalamityMod PlaguebringerGoliath", ModContent.ItemType<PlaguebringerGoliathMusicBox>() },
                    { "CalamityMod Ravager", ModContent.ItemType<RavagerMusicBox>() },
                    { "CalamityMod AstrumDeus", ModContent.ItemType<AstrumDeusMusicBox>() },
                    { "CalamityMod ProfanedGuardians", ModContent.ItemType<ProfanedGuardiansMusicBox>() },
                    { "CalamityMod Dragonfolly", ModContent.ItemType<DragonfollyMusicBox>() },
                    { "CalamityMod Providence", ModContent.ItemType<ProvidenceMusicBox>() },
                    { "CalamityMod CeaselessVoid", ModContent.ItemType<CeaselessVoidMusicBox>() },
                    { "CalamityMod StormWeaver", ModContent.ItemType<StormWeaverMusicBox>() },
                    { "CalamityMod Signus", ModContent.ItemType<SignusMusicBox>() },
                    { "CalamityMod Polterghast", ModContent.ItemType<PolterghastMusicBox>() },
                    { "CalamityMod OldDuke", ModContent.ItemType<OldDukeMusicBox>() },
                    { "CalamityMod DevourerofGods", new List<int>() { ModContent.ItemType<DevourerofGodsPhase1MusicBox>(), ModContent.ItemType<DevourerofGodsPhase2MusicBox>() } },
                    { "CalamityMod Yharon", new List<int>() { ModContent.ItemType<YharonPhase1MusicBox>(), ModContent.ItemType<YharonPhase2MusicBox>() } },
                    { "CalamityMod ExoMechs", new List<int>() { ModContent.ItemType<ExoMechsMusicBox>() } },
                    { "CalamityMod Calamitas", new List<int>() { ModContent.ItemType<CalamitasPhase1MusicBox>(), ModContent.ItemType<CalamitasPhase2MusicBox>(), ModContent.ItemType<CalamitasPhase3MusicBox>(), ModContent.ItemType<CalamitasDefeatMusicBox>() } },
                    { "CalamityMod AcidRainT1", ModContent.ItemType<AcidRainTier1MusicBox>() },
                    { "CalamityMod AcidRainT2", ModContent.ItemType<AcidRainTier1MusicBox>() }, //ModContent.ItemType<AcidRainTier2MusicBox>()
                    { "CalamityMod AcidRainT3", ModContent.ItemType<AcidRainTier3MusicBox>() },
                    { "CalamityMod BossRush", new List<int>() { ModContent.ItemType<BossRushTier1MusicBox>(), ModContent.ItemType<BossRushTier2MusicBox>(), ModContent.ItemType<BossRushTier3MusicBox>(), ModContent.ItemType<BossRushTier4MusicBox>()/*, ModContent.ItemType<BossRushTier5MusicBox>() */} }
                });
            }
        }

        private void MusicDisplaySetup()
        {
            Mod musicDisplay = CalamityModMusic.Instance.musicDisplay;
            if (musicDisplay is null)
                return;

            void AddMusic(string songKey, string authorKey)
            {
                short slot = (short)MusicLoader.GetMusicSlot(Mod, $"Sounds/Music/{songKey}");
                musicDisplay.Call("AddMusic", slot, Language.GetTextValue("Mods.CalamityModMusic.ModSupport.MusicDisplay.SongNames." + songKey), Language.GetTextValue("Mods.CalamityModMusic.ModSupport.MusicDisplay.Authors." + authorKey), Mod.DisplayName);
            }

            AddMusic("AbyssLayer1", "HeartPlusUp");
            AddMusic("AbyssLayer2", "DMDOKURO");
            AddMusic("AbyssLayer3", "RoverdriveX");
            AddMusic("AbyssLayer4", "DMDOKURO");
            AddMusic("AcidRainTier1", "RoverdriveX");
            AddMusic("AcidRainTier3", "PinpinNeon");
            AddMusic("Anahita", "DMDOKURO");
            AddMusic("AnahitasLure", "DMDOKURO");
            AddMusic("AquaticScourge", "DMDOKURO");
            AddMusic("AstralInfection", "DMDOKURO");
            AddMusic("AstralInfectionUnderground", "DMDOKURO");
            AddMusic("AstrumAureus", "DMDOKURO");
            AddMusic("AstrumDeus", "DMDOKURO");
            AddMusic("BioLab", "HeartPlusUp");
            AddMusic("BossRushTier1", "CDMusic");
            AddMusic("BossRushTier2", "CDMusic");
            AddMusic("BossRushTier3", "CDMusic");
            AddMusic("BossRushTier4", "CDMusic");
            AddMusic("BrimstoneCrags", "DMDOKURO");
            AddMusic("BrimstoneElemental", "DMDOKURO");
            AddMusic("CalamitasClone", "DMDOKURO");
            AddMusic("CalamitasDefeat", "DMDOKURO");
            AddMusic("CalamitasDefeat_LongFade", "DMDOKURO");
            AddMusic("CalamitasPhase1", "DMDOKURO");
            AddMusic("CalamitasPhase2", "DMDOKURO");
            AddMusic("CalamitasPhase3", "DMDOKURO");
            AddMusic("CalamityTitle", "DMDOKURO");
            AddMusic("CeaselessVoid", "DMDOKURO");
            AddMusic("Crabulon", "DMDOKURO");
            AddMusic("Cryogen", "DMDOKURO");
            AddMusic("DesertScourge", "DMDOKURO");
            AddMusic("DevourerofGodsEulogy", "DMDOKURO");
            AddMusic("DevourerofGodsPhase1", "DMDOKURO");
            AddMusic("DevourerofGodsPhase2", "DMDOKURO");
            AddMusic("Dragonfolly", "DMDOKURO");
            AddMusic("ExoMechs", "PinpinNeon");
            AddMusic("HiveMind", "DMDOKUROFeature");
            AddMusic("Interlude1", "DMDOKURO");
            AddMusic("Interlude2", "DMDOKURO");
            AddMusic("Interlude3", "DMDOKURO");
            AddMusic("Leviathan", "DMDOKURO");
            AddMusic("OldDuke", "DMDOKURO");
            AddMusic("Perforators", "DMDOKUROFeature");
            AddMusic("PlaguebringerGoliath", "DMDOKURO");
            AddMusic("Polterghast", "DMDOKURO");
            AddMusic("PrimordialWyrm", "DMDOKURO");
            AddMusic("ProfanedGuardians", "DMDOKURO");
            AddMusic("Providence", "DMDOKURO");
            AddMusic("Ravager", "DMDOKURO");
            AddMusic("Signus", "DMDOKURO");
            AddMusic("SlimeGod", "DMDOKUROFeature");
            AddMusic("StormWeaver", "DMDOKURO");
            AddMusic("SulphurousSeaDay", "DMDOKURO");
            AddMusic("SulphurousSeaNight", "HeartPlusUp");
            AddMusic("SunkenSea", "DMDOKURO");
            AddMusic("YharonLegacy", "DMDOKURO");
            AddMusic("YharonPhase1", "DMDOKURO");
            AddMusic("YharonPhase2", "DMDOKURO");
        }
    }
}
