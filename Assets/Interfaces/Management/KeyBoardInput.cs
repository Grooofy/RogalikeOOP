using System;
using UnityEngine;


namespace Interfaces
{
    public class KeyBoardInput : IInputSystem
    {
        private ConsoleKey _key;
        private readonly Vector2 _directionUp = new Vector2(0, -1);
        private readonly Vector2 _directionDown = new Vector2(0, 1);
        private readonly Vector2 _directionRight = new Vector2(1, 0);
        private readonly Vector2 _directionLeft = new Vector2(-1, 0);

        public Vector2 GetDirection()
        {
            SetKeyButton();

            switch (_key)
            {
                case ConsoleKey.UpArrow:
                    return _directionUp;
                case ConsoleKey.RightArrow:
                    return _directionRight;
                case ConsoleKey.DownArrow:
                    return _directionDown;
                case ConsoleKey.LeftArrow:
                    return _directionLeft;
                default: return Vector2.zero;
            }
        }

        private void SetKeyButton()
        {
            _key = Console.ReadKey().Key;
        }
    }
}