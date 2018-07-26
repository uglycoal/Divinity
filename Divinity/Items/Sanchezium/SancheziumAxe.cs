using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Divinity.Items.Sanchezium
{
	public class SancheziumAxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("");
		}

		public override void SetDefaults()
		{
			item.damage = 40;
			item.melee = true;
			item.width = 34;
			item.height = 34;
			item.useTime = 15;
			item.useAnimation = 10;
			item.axe = 105;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 9;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
		public override void MeleeEffects(Player player, Rectangle hitbox)
		{
			if (Main.rand.Next(10) == 0)
			{
				int dust = Dust.NewDust(new Vector2(hitbox.X, hitbox.Y), hitbox.Width, hitbox.Height, mod.DustType("Sparkle"));
			}
		}
	}
}