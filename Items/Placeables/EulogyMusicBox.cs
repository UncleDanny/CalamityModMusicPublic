using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityModMusic.Items.Placeables
{
    public class EulogyMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.EulogyMusicBox>();

        public override void AddRecipes()
        {
            // Interludes only play once per world (when toggled, otherwise it doesn't play in-game)
            // Despite the name, 'Eulogy of the Ego' can play after DoG is first defeated
            CreateRecipe().
                AddIngredient(ModContent.ItemType<DevourerofGodsPhase1MusicBox>()).
                AddIngredient(ModContent.ItemType<DevourerofGodsPhase2MusicBox>()).
                AddTile(TileID.TinkerersWorkbench).
                Register();
        }
    }
}
