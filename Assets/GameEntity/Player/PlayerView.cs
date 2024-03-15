using Map;
using ParentObjects;
using Status;

namespace Player
{
    public class PlayerView : GameObjectView
    {
        public PlayerView(GameObjectModel playerModel) : base(playerModel, Symbol.Player)
        {
        }
    }
}
