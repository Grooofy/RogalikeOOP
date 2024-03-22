using UnityEngine;
using System;
using Map;


namespace ParentObjects
{
    public class GameObjectView : MonoBehaviour
    {
        private GameObjectModel _gameObjectModel;
        private Symbol _symbol;
        private GameObject _gameObject;
        private string _name;

        public GameObjectView(GameObjectModel gameObjectModel, Symbol symbol, string name)
        {
            _gameObjectModel = gameObjectModel;
            _symbol = symbol;
            _name = name;
            gameObjectModel.Moved += Show;
        }

        public void Show(Vector2 position, bool isMove)
        {
            if (_gameObject == null)
                CreateSprite();

            WriteSymbol(position, _symbol);

            if (isMove)
               _gameObject.transform.position = position;
        }

        protected void CleanCell(Vector2 position)
        {
            Destroy(_gameObject);
            Console.SetCursorPosition((int)position.x, (int)position.y);
        }

        private void WriteSymbol(Vector2 cursorPosition, Symbol symbol)
        {
            _gameObject.transform.position = cursorPosition;
        }

        private void CreateSprite()
        {
            _gameObject = Instantiate(Resources.Load(_name, typeof(GameObject))) as GameObject;
        }
    }
}
