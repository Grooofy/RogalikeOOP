using System;

namespace Player
{
    public class Pickaxe
    {
        public int HitAmount { get; private set; }
        public Action<int> AmountChanged;

        public Pickaxe(int hitAmount)
        {
            HitAmount = hitAmount;
        }

        public void AddPickaxe()
        {
            HitAmount++;
            AmountChanged?.Invoke(HitAmount);
        }

        public void RemovePickaxe()
        {
            if (HitAmount <= 0) return;

            HitAmount--;
            AmountChanged?.Invoke(HitAmount);

        }
    }
}
