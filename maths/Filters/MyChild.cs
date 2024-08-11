using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace maths.Filters
{
    public class MyChild:MyBase
    {
        private int j;
        public MyChild():base() {
            
            j = 20; 
        }
        public MyChild(int j) { this.j = j; }
        public void Display()
        {
            base.Display();
            Console.WriteLine(j);
        }

    }
}