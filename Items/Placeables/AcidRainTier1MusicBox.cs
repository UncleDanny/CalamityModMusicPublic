using Terraria.ModLoader;
using Terraria.ID;

namespace CalamityModMusic.Items.Placeables
{
    [LegacyName("AcidRain1Musicbox")]
    public class AcidRainTier1MusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.AcidRainTier1MusicBox>();
    
        public override void AddRecipes()
        {
			// Contingent recipes in case players skipped to Tier 3 Acid Rain
            // When T2 exists, the recipe would be split into [T3 + AS = T2] and [T2 + SulphSea = T1]
            CreateRecipe().
				AddIngredient(ModContent.ItemType<AcidRainTier3MusicBox>()).
				AddIngredient(ModContent.ItemType<SulphurousSeaDayMusicBox>()).
				AddTile(TileID.TinkerersWorkbench).
                Register();
            CreateRecipe().
				AddIngredient(ModContent.ItemType<AcidRainTier3MusicBox>()).
				AddIngredient(ModContent.ItemType<SulphurousSeaNightMusicBox>()).
				AddTile(TileID.TinkerersWorkbench).
                Register();
        }
    }
}
