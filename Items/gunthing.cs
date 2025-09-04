using Terraria;
using Terraria.GameContent.UI;
using Terraria.ID;
using Terraria.ModLoader;

namespace testmod.Items
{
	public class gunthing : ModItem
	{
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.testmod.hjson file.

		public override void SetDefaults()
		{
			Item.width = 40;
			Item.height = 40;
			Item.scale = 1f;
			Item.rare = ItemRarityID.Green;

			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.autoReuse = false;

            Item.UseSound = SoundID.Item11;

			Item.DamageType = DamageClass.Ranged;
			Item.damage = 30;
			Item.knockBack = 1f;
			Item.noMelee = true;

			Item.shoot = ProjectileID.PurificationPowder;
			Item.shootSpeed = 1f;
			Item.useAmmo = AmmoID.Bullet;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 10);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}