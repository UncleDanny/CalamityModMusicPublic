using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityModMusic.Items.Placeables
{
    public class Interlude2MusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.Interlude2MusicBox>();

        public override void AddRecipes()
        {
            // Interludes only play once per world (when toggled, otherwise it doesn't play in-game)
            CreateRecipe().
                AddIngredient(ModContent.ItemType<AnahitaMusicBox>()).
                AddIngredient(ModContent.ItemType<LeviathanMusicBox>()).
                AddIngredient(ModContent.ItemType<AstrumAureusMusicBox>()).
                AddIngredient(ModContent.ItemType<PlaguebringerGoliathMusicBox>()).
                AddIngredient(ModContent.ItemType<RavagerMusicBox>()).
                AddIngredient(ModContent.ItemType<AstrumDeusMusicBox>()).
                AddTile(TileID.TinkerersWorkbench).
                Register();
        }
    }
}