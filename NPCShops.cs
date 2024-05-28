using CalamityModMusic.Items.Placeables;
using Terraria;
using Terraria.ModLoader;

namespace CalamityModMusic
{
    public class NPCShops : GlobalNPC
    {
        public override void ModifyShop(NPCShop shop)
        {
            var calamityMod = ModLoader.TryGetMod("CalamityMod", out Mod calamity);

            Condition DownedCalamitasClone = new("", () => (bool)calamity.Call("GetBossDowned", "calamitasclone"));
            Condition DownedYharon = new("", () => (bool)calamity.Call("GetBossDowned", "yharon"));
            Condition DownedDevourerofGods = new("", () => (bool)calamity.Call("GetBossDowned", "devourerofgods"));

            if (calamityMod && shop.NpcType == calamity.Find<ModNPC>("FAP").Type)
            {
                shop.Add(ModContent.ItemType<Interlude1MusicBox>(), DownedCalamitasClone);
                shop.Add(ModContent.ItemType<Interlude2MusicBox>(), Condition.DownedMoonLord);
                shop.Add(ModContent.ItemType<Interlude3MusicBox>(), DownedYharon);
                shop.Add(ModContent.ItemType<EulogyMusicBox>(), DownedDevourerofGods);
            }
        }
    }
}
