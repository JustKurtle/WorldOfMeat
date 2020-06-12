using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace WOM.Items.Weapons.Ranged
{
    public class BulletGun : ModItem
    {
        //post mech bosses
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bullet Gun");
        }
        public override void SetDefaults()
        {
            item.useStyle = 5;
            item.crit = item.crit + 0;
            item.autoReuse = true;
            item.useAnimation = 36;
            item.useTime = 36;
            item.width = 68;
            item.height = 36;
            item.shoot = 1;
            item.useAmmo = AmmoID.Arrow;
            item.UseSound = SoundID.Item11;
            item.damage = 45;
            item.shootSpeed = 15f;
            item.noMelee = true;
            item.value = Item.sellPrice(0, 2, 50, 0);
            item.rare = 5;
            item.knockBack = 4f;
            item.ranged = true;
        }
        public override Vector2? HoldoutOffset()
        {
            return new Vector2(1, 0);
        }
        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IllegalGunParts, 1);
            recipe.AddIngredient(ItemID.HallowedBar, 10);
            recipe.AddIngredient(ItemID.SoulofMight, 10);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
    }
}