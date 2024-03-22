using System.Collections;
using UnityEngine;

namespace Interfaces
{
    public class AiInput:MonoBehaviour, IInputSystem
    {
        private Vector2 _curentDirection;

        private readonly Vector2[] _directions =
        {
            new Vector2(0, -1),
            new Vector2(0, 1),
            new Vector2(1, 0),
            new Vector2(-1, 0)
        };

        public Vector2 GetDirection()
        {
            int randomIndex = Random.Range(0, _directions.Length);

            return _directions[randomIndex];
        }

        private IEnumerable Moved(float speed)
        {


            yield return new WaitForSeconds(speed);
        }
    }
}
