using System;
using RimWorld.Planet;
namespace RimWorld
{
    // Token: 0x02002567 RID: 9575
    public class BiomeWorker_Biome_RA_Dor_ATB : BiomeWorker
    {
        public override float GetScore(BiomeDef biome, Tile tile, PlanetTile planetTile)
        {
            if (tile.WaterCovered)
            {
                return -100f;
            }
            if (!BiomeWorker_Biome_RA_Dor_ATB.Allowed(tile))
            {
                return 0f;
            }
            return BiomeWorker_Biome_RA_Dor_ATB.Score(tile);
        }
        public static bool Allowed(Tile tile)
        {
            return tile.temperature >= -10f && tile.rainfall >= 600f;
        }
        public static float Score(Tile tile)
        {
            return 15f + (tile.temperature - 7f) + (tile.rainfall - 600f) / 180f;
        }
    }
}