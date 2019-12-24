﻿using UwU.Items.Place;
using UwU.Items.Weapons;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace UwU.Items.Weapons
{
	public class uwuraniumyoyo : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("uwuranium yoyo");
			Tooltip.SetDefault("leylin");
			ItemID.Sets.Yoyo[item.type] = true;
			ItemID.Sets.GamepadExtraRange[item.type] = 15;
			ItemID.Sets.GamepadSmartQuickReach[item.type] = true;
		}

		public override void SetDefaults() {
			item.useStyle = 5;
			item.width = 24;
			item.height = 24;
			item.useAnimation = 25;
			item.useTime = 25;
			item.shootSpeed = 3f;
			item.knockBack = 2f;
			item.damage = 28;
			item.rare = 2;

			item.melee = true;
			item.channel = true;
			item.noMelee = true;
			item.noUseGraphic = true;

			item.UseSound = SoundID.Item1;
			item.value = Item.sellPrice(silver: 1);
			item.shoot = ProjectileType<uwuraniumyoyo52>();
		}

		public override void AddRecipes() {
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemType<uwuraniumbar>(), 15);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
