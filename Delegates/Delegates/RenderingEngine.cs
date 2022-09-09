using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class RenderingEngine
    {
        public RenderingEngine()
        {
            GameEventMenager.OnGameStart += StartGame;
            GameEventMenager.OnGameOver += GameOver;
        }
        private void StartGame()
        {
            Console.WriteLine("Rendering Engine Started");
            Console.WriteLine("Showing Visuals...");
        }
        private void GameOver()
        {
            Console.WriteLine("Rendering Engine Stopped");
        }
    }
}
