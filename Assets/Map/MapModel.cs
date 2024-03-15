using UnityEngine;
using Generator;

namespace Map
{
    public class MapModel
    {
        private readonly GeneratorMapPerimeter _generatorMapPerimeter = new GeneratorMapPerimeter();
        private readonly GeneratorMapPath _generatorMapPath = new GeneratorMapPath();
        private readonly char _wallSymbol = (char)Symbol.Wall;
        private readonly char _perimeterWallSymbol = (char)Symbol.PerimeterWall;
        private readonly char _cleanCell = (char)Symbol.CleanCell;

        public char[,] Generate(int width, int height)
        {
            char[,] newMap = _generatorMapPerimeter.Create(_perimeterWallSymbol, _cleanCell, width, height);
            newMap = _generatorMapPath.Create(newMap, width, height, _wallSymbol, _cleanCell);

            newMap[1, 1] = _cleanCell;
            newMap[width - 2, height - 3] = _cleanCell;
            return newMap;
        }

        public Vector2 GetExitPosition()
        {
            return _generatorMapPerimeter.ExitPosition;
        }
    }
}
