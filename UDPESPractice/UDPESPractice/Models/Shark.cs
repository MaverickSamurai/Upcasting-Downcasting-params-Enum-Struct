using System;

namespace UDPESPractice.Models
{
    public class Shark : Fish
    {

        public int Weight { get; set; } = 50;
        public override void Eat()
        {
            Console.WriteLine("Shark eating");
        }

        //public override void Test()
        //{
        //    Console.WriteLine("Shark test");
        //}
    }
}
