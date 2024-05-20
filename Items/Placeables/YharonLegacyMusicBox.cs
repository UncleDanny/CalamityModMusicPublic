using Terraria.ModLoader;
using Terraria.ID;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("Yharon1Musicbox")]
    public class YharonLegacyMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.YharonLegacyMusicBox>();

        public override void AddRecipes()
        {
			// Does not play in-game
            CreateRecipe().
				AddIngredient(ModContent.ItemType<YharonPhase1MusicBox>()).
				AddIngredient(ModContent.ItemType<YharonPhase2MusicBox>()).
				AddTile(TileID.TinkerersWorkbench).
                Register();
        }
    }
}
