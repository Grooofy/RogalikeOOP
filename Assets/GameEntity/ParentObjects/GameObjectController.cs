using UnityEngine;
using Interfaces;
using Map;
using System.Threading.Tasks;

namespace ParentObjects
{
    public class GameObjectController
    {
        private GameObjectView _gameObjectView;
        private Vector2 _startPosition;

        protected IInputSystem _inputSystem;
        protected MapController _mapController;
        protected GameObjectModel _gameObjectModel;

        public GameObjectController(IInputSystem inputSystem, MapController mapController, GameObjectModel gameObjectModel, GameObjectView gameObjectView)
        {
            _inputSystem = inputSystem;
            _mapController = mapController;
            _gameObjectModel = gameObjectModel;
            _gameObjectView = gameObjectView;
        }

        public void Create()
        {
            _gameObjectView.Show(_gameObjectModel.CurrentPosition, false);
        }

        public void Destroy() { }


        public void Manage()
        {
            _gameObjectModel.Move(_inputSystem, _mapController);
        }

        public Vector2 GetPosition()
        {
            return _gameObjectModel.CurrentPosition;
        }
    }
}
