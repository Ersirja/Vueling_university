

namespace heroes.clases
{
    public class Hero
    {
        private int _damage = 10;
        private int _defense = 3;
        private int _health = 20;
        private int _healthPotion = 0;
        private int _defenseScroll = 0;
        private int _damageScroll = 0;
        private bool _buyScrolls;

        public Hero()
        {

        }

        public Hero(int damage, int defense, int health, bool buyScrolls)
        {
            _damage = damage;
            _defense = defense;
            _health = health;
            _buyScrolls = buyScrolls;
        }

        public int Health { get => _health; set { _health = value; } }

        public void Combat(Boss boss)
        {
            //buy fase
            if (_buyScrolls)
            {
                _defenseScroll++;
                _damageScroll++;
                _healthPotion++;
            }
            //hero power up
            if (boss.Health > 50 && (_defenseScroll > 0 && _damageScroll > 0))
            {
                _defense = _defense + 30;
                _damage = _damage + 50;
                _defenseScroll--;
                _damageScroll--;
            }
            //hero attack
            boss.Health = boss.Health - _damage;
            //hero defense
            if (_health < 10)
            {
                _health = _health + _defense;
            }
            //hero healing
            if (_health < 5 && _healthPotion != 0)
            {
                _health = _health + 25;
                _healthPotion--;
            }
        }
    }

}
