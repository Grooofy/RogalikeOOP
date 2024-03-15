using UnityEngine;

namespace Generator
{
    public class GeneratorMapPerimeter
    {
        private Vector2 _enterPosition = new Vector2(0, 1);
        private Vector2 _exitPosition = new Vector2(-1, -2);

        public Vector2 ExitPosition { get; private set; }

        public char[,] Create(char wallSymbol, char cleanSymbol, int width, int height)
        {
            char[,] newMap = new char[width, height];

            for (int i = 0; i < width; i++)
            {
                newMap[i, 0] = wallSymbol;
                newMap[i, height - 1] = wallSymbol;
            }

            for (int j = 1; j < height - 1; j++)
            {
                newMap[0, j] = wallSymbol;
                newMap[width - 1, j] = wallSymbol;
            }

            newMap[(int)_enterPosition.x, (int)_enterPosition.y] = cleanSymbol;
            newMap[(int)(width + _exitPosition.x), (int)(height + _exitPosition.y)] = cleanSymbol;
            ExitPosition = new Vector2((height + _exitPosition.y), (width + _exitPosition.x));
            return newMap;
        }
    }
}
