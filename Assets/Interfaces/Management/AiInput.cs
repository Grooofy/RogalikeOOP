using System.Collections;
using UnityEngine;

namespace Interfaces
{
    public class AiInput:MonoBehaviour, IInputSystem
    {
        private Vector2 _curentDirection;

        private Vector2 _stop = Vector2.zero;

        private readonly Vector2[] _directions =
        {
            new Vector2(0, -1),
            new Vector2(0, 1),
            new Vector2(1, 0),
            new Vector2(-1, 0)
        };

        public Vector2 GetDirection()
        {
            return _curentDirection = _directions[Random.Range(0, _directions.Length)];
        }

        public IEnumerable Moved(float speed)
        {

            yield return new WaitForSeconds(speed);

            int randomIndex = Random.Range(0, _directions.Length);

            _curentDirection = _directions[randomIndex];

            _curentDirection = _stop;
        }
    }
}
