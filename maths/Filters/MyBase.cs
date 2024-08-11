using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace maths.Filters
{
    public class MyBase
    {
        private int i;
        public MyBase() { i = 0; }
        public MyBase(int i)
        {
            this.i = i;
        }

        public void Display()
        {
            Console.WriteLine(i);
        }
    }
}