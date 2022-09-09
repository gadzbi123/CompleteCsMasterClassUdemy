using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyphorm
{
    internal class Car
    {
        protected CarIDInfo carIDInfo = new CarIDInfo();
        public void setCarIDInfo(int idNum, string Owner)
        {
            carIDInfo.IDNum = idNum;
            carIDInfo.Owner = Owner;
        }
        public void getCarIdInfo()
        {
            Console.WriteLine("Car has the ID of {0} and is owner by {1}", carIDInfo.IDNum, carIDInfo.Owner);
        }
        public int HP { get; set; }
        public string color { set; get; }
        public Car(int hp, string color)
        {
            HP = hp;
            this.color = color;
        }
        virtual public void ShowDetails()
        {
            Console.WriteLine($"The {color} car has {HP} hp!");
        }
        virtual public void Repair()
        {
            HP = 100;
            Console.WriteLine($"Car was repaired!");
        }
    }
}
