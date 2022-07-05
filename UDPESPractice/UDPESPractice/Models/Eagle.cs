using System;


namespace UDPESPractice.Models
{
    public class Eagle : Bird
    {
        public int Age { get; set; }
        public override void Eat()
        {
            Console.WriteLine("Eagle eating");
        }

        //public override void Test()
        //{
        //    Console.WriteLine("Eagle test");
        //}
    }
}
