using System;
using System.Collections.Generic;
using System.Text;

namespace Interface.Models
{
    public class Sparrow : Bird, ISleep
    {
        public int Age { get; set; }

        public override void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetTimes(params int[] arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        public void Sleeping()
        {
            Console.WriteLine("Sparrow sleeping");
        }

        //Overloading

        public void Sound()
        {

        }
        public void Sound(int a)
        {

        }
        public void Sound(int a, string b)
        {

        }

    }

    public sealed class Human
    {

    }
}
