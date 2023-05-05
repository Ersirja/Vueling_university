using heroes.clases;

using System;

class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero();
            Boss boss = new Boss();

            hero.Combat(boss);
            boss.Combat(hero);
            hero.Combat(boss);
            boss.Combat(hero);

            if (hero.Health <= 0) Console.WriteLine("Hero is dead!");
            else Console.WriteLine("Hero heath" + hero.Health);
            if (boss.Health <= 0) Console.WriteLine("Boss is dead!");
            else Console.WriteLine("Boss health: " + boss.Health);
        }
    }
