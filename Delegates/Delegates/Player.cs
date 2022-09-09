using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Player
    {
        private string PlayerName { get; set; }
        public Player(string playerName)
        {
            PlayerName = playerName;
            GameEventMenager.OnGameStart += StartGame;
            GameEventMenager.OnGameOver += GameOver;
        }

        private void StartGame()
        {
            Console.WriteLine($"Spawning Player with Id: {PlayerName}");
        }
        private void GameOver()
        {
            Console.WriteLine($"Removing Player with Id: {PlayerName}");
        }

    }
}
