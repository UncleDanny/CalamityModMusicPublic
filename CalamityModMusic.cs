﻿using CalamityModMusic.Items.Placeables;
using CalamityModMusic.Tiles;
using Microsoft.Xna.Framework.Audio;
using MonoMod.Cil;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;
using AbyssLowerMusicbox = CalamityModMusic.Items.Placeables.AbyssLowerMusicbox;
using AdultEidolonWyrmMusicbox = CalamityModMusic.Items.Placeables.AdultEidolonWyrmMusicbox;
using AquaticScourgeMusicbox = CalamityModMusic.Items.Placeables.AquaticScourgeMusicbox;
using AstrageldonMusicbox = CalamityModMusic.Items.Placeables.AstrageldonMusicbox;
using AstralMusicbox = CalamityModMusic.Items.Placeables.AstralMusicbox;
using AstrumDeusMusicbox = CalamityModMusic.Items.Placeables.AstrumDeusMusicbox;
using BossRush1Musicbox = CalamityModMusic.Items.Placeables.BossRushTier1MusicboxItem;
using BossRush2Musicbox = CalamityModMusic.Items.Placeables.BossRushTier2MusicboxItem;
using BossRush3Musicbox = CalamityModMusic.Items.Placeables.BossRushTier3MusicboxItem;
using BossRush4Musicbox = CalamityModMusic.Items.Placeables.BossRushTier4MusicboxItem;
using BossRush5Musicbox = CalamityModMusic.Items.Placeables.BossRushTier5MusicboxItem;
using BrimmyMusicbox = CalamityModMusic.Items.Placeables.BrimmyMusicbox;
using BumblebirbMusicbox = CalamityModMusic.Items.Placeables.BumblebirbMusicbox;
using CalamitasMusicbox = CalamityModMusic.Items.Placeables.CalamitasMusicbox;
using CalamityMusicbox = CalamityModMusic.Items.Placeables.CalamityMusicbox;
using CeaselessVoidMusicbox = CalamityModMusic.Items.Placeables.CeaselessVoidMusicbox;
using CrabulonMusicbox = CalamityModMusic.Items.Placeables.CrabulonMusicbox;
using CragMusicbox = CalamityModMusic.Items.Placeables.CragMusicbox;
using CryogenMusicbox = CalamityModMusic.Items.Placeables.CryogenMusicbox;
using DesertScourgeMusicbox = CalamityModMusic.Items.Placeables.DesertScourgeMusicbox;
using DoGMusicbox = CalamityModMusic.Items.Placeables.DoGMusicbox;
using DoGP2Musicbox = CalamityModMusic.Items.Placeables.DoGP2Musicbox;
using ExoMechsMusicbox = CalamityModMusic.Items.Placeables.ExoMechsMusicboxItem;
using HigherAbyssMusicbox = CalamityModMusic.Items.Placeables.HigherAbyssMusicbox;
using HiveMindMusicbox = CalamityModMusic.Items.Placeables.HiveMindMusicbox;
using LeviathanMusicbox = CalamityModMusic.Items.Placeables.LeviathanMusicbox;
using PerforatorMusicbox = CalamityModMusic.Items.Placeables.PerforatorMusicbox;
using PlaguebringerMusicbox = CalamityModMusic.Items.Placeables.PlaguebringerMusicbox;
using PolterghastMusicbox = CalamityModMusic.Items.Placeables.PolterghastMusicbox;
using ProfanedGuardianMusicbox = CalamityModMusic.Items.Placeables.ProfanedGuardianMusicbox;
using ProvidenceMusicbox = CalamityModMusic.Items.Placeables.ProvidenceMusicbox;
using RavagerMusicbox = CalamityModMusic.Items.Placeables.RavagerMusicbox;
using SCalAMusicbox = CalamityModMusic.Items.Placeables.SCalAMusicbox;
using SCalEMusicbox = CalamityModMusic.Items.Placeables.SCalEMusicbox;
using SCalGMusicbox = CalamityModMusic.Items.Placeables.SCalGMusicbox;
using SCalLMusicbox = CalamityModMusic.Items.Placeables.SCalLMusicbox;
using SignusMusicbox = CalamityModMusic.Items.Placeables.SignusMusicbox;
using SirenIdleMusicbox = CalamityModMusic.Items.Placeables.SirenIdleMusicbox;
using SirenMusicbox = CalamityModMusic.Items.Placeables.SirenMusicbox;
using SlimeGodMusicbox = CalamityModMusic.Items.Placeables.SlimeGodMusicbox;
using StormWeaverMusicbox = CalamityModMusic.Items.Placeables.StormWeaverMusicbox;
using SulphurousMusicbox = CalamityModMusic.Items.Placeables.SulphurousMusicbox;
using SunkenSeaMusicbox = CalamityModMusic.Items.Placeables.SunkenSeaMusicbox;
using VoidMusicbox = CalamityModMusic.Items.Placeables.VoidMusicbox;
using Yharon1Musicbox = CalamityModMusic.Items.Placeables.Yharon1Musicbox;
using Yharon2Musicbox = CalamityModMusic.Items.Placeables.Yharon2Musicbox;
using Yharon3Musicbox = CalamityModMusic.Items.Placeables.Yharon3Musicbox;

namespace CalamityModMusic
{
	public class CalamityModMusic : Mod
	{
		public static CalamityModMusic Instance;
		internal static CalamityMusicConfig Config => CalamityMusicConfig.Instance;

		private bool stopTitleMusic;
		private ManualResetEvent titleMusicStopped;

		private int customTitleMusicSlot;

		private void TitleMusicIL(ILContext il)
		{
			var c = new ILCursor(il);
			c.GotoNext(MoveType.After, i => i.MatchLdfld<Main>("newMusic"));
			c.EmitDelegate<Func<int, int>>(newMusic =>
				newMusic == MusicID.Title ? customTitleMusicSlot : newMusic);
		}

		public CalamityModMusic()
		{
			Instance = this;
		}

		public override void Load()
		{
			if (!Main.dedServ)
			{
				// Boss Music - Alphabetised.
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/AdultEidolonWyrm"), ModContent.ItemType<AdultEidolonWyrmMusicbox>(), ModContent.TileType<Tiles.AdultEidolonWyrmMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Anahita"), ModContent.ItemType<SirenMusicbox>(), ModContent.TileType<Tiles.SirenMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/AnahitaPreboss"), ModContent.ItemType<SirenIdleMusicbox>(), ModContent.TileType<Tiles.SirenIdleMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/AquaticScourge"), ModContent.ItemType<AquaticScourgeMusicbox>(), ModContent.TileType<Tiles.AquaticScourgeMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/AstrumAureus"), ModContent.ItemType<AstrageldonMusicbox>(), ModContent.TileType<Tiles.AstrageldonMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/AstrumDeus"), ModContent.ItemType<AstrumDeusMusicbox>(), ModContent.TileType<Tiles.AstrumDeusMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/BrimstoneElemental"), ModContent.ItemType<BrimmyMusicbox>(), ModContent.TileType<Tiles.BrimmyMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Calamitas"), ModContent.ItemType<CalamitasMusicbox>(), ModContent.TileType<Tiles.CalamitasMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Void"), ModContent.ItemType<CeaselessVoidMusicbox>(), ModContent.TileType<Tiles.CeaselessVoidMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Crabulon"), ModContent.ItemType<CrabulonMusicbox>(), ModContent.TileType<Tiles.CrabulonMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Cryogen"), ModContent.ItemType<CryogenMusicbox>(), ModContent.TileType<Tiles.CryogenMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/DesertScourge"), ModContent.ItemType<DesertScourgeMusicbox>(), ModContent.TileType<Tiles.DesertScourgeMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/DevourerOfGodsP1"), ModContent.ItemType<DoGMusicbox>(), ModContent.TileType<Tiles.DoGMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/DevourerOfGodsP2"), ModContent.ItemType<DoGP2Musicbox>(), ModContent.TileType<Tiles.DoGP2Musicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Dragonfolly"), ModContent.ItemType<BumblebirbMusicbox>(), ModContent.TileType<Tiles.BumblebirbMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/ExoMechs"), ModContent.ItemType<ExoMechsMusicboxItem>(), ModContent.TileType<Tiles.ExoMechsMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/HiveMind"), ModContent.ItemType<HiveMindMusicbox>(), ModContent.TileType<Tiles.HiveMindMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/LeviathanAndAnahita"), ModContent.ItemType<LeviathanMusicbox>(), ModContent.TileType<Tiles.LeviathanMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/BoomerDuke"), ModContent.ItemType<BoomerDukeMusicbox>(), ModContent.TileType<Tiles.BoomerDukeMusicboxTile>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Perforators"), ModContent.ItemType<PerforatorMusicbox>(), ModContent.TileType<Tiles.PerforatorMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/PlaguebringerGoliath"), ModContent.ItemType<PlaguebringerMusicbox>(), ModContent.TileType<Tiles.PlaguebringerMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Polterghast"), ModContent.ItemType<PolterghastMusicbox>(), ModContent.TileType<Tiles.PolterghastMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Guardians"), ModContent.ItemType<ProfanedGuardianMusicbox>(), ModContent.TileType<Tiles.ProfanedGuardianMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Providence"), ModContent.ItemType<ProvidenceMusicbox>(), ModContent.TileType<Tiles.ProvidenceMusicbox>()); //Seamless
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Ravager"), ModContent.ItemType<RavagerMusicbox>(), ModContent.TileType<Tiles.RavagerMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/SupremeCalamitas1"), ModContent.ItemType<SCalGMusicbox>(), ModContent.TileType<Tiles.SCalGMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/SupremeCalamitas2"), ModContent.ItemType<SCalLMusicbox>(), ModContent.TileType<Tiles.SCalLMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/SupremeCalamitas3"), ModContent.ItemType<SCalEMusicbox>(), ModContent.TileType<Tiles.SCalEMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/SupremeCalamitas4"), ModContent.ItemType<SCalAMusicbox>(), ModContent.TileType<Tiles.SCalAMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Signus"), ModContent.ItemType<SignusMusicbox>(), ModContent.TileType<Tiles.SignusMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/SlimeGod"), ModContent.ItemType<SlimeGodMusicbox>(), ModContent.TileType<Tiles.SlimeGodMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Weaver"), ModContent.ItemType<StormWeaverMusicbox>(), ModContent.TileType<Tiles.StormWeaverMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/YharonLegacy"), ModContent.ItemType<Yharon1Musicbox>(), ModContent.TileType<Tiles.Yharon1Musicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/YharonP1"), ModContent.ItemType<Yharon2Musicbox>(), ModContent.TileType<Tiles.Yharon2Musicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/YharonP2"), ModContent.ItemType<Yharon3Musicbox>(), ModContent.TileType<Tiles.Yharon3Musicbox>());

				// Biome Music.
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Abyss1"), ModContent.ItemType<HigherAbyssMusicbox>(), ModContent.TileType<Tiles.HigherAbyssMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Abyss2"), ModContent.ItemType<AbyssLowerMusicbox>(), ModContent.TileType<Tiles.AbyssLowerMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Abyss3"), ModContent.ItemType<VoidMusicbox>(), ModContent.TileType<Tiles.VoidMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Astral"), ModContent.ItemType<AstralMusicbox>(), ModContent.TileType<Tiles.AstralMusicbox>()); //Seamless
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/AstralUnderground"), ModContent.ItemType<AstralUndergroundMusicbox>(), ModContent.TileType<Tiles.AstralUndergroundMusicboxTile>()); //Seamless
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Crag"), ModContent.ItemType<CragMusicbox>(), ModContent.TileType<Tiles.CragMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/Calamity"), ModContent.ItemType<CalamityMusicbox>(), ModContent.TileType<Tiles.CalamityMusicbox>()); //Seamless
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/SulphurousSea"), ModContent.ItemType<SulphurousMusicbox>(), ModContent.TileType<Tiles.SulphurousMusicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/SunkenSea"), ModContent.ItemType<SunkenSeaMusicbox>(), ModContent.TileType<Tiles.SunkenSeaMusicbox>());

				// Event Music.
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/AcidRain1"), ModContent.ItemType<AcidRain1Musicbox>(), ModContent.TileType<AcidRain1MusicboxTile>()); //Seamless
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/AcidRain2"), ModContent.ItemType<AcidRain2Musicbox>(), ModContent.TileType<AcidRain2MusicboxTile>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/BossRushTier1"), ModContent.ItemType<BossRush1Musicbox>(), ModContent.TileType<BossRushTier1Musicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/BossRushTier2"), ModContent.ItemType<BossRush2Musicbox>(), ModContent.TileType<BossRushTier2Musicbox>());
				AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/BossRushTier3"), ModContent.ItemType<BossRush3Musicbox>(), ModContent.TileType<BossRushTier3Musicbox>());
				//AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/BossRushTier4"), ModContent.ItemType<BossRush4Musicbox>(), ModContent.TileType<BossRushTier4Musicbox>());
				//AddMusicBox(GetSoundSlot(SoundType.Music, "Sounds/Music/BossRushTier5"), ModContent.ItemType<BossRush5Musicbox>(), ModContent.TileType<BossRushTier5Musicbox>());


				stopTitleMusic = false;
				titleMusicStopped = new ManualResetEvent(false);
			}
		}

		public override void Unload()
		{
			IL.Terraria.Main.UpdateAudio -= TitleMusicIL;
			customTitleMusicSlot = MusicID.Title;
			Close();
			titleMusicStopped?.Set();
			Instance = null;
			titleMusicStopped = null;
		}

		private void SetTitleMusic()
		{
			if (Config.ReplaceTitleMusic)
			{
				customTitleMusicSlot = GetSoundSlot(SoundType.Music, "Sounds/Music/Calamity");
				IL.Terraria.Main.UpdateAudio += TitleMusicIL;
			}
		}

		public override void PostSetupContent()
		{
			Mod calamity = ModLoader.GetMod("CalamityMod");
			Mod bossChecklist = ModLoader.GetMod("BossChecklist");
			Mod overhaul = ModLoader.GetMod("TerrariaOverhaul");

			// Overhaul insists on IL editing Calamity Music Mod to disable our music regardless of player choice in the Calamity music config.
			// Since it's not worth fighting over this, just don't register the IL hook if Overhaul is loaded.
			// The config notifies players that they cannot hear Calamity title music if Overhaul is enabled.
			if(overhaul is null)
				SetTitleMusic();

			if (calamity != null && bossChecklist != null)
			{
				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Desert Scourge", 
				ModContent.ItemType<DesertScourgeMusicbox>());

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Giant Clam", 
				ModContent.ItemType<SunkenSeaMusicbox>());

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Crabulon", 
				ModContent.ItemType<CrabulonMusicbox>());

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Hive Mind", 
				ModContent.ItemType<HiveMindMusicbox>());

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"The Perforators", 
				ModContent.ItemType<PerforatorMusicbox>());

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Slime God", 
				ModContent.ItemType<SlimeGodMusicbox>());

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Cryogen", 
				ModContent.ItemType<CryogenMusicbox>());

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Brimstone Elemental", 
				ModContent.ItemType<BrimmyMusicbox>());

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Aquatic Scourge", 
				ModContent.ItemType<AquaticScourgeMusicbox>());

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Calamitas", 
				ModContent.ItemType<CalamitasMusicbox>());

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Leviathan", 
				new List<int>() {ModContent.ItemType<LeviathanMusicbox>(), ModContent.ItemType<SirenMusicbox>()});

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Astrum Aureus", 
				ModContent.ItemType<AstrageldonMusicbox>());

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Plaguebringer Goliath", 
				ModContent.ItemType<PlaguebringerMusicbox>());

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Ravager", 
				ModContent.ItemType<RavagerMusicbox>());

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Astrum Deus", 
				ModContent.ItemType<AstrumDeusMusicbox>());

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Profaned Guardians", 
				ModContent.ItemType<ProfanedGuardianMusicbox>());

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Dragonfolly", 
				ModContent.ItemType<BumblebirbMusicbox>());

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Providence", 
				ModContent.ItemType<ProvidenceMusicbox>());

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Ceaseless Void", 
				ModContent.ItemType<CeaselessVoidMusicbox>());

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Storm Weaver", 
				ModContent.ItemType<StormWeaverMusicbox>());

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Signus", 
				ModContent.ItemType<SignusMusicbox>());

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Polterghast", 
				ModContent.ItemType<PolterghastMusicbox>());

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Devourer of Gods", 
				new List<int>() {ModContent.ItemType<DoGMusicbox>(), ModContent.ItemType<DoGP2Musicbox>()});

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Yharon", 
				new List<int>() {ModContent.ItemType<Yharon2Musicbox>(), ModContent.ItemType<Yharon3Musicbox>()});

				bossChecklist.Call(
				"AddToBossCollection",
				calamity.Name,
				"Exo Mechs",
				new List<int>() { ModContent.ItemType<ExoMechsMusicbox>() });

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Supreme Calamitas", 
				new List<int>() {ModContent.ItemType<SCalGMusicbox>(), ModContent.ItemType<SCalLMusicbox>(), ModContent.ItemType<SCalEMusicbox>(), ModContent.ItemType<SCalAMusicbox>()});

				bossChecklist.Call(
				"AddToBossCollection",
				calamity.Name,
				"Adult Eidolon Wyrm",
				ModContent.ItemType<AdultEidolonWyrmMusicbox>());

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Acid Rain", 
				ModContent.ItemType<AcidRain1Musicbox>());

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Acid Rain (Post-AS)", 
				ModContent.ItemType<AcidRain1Musicbox>());

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Acid Rain (Post-Polter)", 
				ModContent.ItemType<AcidRain2Musicbox>());

				bossChecklist.Call(
				"AddToBossCollection", 
				calamity.Name, 
				"Old Duke", 
				ModContent.ItemType<BoomerDukeMusicbox>());
			}
		}

		public override void Close()
		{
			var slot = GetSoundSlot(SoundType.Music, "Sounds/Music/Calamity");

			if (Main.music.IndexInRange(slot) && Main.music[slot]?.IsPlaying == true)
			{
				Main.music[slot].Stop(AudioStopOptions.Immediate);
			}
			base.Close();
		}

		public override void UpdateMusic(ref int music, ref MusicPriority priority)
		{
			if (stopTitleMusic || (!Main.gameMenu && customTitleMusicSlot != MusicID.Title && Main.ActivePlayerFileData != null && Main.ActiveWorldFileData != null))
			{
				if (!stopTitleMusic)
				{
					music = MusicID.Title;
				}

				// prevent our IL hook trying to play the track anymore
				// we could just remove our IL hook, but then we'd have to save it in a variable. tML removes it for us anyway
				customTitleMusicSlot = MusicID.Title;

				// stop the music if it's playing (which it probably is)
				var m = GetMusic("Sounds/Music/Calamity");
				if (m.IsPlaying)
					m.Stop(AudioStopOptions.Immediate);

				titleMusicStopped.Set();
				stopTitleMusic = false;
			}
		}

		public override void PreSaveAndQuit()
		{
			Mod overhaul = ModLoader.GetMod("TerrariaOverhaul");
			if(overhaul is null)
				SetTitleMusic();
		}

		internal static void SaveConfig(CalamityMusicConfig CalamityMusicConfig)
		{
			// in-game ModConfig saving from mod code is not supported yet in tmodloader, and subject to change, so we need to be extra careful.
			// This code only supports client configs, and doesn't call onchanged. It also doesn't support ReloadRequired or anything else.
			MethodInfo saveMethodInfo = typeof(ConfigManager).GetMethod("Save", BindingFlags.Static | BindingFlags.NonPublic);
			if (saveMethodInfo != null)
				saveMethodInfo.Invoke(null, new object[] { CalamityMusicConfig });
			else
				Instance.Logger.Warn("In-game SaveConfig failed, code update required");
		}
	}
}
