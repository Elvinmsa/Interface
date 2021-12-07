using System;
using System.Collections.Generic;
using System.Text;

namespace Interface.Models
{
    public class Person : ISleep , IRunning
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void GetTimes(params int[] arr)
        {
            throw new NotImplementedException();
        }

        public void Run()
        {
            Console.WriteLine("Running");
        }

        public void Sleeping()
        {
            Console.WriteLine("Person sleeping");
        }
    }
}
