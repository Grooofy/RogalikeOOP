using System;
using UnityEngine;
using UnityEngine.UIElements;


namespace Map
{
    public class MapView : MonoBehaviour
    {
        private Wall[,] _walls;

        public void Show(char[,] _map, Transform transform)
        {
            _walls = new Wall[_map.GetLength(0), _map.GetLength(1)];

            for (int i = 0; i < _map.GetLength(0); i++)
            {
                for (int j = 0; j < _map.GetLength(1); j++)
                {
                    if (_map[j,i] != (char)Symbol.CleanCell)
                    {
                        Wall wall = Instantiate(Resources.Load("Wall", typeof(Wall))) as Wall;
                        _walls[i,j] = wall;
                        wall.gameObject.transform.SetParent(transform, false);
                        wall.transform.position = new Vector2(i, j);
                    }
                }
            }
        }

        public void RemoveWall(Vector2 position)
        {
            Destroy(_walls[(int)position.x, (int)position.y].gameObject);

        }
    }
}
