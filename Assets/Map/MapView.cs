using System;
using UnityEngine;


namespace Map
{
    public class MapView : MonoBehaviour
    {
        public void Show(char[,] _map, Transform transform)
        {
            for (int i = 0; i < _map.GetLength(0); i++)
            {
                for (int j = 0; j < _map.GetLength(1); j++)
                {
                    if (_map[j,i] != (char)Symbol.CleanCell)
                    {
                        Wall wall = Instantiate(Resources.Load("Wall", typeof(Wall))) as Wall;
                        wall.gameObject.transform.SetParent(transform, false);
                        wall.transform.position = new Vector2(i, j);
                    }
                }
            }
        }
    }
}
