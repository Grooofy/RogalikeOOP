using Map;
using Interfaces;
using ParentObjects;
using UnityEngine;

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

    }
}
