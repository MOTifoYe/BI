using System;

namespace HitMe
{
    class Player
    {
        private int health = 100;
        private const int MAXHEALTH = 1000;
        private int damage;
        private string _name;

        private readonly Random random = new Random();

        public Player()
        {
            _name = string.Empty;
        }
        public Player(string name)
        {
            _name = name;
        }

        public int GetHealth() => health;
        public int GetDamage() => damage;
        public void Hit()
        {
            damage = random.Next(20);
            var t = health - damage;
            if (t > 0)
            {
                health = t;
            }
            else
            {
                ResetByZero();
            }
        }
        private void ResetByZero()
        {
            damage = 0;
            health = MAXHEALTH;
        }



    }
}
