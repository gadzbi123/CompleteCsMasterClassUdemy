using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace AnimalInheretence
{
    class VideoPost : Post
    {
        public string VideoURL;
        public int Length;
        public int CurrTime;
        public static System.Timers.Timer t;


        public VideoPost() { }
        public VideoPost(string videoURL, int length, string title, bool isPublic, string whoSend) : base(title, isPublic, whoSend)
        {
            VideoURL = videoURL;
            Length = length;
            CurrTime = 0;
            t = new System.Timers.Timer();
            t.Interval = 1000;
            t.Elapsed += TimerCallBack;
            t.AutoReset = true;

        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - {3} - ({4}) - by {2}", ID, Title, WhoSend, VideoURL, Length);
        }

        public void Play()
        {
            t.Enabled = true;
        }

        private void TimerCallBack(Object o, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine($"Time is {CurrTime}");
            if (CurrTime < Length)
                CurrTime++;
            else
                Stop();
        }

        public void Stop()
        {
            Console.WriteLine($"Stopped at {CurrTime}");
            t.Enabled = false;

        }
    }
}
