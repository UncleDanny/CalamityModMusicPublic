using Terraria.ID;
using Terraria.ModLoader;

namespace CalamityModMusic.Items.Placeables
{
    public class Interlude3MusicBox : MusicBox
    {
        public override int MusicBoxTile => ModContent.TileType<Tiles.Interlude3MusicBox>();

        public override void AddRecipes()
        {
            // Interludes only play once per world (when toggled, otherwise it doesn't play in-game)
            CreateRecipe().
                AddIngredient(ModContent.ItemType<ProfanedGuardiansMusicBox>()).
                AddIngredient(ModContent.ItemType<DragonfollyMusicBox>()).
                AddIngredient(ModContent.ItemType<ProvidenceMusicBox>()).
                AddIngredient(ModContent.ItemType<StormWeaverMusicBox>()).
                AddIngredient(ModContent.ItemType<CeaselessVoidMusicBox>()).
                AddIngredient(ModContent.ItemType<SignusMusicBox>()).
                AddIngredient(ModContent.ItemType<PolterghastMusicBox>()).
                AddIngredient(ModContent.ItemType<OldDukeMusicBox>()).
                AddIngredient(ModContent.ItemType<DevourerofGodsPhase1MusicBox>()).
                AddIngredient(ModContent.ItemType<DevourerofGodsPhase2MusicBox>()).
                AddIngredient(ModContent.ItemType<YharonPhase1MusicBox>()).
                AddIngredient(ModContent.ItemType<YharonPhase2MusicBox>()).
                AddTile(TileID.TinkerersWorkbench).
                Register();
        }
    }
}