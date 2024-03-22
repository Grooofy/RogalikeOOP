using Map;
using ParentObjects;

namespace Enemy
{
    public class WarriorView : GameObjectView
    {
        private static Symbol SYMBOL = Symbol.WarriorEnemy;
        private static string NAME = "Warrior";

        public WarriorView(GameObjectModel enemyModel) : base(enemyModel, SYMBOL, NAME)
        {
        }
    }
}
