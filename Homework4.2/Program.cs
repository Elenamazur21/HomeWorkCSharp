using System;

namespace Homework4
{
    class Program
    {
        static void Main()
        {
            Counter counter = new Counter();
            Handler1 handler1 = new Handler1();
            Handler2 handler2 = new Handler2();

            counter.OnCount+=handler1.Message;
            counter.OnCount+=handler2.Message;
             
            counter.Count();

        }
    }
}