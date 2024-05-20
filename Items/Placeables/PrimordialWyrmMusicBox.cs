using Terraria.ModLoader;
using Terraria.ID;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("AdultEidolonWyrmMusicbox", "AdultEidolonWyrmMusicBox")]
    public class PrimordialWyrmMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.PrimordialWyrmMusicBox>();
    }
}
