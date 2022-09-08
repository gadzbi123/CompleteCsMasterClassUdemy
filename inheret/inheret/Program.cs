using System;

namespace inheret
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Radio myRadio = new Radio(false, "Sony");
            TV myTV = new TV(true, "Sharp");
            myRadio.ListenRadio();
            myRadio.SwitchOn();
            myRadio.ListenRadio();

            myTV.WatchTV();
            myTV.SwitchOff();
            myTV.WatchTV();

        }
    }
}
