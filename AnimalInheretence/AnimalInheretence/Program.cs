using System;
using System.Timers;

namespace AnimalInheretence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Post post = new Post("Thanks for birthday wishes", true, "Kacperito");
            Console.WriteLine(post.ToString());
            ImagePost imagePost1 = new ImagePost("Check out my shoes", "Kacperito", "https://image.com/shoes", true);
            Console.WriteLine(imagePost1.ToString());
            VideoPost videoPost = new VideoPost("abc.pl", 5, "abc video", true, "Kacpi");
            Console.WriteLine(videoPost.ToString());
            videoPost.Play();
            Console.ReadLine();
            videoPost.Stop();
            */
            Chair officeChair = new Chair("Brown", "Plastic");
            Chair gamingChair = new Chair("Red", "Metal");
            Car dmgCar = new Car(33.5f, "Green");

            dmgCar.DestroyablesNearby.Add(officeChair);
            dmgCar.DestroyablesNearby.Add(gamingChair);
            dmgCar.Destroy();
        }
    }
}
