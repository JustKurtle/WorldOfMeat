using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WorldOfMeat.Items.Weapons.Melee
{
    public class HardPants : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Hard Pants");
            Tooltip.SetDefault("Starchy!");
        }

        public override void SetDefaults()
        {
            item.damage = 59;
            item.melee = true;
            item.autoReuse = false;
            item.width = 90;
            item.height = 90;
            item.useTime = 30; //Raised to 30 from 20. Aiming for 220-280 DPS
            item.useAnimation = 30; //Raised from 20 to match above.
            item.useStyle = 1;
            item.knockBack = 4;
            item.value = Item.sellPrice(0, 5, 54, 0); //Changed from like 2 gold 50 silver to 5 gold 54 silver
            item.rare = 5;
            item.UseSound = SoundID.Item1;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Silk, 20);
            recipe.AddIngredient(ItemID.Bone, 30);
            recipe.AddIngredient(ItemID.HallowedBar, 10);
            recipe.AddIngredient(ItemID.SoulofMight, 10);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
