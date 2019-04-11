using System;
using System.Collections.Generic;
using System.Text;
using Interface;
namespace Biological
{
    class biological//:Biological_Behavior
    {
        public void eat()
        {
            Console.WriteLine("只要活着就会吃");
        }
    }

    class bird:biological,Fly
    {
        public void fly()
        {
            Console.WriteLine("鸟一般都能飞");
        }
    }
}
