using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine_Final_Project
{
    public static class Tilemap
    {
        private static int rows = 8;
        private static int cols = 8;
        private static Vector2 initialScale = new Vector2(30, 30);

        private static RectangleTile[,] recTiledMap = new RectangleTile[rows, cols];

        public static void TileInjector()
        {
            Vector2 tilePos = new Vector2(30, 0);
            for (int i = 0; i < rows; i++)
            {
                tilePos = new Vector2(tilePos.x, tilePos.y + 30);

                for (int j = 0; j < cols; j++)
                {
                    recTiledMap[i, j] = new RectangleTile(tilePos, initialScale);
                    tilePos = new Vector2(tilePos.x + 30, tilePos.y);
                }
            }
        }
    }
}
