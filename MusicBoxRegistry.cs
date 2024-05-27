using Terraria;
using Terraria.ModLoader;
using AbyssLayer1MusicBox = CalamityModMusic.Items.Placeables.AbyssLayer1MusicBox;
using AbyssLayer2MusicBox = CalamityModMusic.Items.Placeables.AbyssLayer2MusicBox;
using AbyssLayer3MusicBox = CalamityModMusic.Items.Placeables.AbyssLayer3MusicBox;
using AbyssLayer4MusicBox = CalamityModMusic.Items.Placeables.AbyssLayer4MusicBox;
using AcidRainTier1MusicBox = CalamityModMusic.Items.Placeables.AcidRainTier1MusicBox;
// using AcidRainTier2MusicBox = CalamityModMusic.Items.Placeables.AcidRainTier2MusicBox;
using AcidRainTier3MusicBox = CalamityModMusic.Items.Placeables.AcidRainTier3MusicBox;
using AnahitaMusicBox = CalamityModMusic.Items.Placeables.AnahitaMusicBox;
using AnahitasLureMusicBox = CalamityModMusic.Items.Placeables.AnahitasLureMusicBox;
using AquaticScourgeMusicBox = CalamityModMusic.Items.Placeables.AquaticScourgeMusicBox;
using AstralInfectionMusicBox = CalamityModMusic.Items.Placeables.AstralInfectionMusicBox;
using AstralInfectionUndergroundMusicBox = CalamityModMusic.Items.Placeables.AstralInfectionUndergroundMusicBox;
using AstrumAureusMusicBox = CalamityModMusic.Items.Placeables.AstrumAureusMusicBox;
using AstrumDeusMusicBox = CalamityModMusic.Items.Placeables.AstrumDeusMusicBox;
using BioLabMusicBox = CalamityModMusic.Items.Placeables.BioLabMusicBox;
using BossRushTier1MusicBox = CalamityModMusic.Items.Placeables.BossRushTier1MusicBox;
using BossRushTier2MusicBox = CalamityModMusic.Items.Placeables.BossRushTier2MusicBox;
using BossRushTier3MusicBox = CalamityModMusic.Items.Placeables.BossRushTier3MusicBox;
using BossRushTier4MusicBox = CalamityModMusic.Items.Placeables.BossRushTier4MusicBox;
// using BossRushTier5MusicBox = CalamityModMusic.Items.Placeables.BossRushTier5MusicBox;
using BrimstoneCragsMusicBox = CalamityModMusic.Items.Placeables.BrimstoneCragsMusicBox;
using BrimstoneElementalMusicBox = CalamityModMusic.Items.Placeables.BrimstoneElementalMusicBox;
using CalamitasCloneMusicBox = CalamityModMusic.Items.Placeables.CalamitasCloneMusicBox;
using CalamitasDefeatMusicBox = CalamityModMusic.Items.Placeables.CalamitasDefeatMusicBox;
using CalamitasPhase1MusicBox = CalamityModMusic.Items.Placeables.CalamitasPhase1MusicBox;
using CalamitasPhase2MusicBox = CalamityModMusic.Items.Placeables.CalamitasPhase2MusicBox;
using CalamitasPhase3MusicBox = CalamityModMusic.Items.Placeables.CalamitasPhase3MusicBox;
using CalamityTitleMusicBox = CalamityModMusic.Items.Placeables.CalamityTitleMusicBox;
using CeaselessVoidMusicBox = CalamityModMusic.Items.Placeables.CeaselessVoidMusicBox;
using CrabulonMusicBox = CalamityModMusic.Items.Placeables.CrabulonMusicBox;
using CryogenMusicBox = CalamityModMusic.Items.Placeables.CryogenMusicBox;
using DesertScourgeMusicBox = CalamityModMusic.Items.Placeables.DesertScourgeMusicBox;
using DevourerofGodsEulogyMusicBox = CalamityModMusic.Items.Placeables.DevourerofGodsEulogyMusicBox;
using DevourerofGodsPhase1MusicBox = CalamityModMusic.Items.Placeables.DevourerofGodsPhase1MusicBox;
using DevourerofGodsPhase2MusicBox = CalamityModMusic.Items.Placeables.DevourerofGodsPhase2MusicBox;
using DragonfollyMusicBox = CalamityModMusic.Items.Placeables.DragonfollyMusicBox;
using ExoMechsMusicBox = CalamityModMusic.Items.Placeables.ExoMechsMusicBox;
using HiveMindMusicBox = CalamityModMusic.Items.Placeables.HiveMindMusicBox;
using Interlude1MusicBox = CalamityModMusic.Items.Placeables.Interlude1MusicBox;
using Interlude2MusicBox = CalamityModMusic.Items.Placeables.Interlude2MusicBox;
using Interlude3MusicBox = CalamityModMusic.Items.Placeables.Interlude3MusicBox;
using LeviathanMusicBox = CalamityModMusic.Items.Placeables.LeviathanMusicBox;
using OldDukeMusicBox = CalamityModMusic.Items.Placeables.OldDukeMusicBox;
using PerforatorsMusicBox = CalamityModMusic.Items.Placeables.PerforatorsMusicBox;
using PlaguebringerGoliathMusicBox = CalamityModMusic.Items.Placeables.PlaguebringerGoliathMusicBox;
using PolterghastMusicBox = CalamityModMusic.Items.Placeables.PolterghastMusicBox;
using PrimordialWyrmMusicBox = CalamityModMusic.Items.Placeables.PrimordialWyrmMusicBox;
using ProfanedGuardiansMusicBox = CalamityModMusic.Items.Placeables.ProfanedGuardiansMusicBox;
using ProvidenceMusicBox = CalamityModMusic.Items.Placeables.ProvidenceMusicBox;
using RavagerMusicBox = CalamityModMusic.Items.Placeables.RavagerMusicBox;
using SignusMusicBox = CalamityModMusic.Items.Placeables.SignusMusicBox;
using SlimeGodMusicBox = CalamityModMusic.Items.Placeables.SlimeGodMusicBox;
using StormWeaverMusicBox = CalamityModMusic.Items.Placeables.StormWeaverMusicBox;
using SulphurousSeaDayMusicBox = CalamityModMusic.Items.Placeables.SulphurousSeaDayMusicBox;
using SulphurousSeaNightMusicBox = CalamityModMusic.Items.Placeables.SulphurousSeaNightMusicBox;
using SunkenSeaMusicBox = CalamityModMusic.Items.Placeables.SunkenSeaMusicBox;
using YharonLegacyMusicBox = CalamityModMusic.Items.Placeables.YharonLegacyMusicBox;
using YharonPhase1MusicBox = CalamityModMusic.Items.Placeables.YharonPhase1MusicBox;
using YharonPhase2MusicBox = CalamityModMusic.Items.Placeables.YharonPhase2MusicBox;

namespace CalamityModMusic
{
    public class MusicBoxRegistry : ModSystem
    {
        private static void AddMusicBox(string musicFile, int itemID, int tileID)
        {
            Mod musicMod = CalamityModMusic.Instance;
            int musicID = MusicLoader.GetMusicSlot(musicMod, musicFile);
            MusicLoader.AddMusicBox(musicMod, musicID, itemID, tileID);
        }

        public override void PostSetupContent()
        {
            if (!Main.dedServ)
            {
                // Boss Music - Alphabetised.
                AddMusicBox("Sounds/Music/Anahita", ModContent.ItemType<AnahitaMusicBox>(), ModContent.TileType<Tiles.AnahitaMusicBox>());
                AddMusicBox("Sounds/Music/AnahitasLure", ModContent.ItemType<AnahitasLureMusicBox>(), ModContent.TileType<Tiles.AnahitasLureMusicBox>());
                AddMusicBox("Sounds/Music/AquaticScourge", ModContent.ItemType<AquaticScourgeMusicBox>(), ModContent.TileType<Tiles.AquaticScourgeMusicBox>());
                AddMusicBox("Sounds/Music/AstrumAureus", ModContent.ItemType<AstrumAureusMusicBox>(), ModContent.TileType<Tiles.AstrumAureusMusicBox>());
                AddMusicBox("Sounds/Music/AstrumDeus", ModContent.ItemType<AstrumDeusMusicBox>(), ModContent.TileType<Tiles.AstrumDeusMusicBox>());
                AddMusicBox("Sounds/Music/BrimstoneElemental", ModContent.ItemType<BrimstoneElementalMusicBox>(), ModContent.TileType<Tiles.BrimstoneElementalMusicBox>());
                AddMusicBox("Sounds/Music/CalamitasClone", ModContent.ItemType<CalamitasCloneMusicBox>(), ModContent.TileType<Tiles.CalamitasCloneMusicBox>());
                AddMusicBox("Sounds/Music/CalamitasDefeat", ModContent.ItemType<CalamitasDefeatMusicBox>(), ModContent.TileType<Tiles.CalamitasDefeatMusicBox>());
                AddMusicBox("Sounds/Music/CalamitasPhase1", ModContent.ItemType<CalamitasPhase1MusicBox>(), ModContent.TileType<Tiles.CalamitasPhase1MusicBox>());
                AddMusicBox("Sounds/Music/CalamitasPhase2", ModContent.ItemType<CalamitasPhase2MusicBox>(), ModContent.TileType<Tiles.CalamitasPhase2MusicBox>());
                AddMusicBox("Sounds/Music/CalamitasPhase3", ModContent.ItemType<CalamitasPhase3MusicBox>(), ModContent.TileType<Tiles.CalamitasPhase3MusicBox>());
                AddMusicBox("Sounds/Music/CeaselessVoid", ModContent.ItemType<CeaselessVoidMusicBox>(), ModContent.TileType<Tiles.CeaselessVoidMusicBox>());
                AddMusicBox("Sounds/Music/Crabulon", ModContent.ItemType<CrabulonMusicBox>(), ModContent.TileType<Tiles.CrabulonMusicBox>());
                AddMusicBox("Sounds/Music/Cryogen", ModContent.ItemType<CryogenMusicBox>(), ModContent.TileType<Tiles.CryogenMusicBox>());
                AddMusicBox("Sounds/Music/DesertScourge", ModContent.ItemType<DesertScourgeMusicBox>(), ModContent.TileType<Tiles.DesertScourgeMusicBox>());
                AddMusicBox("Sounds/Music/DevourerofGodsPhase1", ModContent.ItemType<DevourerofGodsPhase1MusicBox>(), ModContent.TileType<Tiles.DevourerofGodsPhase1MusicBox>());
                AddMusicBox("Sounds/Music/DevourerofGodsPhase2", ModContent.ItemType<DevourerofGodsPhase2MusicBox>(), ModContent.TileType<Tiles.DevourerofGodsPhase2MusicBox>());
                AddMusicBox("Sounds/Music/Dragonfolly", ModContent.ItemType<DragonfollyMusicBox>(), ModContent.TileType<Tiles.DragonfollyMusicBox>());
                AddMusicBox("Sounds/Music/ExoMechs", ModContent.ItemType<ExoMechsMusicBox>(), ModContent.TileType<Tiles.ExoMechsMusicBox>());
                AddMusicBox("Sounds/Music/HiveMind", ModContent.ItemType<HiveMindMusicBox>(), ModContent.TileType<Tiles.HiveMindMusicBox>());
                AddMusicBox("Sounds/Music/Leviathan", ModContent.ItemType<LeviathanMusicBox>(), ModContent.TileType<Tiles.LeviathanMusicBox>());
                AddMusicBox("Sounds/Music/OldDuke", ModContent.ItemType<OldDukeMusicBox>(), ModContent.TileType<Tiles.OldDukeMusicBox>());
                AddMusicBox("Sounds/Music/Perforators", ModContent.ItemType<PerforatorsMusicBox>(), ModContent.TileType<Tiles.PerforatorsMusicBox>());
                AddMusicBox("Sounds/Music/PlaguebringerGoliath", ModContent.ItemType<PlaguebringerGoliathMusicBox>(), ModContent.TileType<Tiles.PlaguebringerGoliathMusicBox>());
                AddMusicBox("Sounds/Music/Polterghast", ModContent.ItemType<PolterghastMusicBox>(), ModContent.TileType<Tiles.PolterghastMusicBox>());
                AddMusicBox("Sounds/Music/PrimordialWyrm", ModContent.ItemType<PrimordialWyrmMusicBox>(), ModContent.TileType<Tiles.PrimordialWyrmMusicBox>());
                AddMusicBox("Sounds/Music/ProfanedGuardians", ModContent.ItemType<ProfanedGuardiansMusicBox>(), ModContent.TileType<Tiles.ProfanedGuardiansMusicBox>());
                AddMusicBox("Sounds/Music/Providence", ModContent.ItemType<ProvidenceMusicBox>(), ModContent.TileType<Tiles.ProvidenceMusicBox>()); //Seamless
                AddMusicBox("Sounds/Music/Ravager", ModContent.ItemType<RavagerMusicBox>(), ModContent.TileType<Tiles.RavagerMusicBox>());
                AddMusicBox("Sounds/Music/Signus", ModContent.ItemType<SignusMusicBox>(), ModContent.TileType<Tiles.SignusMusicBox>());
                AddMusicBox("Sounds/Music/SlimeGod", ModContent.ItemType<SlimeGodMusicBox>(), ModContent.TileType<Tiles.SlimeGodMusicBox>());
                AddMusicBox("Sounds/Music/StormWeaver", ModContent.ItemType<StormWeaverMusicBox>(), ModContent.TileType<Tiles.StormWeaverMusicBox>());
                AddMusicBox("Sounds/Music/YharonLegacy", ModContent.ItemType<YharonLegacyMusicBox>(), ModContent.TileType<Tiles.YharonLegacyMusicBox>());
                AddMusicBox("Sounds/Music/YharonPhase1", ModContent.ItemType<YharonPhase1MusicBox>(), ModContent.TileType<Tiles.YharonPhase1MusicBox>());
                AddMusicBox("Sounds/Music/YharonPhase2", ModContent.ItemType<YharonPhase2MusicBox>(), ModContent.TileType<Tiles.YharonPhase2MusicBox>());

                // Biome Music.
                AddMusicBox("Sounds/Music/AbyssLayer1", ModContent.ItemType<AbyssLayer1MusicBox>(), ModContent.TileType<Tiles.AbyssLayer1MusicBox>());
                AddMusicBox("Sounds/Music/AbyssLayer2", ModContent.ItemType<AbyssLayer2MusicBox>(), ModContent.TileType<Tiles.AbyssLayer2MusicBox>());
                AddMusicBox("Sounds/Music/AbyssLayer3", ModContent.ItemType<AbyssLayer3MusicBox>(), ModContent.TileType<Tiles.AbyssLayer3MusicBox>());
                AddMusicBox("Sounds/Music/AbyssLayer4", ModContent.ItemType<AbyssLayer4MusicBox>(), ModContent.TileType<Tiles.AbyssLayer4MusicBox>());
                AddMusicBox("Sounds/Music/AstralInfection", ModContent.ItemType<AstralInfectionMusicBox>(), ModContent.TileType<Tiles.AstralInfectionMusicBox>()); //Seamless
                AddMusicBox("Sounds/Music/AstralInfectionUnderground", ModContent.ItemType<AstralInfectionUndergroundMusicBox>(), ModContent.TileType<Tiles.AstralInfectionUndergroundMusicBox>()); //Seamless
                AddMusicBox("Sounds/Music/BioLab", ModContent.ItemType<BioLabMusicBox>(), ModContent.TileType<Tiles.BioLabMusicBox>());
                AddMusicBox("Sounds/Music/BrimstoneCrags", ModContent.ItemType<BrimstoneCragsMusicBox>(), ModContent.TileType<Tiles.BrimstoneCragsMusicBox>());
                AddMusicBox("Sounds/Music/SulphurousSeaDay", ModContent.ItemType<SulphurousSeaDayMusicBox>(), ModContent.TileType<Tiles.SulphurousSeaDayMusicBox>());
                AddMusicBox("Sounds/Music/SulphurousSeaNight", ModContent.ItemType<SulphurousSeaNightMusicBox>(), ModContent.TileType<Tiles.SulphurousSeaNightMusicBox>());
                AddMusicBox("Sounds/Music/SunkenSea", ModContent.ItemType<SunkenSeaMusicBox>(), ModContent.TileType<Tiles.SunkenSeaMusicBox>());

                // Event Music.
                AddMusicBox("Sounds/Music/AcidRainTier1", ModContent.ItemType<AcidRainTier1MusicBox>(), ModContent.TileType<Tiles.AcidRainTier1MusicBox>()); //Seamless
                //AddMusicBox("Sounds/Music/AcidRainTier2", ModContent.ItemType<AcidRainTier2MusicBox>(), ModContent.TileType<Tiles.AcidRainTier2MusicBox>());
                AddMusicBox("Sounds/Music/AcidRainTier3", ModContent.ItemType<AcidRainTier3MusicBox>(), ModContent.TileType<Tiles.AcidRainTier3MusicBox>());
                AddMusicBox("Sounds/Music/BossRushTier1", ModContent.ItemType<BossRushTier1MusicBox>(), ModContent.TileType<Tiles.BossRushTier1MusicBox>());
                AddMusicBox("Sounds/Music/BossRushTier2", ModContent.ItemType<BossRushTier2MusicBox>(), ModContent.TileType<Tiles.BossRushTier2MusicBox>());
                AddMusicBox("Sounds/Music/BossRushTier3", ModContent.ItemType<BossRushTier3MusicBox>(), ModContent.TileType<Tiles.BossRushTier3MusicBox>());
                AddMusicBox("Sounds/Music/BossRushTier4", ModContent.ItemType<BossRushTier4MusicBox>(), ModContent.TileType<Tiles.BossRushTier4MusicBox>());
                //AddMusicBox("Sounds/Music/BossRushTier5", ModContent.ItemType<BossRushTier5MusicBox>(), ModContent.TileType<Tiles.BossRushTier5MusicBox>());

                // Other Music.
                AddMusicBox("Sounds/Music/CalamityTitle", ModContent.ItemType<CalamityTitleMusicBox>(), ModContent.TileType<Tiles.CalamityTitleMusicBox>()); //Seamless
                AddMusicBox("Sounds/Music/DevourerofGodsEulogy", ModContent.ItemType<DevourerofGodsEulogyMusicBox>(), ModContent.TileType<Tiles.DevourerofGodsEulogyMusicBox>());
                AddMusicBox("Sounds/Music/Interlude1", ModContent.ItemType<Interlude1MusicBox>(), ModContent.TileType<Tiles.Interlude1MusicBox>());
                AddMusicBox("Sounds/Music/Interlude2", ModContent.ItemType<Interlude2MusicBox>(), ModContent.TileType<Tiles.Interlude2MusicBox>());
                AddMusicBox("Sounds/Music/Interlude3", ModContent.ItemType<Interlude3MusicBox>(), ModContent.TileType<Tiles.Interlude3MusicBox>());
            }
        }
    }
}
