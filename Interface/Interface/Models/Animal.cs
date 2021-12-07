using System;
using System.Collections.Generic;
using System.Text;

namespace Interface.Models
{
    public abstract class Animal : ISleep
    {
        public int Age { get; set; }

        public void GetTimes(params int[] arr)
        {
            throw new NotImplementedException();
        }

        public abstract void Eat();

        public void Sleeping()
        {
            Console.WriteLine("Sleeping");
        }

        //public void WakeUp()
        //{
        //    throw new NotImplementedException();
        //}
    }
}