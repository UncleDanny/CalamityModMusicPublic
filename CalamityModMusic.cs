using Terraria;
using Terraria.ModLoader;

namespace CalamityModMusic
{
    public class CalamityModMusic : Mod
    {
        public static CalamityModMusic Instance;

        public const string CalamityWikiURL = "https://calamitymod.wiki.gg/wiki/{}";

        internal Mod wikithis = null;
        internal Mod calamity = null;
        internal Mod bossChecklist = null;
        internal Mod musicDisplay = null;

        public CalamityModMusic() => Instance = this;

        public override void Load()
        {
            wikithis = null;
            calamity = null;
            bossChecklist = null;
            musicDisplay = null;
            ModLoader.TryGetMod("Wikithis", out wikithis);
            ModLoader.TryGetMod("CalamityMod", out calamity);
            ModLoader.TryGetMod("BossChecklist", out bossChecklist);
            ModLoader.TryGetMod("MusicDisplay", out musicDisplay);

            if (!Main.dedServ)
                wikithis?.Call("AddModURL", this, CalamityWikiURL);
        }

        public override void Unload()
        {
            wikithis = null;
            calamity = null;
            bossChecklist = null;
            Instance = null;
        }
    }
}
