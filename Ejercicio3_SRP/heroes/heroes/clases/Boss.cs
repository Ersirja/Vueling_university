

namespace heroes.clases
{
    public class Boss
    {
        private int _damage = 20;
        private int _defense = 3;
        private int _health = 50;

        public Boss() { }

        public Boss(int damage, int defense, int health)
        {
            _damage = damage;
            _defense = defense;
            _health = health;
        }

        public int Health { get => _health; set { _health = value; } }

        public void Combat(Hero hero)
        {
            //Boss defense
            _defense = _health + _defense;
            //Boss damage
            hero.Health -= _damage;
        }
    }


}
