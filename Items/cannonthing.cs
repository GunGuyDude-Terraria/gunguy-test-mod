using Terraria;
using Terraria.GameContent.ObjectInteractions;
using Terraria.GameContent.UI;
using Terraria.ID;
using Terraria.ModLoader;

namespace testmod.Items
{
	public class cannonthing : ModItem
	{
        // The Display Name and Tooltip of this item can be edited in the Localization/en-US_Mods.testmod.hjson file.

		public override void SetDefaults()
		{
			Item.width = 34;
			Item.height = 24;
			Item.scale = 1f;
			Item.rare = ItemRarityID.Green;

			Item.useTime = 50;
			Item.useAnimation = 50;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.autoReuse = true;

            Item.UseSound = SoundID.Item11;

			Item.DamageType = DamageClass.Ranged;
			Item.damage = 30;
			Item.knockBack = 1f;
			Item.noMelee = true;

			Item.shoot = ProjectileID.Grenade;
			Item.shootSpeed = 6f;
			Item.useAmmo = ItemID.Grenade;
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