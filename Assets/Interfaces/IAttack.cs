using ParentObjects;
using Player;

namespace Roguelike.Interfaces
{
    public interface IAttack
    {
        void Attack(GameObjectModel playerModel);
    }
}
