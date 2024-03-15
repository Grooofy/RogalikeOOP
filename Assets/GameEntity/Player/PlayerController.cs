using Map;
using Interfaces;
using ParentObjects;

namespace Player
{
    public class PlayerController : GameObjectController
    {
        public PlayerController
        (
            IInputSystem inputSystem, MapController mapController,
            GameObjectModel gameObjectModel, GameObjectView gameObjectView) :
            base(inputSystem, mapController, gameObjectModel, gameObjectView)
        {
        }

        public override void Manage()
        {
            _gameObjectModel.Move(_inputSystem, _mapController);
        }
    }
}
