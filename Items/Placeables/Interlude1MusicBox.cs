using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityModMusic.Items.Placeables
{
    public class Interlude1MusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.Interlude1MusicBox>();

        public override void AddRecipes()
        {
            // Interludes only play once per world (when toggled, otherwise it doesn't play in-game)
            CreateRecipe().
                AddIngredient(ModContent.ItemType<DesertScourgeMusicBox>()).
                AddIngredient(ModContent.ItemType<CrabulonMusicBox>()).
                AddIngredient(ModContent.ItemType<HiveMindMusicBox>()).
                AddIngredient(ModContent.ItemType<PerforatorsMusicBox>()).
                AddIngredient(ModContent.ItemType<SlimeGodMusicBox>()).
                AddIngredient(ModContent.ItemType<CryogenMusicBox>()).
                AddIngredient(ModContent.ItemType<AquaticScourgeMusicBox>()).
                AddIngredient(ModContent.ItemType<BrimstoneElementalMusicBox>()).
                AddIngredient(ModContent.ItemType<CalamitasCloneMusicBox>()).
                AddTile(TileID.TinkerersWorkbench).
                Register();
        }
    }
}