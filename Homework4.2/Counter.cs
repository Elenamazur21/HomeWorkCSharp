using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Homework4
{
    public class Counter
    {
        public delegate  void GetNumbers ();
        public event GetNumbers? OnCount;

        public void Count ()
        {
            for ( int i=0;i<=100;i++)
            {
                if (i==77)
                {
                    if (OnCount != null)
                    {
                        OnCount();
                    }
                }
            }
        }
    }
}