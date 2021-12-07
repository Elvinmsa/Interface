using System;
using System.Collections.Generic;
using System.Text;

namespace Interface.Models
{
    public class Eagle : Bird , ISleep
    {
        //public override void Eat()
        //{
        //    Console.WriteLine("Meat eat");
        //}
        public int Age { get; set; }

        public override void Eat()
        {
            throw new NotImplementedException();
        }

        public void Sleeping()
        {
            Console.WriteLine("Eagle sleeping");
        }
    }
}
