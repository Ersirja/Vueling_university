Hero hero = new Hero();
Boss boss = new Boss();

hero.Combat(boss);
boss.Combat(hero);
hero.Combat(boss);
boss.Combat(hero);

if (hero.Health <= 0) Console.WriteLine("Hero is dead!");
else Console.WriteLine("Hero heath" + hero.Health);
if (boss.Health <= 0) Console.WriteLine("Boss is dead!");
else Console.WriteLine("Boss health" + boss.Health);

public class Hero
{
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

    private int _damage = 10;
    private int _defense = 3;
    private int _health = 20;
    private int _healthPotion = 0;
    private int _defenseScroll = 0;
    private int _damageScroll = 0;
    private bool _buyScrolls;

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

public class Boss
{
    public int Health { get => _health; set { _health = value; } }

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

    public void Combat(Hero hero)
    {
        //Boss defense
        _defense = _health + _defense;
        //Boss damage
        hero.Health -= _damage;
    }
}