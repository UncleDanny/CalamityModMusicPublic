using Terraria.ModLoader;
using Terraria.ID;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("CalamityMusicbox")]
    public class CalamityTitleMusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.CalamityTitleMusicBox>();

        public override void AddRecipes()
        {
			// Contingent recipe in case it was discarded from the Starter Bag
			// All of Dokuro's biome tracks --  based on a 2018 concept
			CreateRecipe().
				AddIngredient(ModContent.ItemType<AbyssLayer2MusicBox>()).
				AddIngredient(ModContent.ItemType<AbyssLayer4MusicBox>()).
				AddIngredient(ModContent.ItemType<AstralInfectionMusicBox>()).
				AddIngredient(ModContent.ItemType<AstralInfectionUndergroundMusicBox>()).
				AddIngredient(ModContent.ItemType<BrimstoneCragsMusicBox>()).
				AddIngredient(ModContent.ItemType<SulphurousSeaDayMusicBox>()).
				AddIngredient(ModContent.ItemType<SunkenSeaMusicBox>()).
				AddTile(TileID.TinkerersWorkbench).
                Register();
        }
    }
}
