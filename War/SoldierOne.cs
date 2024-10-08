﻿
namespace War
{
    internal class SoldierOne : Soldier
    {
        public override void Attack(List<Soldier> enemies)
        {
            Soldier enemy = GetRandomEnemy(enemies);

            enemy.TakeDamage(Damage);
        }

        public override SoldierOne Clone()
        {
            return new SoldierOne();
        }
    }
}
