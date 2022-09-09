using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class AudioSystem
    {
        public AudioSystem()
        {
            GameEventMenager.OnGameStart += StartGame;
            GameEventMenager.OnGameOver += GameOver;
        }
        private void StartGame()
        {
            Console.WriteLine("Audio Engine Started");
            Console.WriteLine("Playing audio...");
        }
        private void GameOver()
        {
            Console.WriteLine("Audio Engine Stopped");
        }
    }
}
