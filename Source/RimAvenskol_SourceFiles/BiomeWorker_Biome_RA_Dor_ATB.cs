using System;
using RimWorld.Planet;
namespace RimWorld
{
    // Token: 0x02002567 RID: 9575
    public class BiomeWorker_Biome_RA_Dor_ATB : BiomeWorker
    {
        // Token: 0x9991CEDE RID: 99991 RVA: 0x9991CEDE File Offset: 0x9991CEDE
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
        // Token: 0x0600D191 RID: 53649 RVA: 0x003D9D44 File Offset: 0x003D7F44
        public static bool Allowed(Tile tile)
        {
            return tile.temperature >= -10f && tile.rainfall >= 600f;
        }
        // Token: 0x0600D192 RID: 53650 RVA: 0x003D9D65 File Offset: 0x003D7F65
        public static float Score(Tile tile)
        {
            return 15f + (tile.temperature - 7f) + (tile.rainfall - 600f) / 180f;
        }
    }
}