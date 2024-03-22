using Interfaces;
using Map;
using ParentObjects;


namespace Enemy
{
    public class WarriorController : GameObjectController
    {
        public WarriorController(IInputSystem inputSystem, MapController mapController, GameObjectModel gameObjectModel, GameObjectView gameObjectView) : base(inputSystem, mapController, gameObjectModel, gameObjectView)
        {
        }
    }
}
