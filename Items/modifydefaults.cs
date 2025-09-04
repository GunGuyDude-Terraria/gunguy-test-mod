using Terraria;
using Terraria.GameContent.UI;
using Terraria.ID;
using Terraria.ModLoader;

namespace testmod.Items
{
	public class modifydefaults : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (ItemID.Grenade == item.type)
			{
				item.ammo = item.type;
				item.shoot = ProjectileID.Grenade;
			}
		}
	}
}