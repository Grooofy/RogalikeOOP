using UnityEngine;
using System;
using Map;


namespace ParentObjects
{
    public class GameObjectView : MonoBehaviour
    {
        private GameObjectModel _gameObjectModel;
        private Symbol _symbol;

        public GameObjectView(GameObjectModel gameObjectModel, Symbol symbol)
        {
            _gameObjectModel = gameObjectModel;
            _symbol = symbol;
            gameObjectModel.Moved += Show;
        }

        public void Show(Vector2 position, bool isMove)
        {
            WriteSymbol(position, _symbol);

            if (isMove)
                CleanCell(position);
        }

        protected void CleanCell(Vector2 position)
        {
            WriteSymbol(_gameObjectModel.PreviousPosition, Symbol.CleanCell);
            Console.SetCursorPosition((int)position.x, (int)position.y);
        }

        private void WriteSymbol(Vector2 cursorPosition, Symbol symbol)
        {
            GameObject gameObject = Instantiate(Resources.Load("Player", typeof(GameObject))) as GameObject;
            gameObject.transform.position = cursorPosition;
        }
    }
}
