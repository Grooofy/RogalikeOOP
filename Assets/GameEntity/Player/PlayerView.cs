using Map;
using ParentObjects;
using Status;

namespace Player
{
    public class PlayerView : GameObjectView
    {
        private static string NAME = "Player";

        public PlayerView(GameObjectModel playerModel) : base(playerModel, Symbol.Player, NAME)
        {
        }
    }
}
