﻿using Terraria.ID;
using Terraria.ModLoader;

namespace WorldOfMeat.Items.Placeable.Tavernkeep
{
    public class TavernkeepBar : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("This is a normal.");
        }

        public override void SetDefaults()
        {
            item.width = 26;
            item.height = 22;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.value = 500;
            item.createTile = mod.TileType("TavernkeepBar");
        }
    }
}
