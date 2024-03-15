using System;

namespace Generator
{
    public class GeneratorMapPath
    {
        private Random _random = new Random();

        public char[,] Create(char[,] newMap, int width, int height, char wallSymbol, char cleanCell)
        {
            for (int i = 1; i < height - 1; i++)
                newMap[1, i] = GetRandomChar(wallSymbol, cleanCell);

            for (int i = 2; i < width - 1; i++)
            {
                for (int j = 1; j < height - 1; j++)
                {
                    if (newMap[i - 1, j + 1] == wallSymbol && newMap[i - 1, j] == cleanCell)
                        newMap[i, j] = cleanCell;
                    else
                        newMap[i, j] = GetRandomChar(wallSymbol, cleanCell);
                }
            }
            return newMap;
        }

        private char GetRandomChar(char wallSymbol, char cleanCell)
        {
            int randomValue = _random.Next(2);

            if (randomValue == 0)
                return cleanCell;

            return wallSymbol;
        }
    }
}
