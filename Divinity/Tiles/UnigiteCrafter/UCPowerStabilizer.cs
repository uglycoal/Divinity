using Terraria.ID;
using Terraria.ModLoader;

namespace Divinity.Tiles.UnigiteCrafter
{
	public class UCPowerStabilizer : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Power Stabilizer");
            Tooltip.SetDefault("Used to craft Unigite Crafter.");			
		}
		public override void SetDefaults()
		{
			item.maxStack = 10;
			item.rare = 5;
			item.value = 3000;
		}
	}	
}