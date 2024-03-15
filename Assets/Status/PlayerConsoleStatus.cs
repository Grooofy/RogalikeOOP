using System;
using Map;
using Player;

namespace Status
{
    public class PlayerConsoleStatus
    {
        private int _positionX = 10;
        private int _positionHeathInfo = 5;
        private int _positionPickaxeInfo = 6;
        private PlayerModel _player;


        public PlayerConsoleStatus(int lastMapSymbol, PlayerModel player)
        {
            _player = player;
            _player.TakingDamage += ShowInfoHealth;
            _player.PickaxeAmountChanged += ShowInfoPickaxe;
            _positionX += lastMapSymbol;
        }

        public void ShowInfoHealth(int heath)
        {
            Console.SetCursorPosition(_positionX, _positionHeathInfo);
            Console.WriteLine($"Жизни: {heath}");
        }

        public void ShowInfoPickaxe(int amount)
        {
            Console.SetCursorPosition(_positionX, _positionPickaxeInfo);
            Console.WriteLine($"Кирки: {amount}");
        }
    }
}
