using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class GameEventMenager
    {
        public delegate void GameEvent();

        public static GameEvent OnGameStart, OnGameOver;
        public static void TriggerGameStart()
        {
            if (OnGameStart == null) return;

            Console.WriteLine("The game has started...");
            OnGameStart();
        }
        public static void TriggerGameOver()
        {
            if (OnGameOver == null) return;

            Console.WriteLine("The game has ended...");
            OnGameOver();
        }
    }
}
