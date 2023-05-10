internal class Program
{
    private static void Main(string[] args)
    {
        Fighter[] fighters =
        {
            new Fighter("Djohn", 500, 50, 0),
            new Fighter("Mark", 250, 25, 20),
            new Fighter("Alex", 150, 25, 10),
            new Fighter("Luca", 300, 75, 5),
        };

        int fighterNumber;

        for (int i = 0; i < fighters.Length; i++)
        {
            Console.Write(i + 1 + " ");
            fighters[i].ShowStats();
        }

        Console.WriteLine("\n** " + new string('-', 70) + " **");

        Console.Write("\nWybierz numer pierwszego bohatera:  ");
        fighterNumber = Convert.ToInt32(Console.ReadLine()) - 1;
        Fighter firstFighter = fighters[fighterNumber];

        Console.Write("\nWybierz numer drugiego bohatera:  ");
        fighterNumber = Convert.ToInt32(Console.ReadLine()) - 1;
        Fighter secondFighter = fighters[fighterNumber];

        Console.WriteLine("\n** " + new string('-', 70) + " **");

        while(firstFighter.Health > 0 && secondFighter.Health > 0)
        {
            firstFighter.TakeDamage(secondFighter.Damage);
            secondFighter.TakeDamage(firstFighter.Damage);
            firstFighter.ShowCurrentHealth();
            secondFighter.ShowCurrentHealth();
        }

    }

    class Fighter
    {
        private string _name;
        private int _health;
        private int _damage;
        private int _armor;

        public int Health
        {
            get
            {
                return _health;
            }
        }

        public int Damage 
        {
            get
            {
                return _damage;
            }
        }

        public Fighter(string name, int health, int damage, int armor)
        {
            _name = name;
            _health = health;
            _damage = damage;
            _armor = armor;
        }

        public void ShowStats()
        {
            Console.WriteLine($"Bohater - {_name}, HP : {_health}, Moc : {_damage}, amunicja: {_armor}");
        }

        public void ShowCurrentHealth() 
        {
            Console.WriteLine($"{_name}, HP : {_health}");
        }

        public void TakeDamage(int damage )
        {
            _health -= damage - _armor;
        }
    }
}