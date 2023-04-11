using System;
using System.Threading.Tasks;

namespace Asynchronous_Programming
{
    class Enemy
    {
        private string _name;
        private int _hp;
        private bool _isDefeated;

        public string Name => _name;
        public int HP { get => _hp; set => _hp = (value < 0) ? 0 : value; }
        public bool IsDefeated => _isDefeated;

        public Enemy(string name, int hp)
        {
            this._name = name;
            this.HP = hp;
            this._isDefeated = (this.HP == 0) ? true : false;
        }

        public Enemy Defeat()
        {
            Random random = new Random();

            while (this.HP > 0)
            {
                this.HP -= random.Next(10);
            }

            return new Enemy(this._name, 0);
        }
    }
}