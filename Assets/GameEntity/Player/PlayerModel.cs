using UnityEngine;
using Interfaces;
using Map;
using ParentObjects;
using System;

namespace Player
{
    public class PlayerModel : GameObjectModel
    {
        public Pickaxe Pickaxe { get; private set; }

        public Action<int> PickaxeAmountChanged
        {
            get => Pickaxe.AmountChanged;
            set => Pickaxe.AmountChanged = value;
        }

        public PlayerModel(int health, int pickaxeAmount, Vector2 startPosition) : base(startPosition)
        {
            Health = health;
            Pickaxe = new Pickaxe(pickaxeAmount);
        }

        public override void Move(IInputSystem inputSystem, MapController symbol)
        {
            PreviousPosition = CurrentPosition;
            LookForward(inputSystem.GetDirection(), symbol);
        }

        protected override void LookForward(Vector2 direction, MapController map)
        {
            base.LookForward(direction, map);
            if (map.GetSymbolMap(Direction) == (char)Symbol.Wall && Pickaxe.HitAmount != 0)
            {
                SetNewPosition(direction);
                map.RemoveWall(Direction);
                Pickaxe.RemovePickaxe();
            }
        }
    }
}
