using UnityEngine;
using Map;
using ParentObjects;
using Player;
using Roguelike.Interfaces;

namespace Enemy
{
    public class WarriorModel : GameObjectModel, IAttack
    {
        private int _damage = 1;
        private PlayerModel _playerModel;


        public WarriorModel(Vector2 startPosition, PlayerModel playerModel, int speed) : base(startPosition, speed)
        {
            _playerModel = playerModel;
        }

        public void Attack(GameObjectModel playerModel)
        {
            playerModel.TakeDamage(_damage);
        }

        protected override void LookForward(Vector2 direction, MapController map)
        {
            base.LookForward(direction, map);
            if (CurrentPosition == _playerModel.CurrentPosition)
            {
                Attack(_playerModel);
            }
        }


    }
}
