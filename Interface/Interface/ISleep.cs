using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    public interface ISleep
    {
        int Age { get; set; }
        void Sleeping();
        void GetTimes(params int[] arr);
        void WakeUp()
        {
            Console.WriteLine("test");
        }
    }
}
