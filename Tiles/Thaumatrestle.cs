using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace Thaumaturgy.Tiles
{
	public class Thaumatrestle : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolidTop[Type] = true;
			Main.tileFrameImportant[Type] = true;
			Main.tileNoAttach[Type] = true;
			Main.tileTable[Type] = true;
			Main.tileLavaDeath[Type] = true;
			TileObjectData.newTile.CopyFrom(TileObjectData.Style2x1);
			TileObjectData.newTile.CoordinateHeights = new int[]{ 18 };
			TileObjectData.addTile(Type);
			AddToArray(ref TileID.Sets.RoomNeeds.CountsAsTable);
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Thaumatrestle");
			AddMapEntry(new Color(200, 200, 200), name);
			disableSmartCursor = true;
            AddToArray(ref TileID.Sets.RoomNeeds.CountsAsTable);
            adjTiles = new int[]{ TileID.WorkBenches };
		}

		public override void KillMultiTile(int i, int j, int frameX, int frameY)
		{
			Item.NewItem(i * 16, j * 16, 32, 16, mod.ItemType("Thaumatrestle"));
		}
	}
}