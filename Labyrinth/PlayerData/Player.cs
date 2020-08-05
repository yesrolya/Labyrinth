using System;

namespace Labyrinth.PlayerData
{
    public class Player
    {
        private int XP { get; set; }

        private bool GameOver { get; set; }

        public void Hit(int damage)
        {
            Console.WriteLine($"-{damage}XP");
            XP -= Math.Min(XP, damage);

            if (XP == 0)
            {
                Console.WriteLine("FATALITY");
                GameOver = true;
            }
        }

        public bool IsOver => GameOver;

        public Player()
        {
            XP = 1000;
            GameOver = false;
        }
    }
}
