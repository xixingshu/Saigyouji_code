using System;
using System.Collections.Generic;
using System.Text;
using Interface;
using Biological;
namespace People
{
    class people:biological//,People_Behaviror
    {
        public void speak(string r)
        {
            Console.WriteLine("人说"+r);
        }
        public void protect()
        {
            Console.WriteLine("人总有想留下的东西");
        }

    }

    class Virtual_Characters:people,Fly
    {
        public void fly()
        {
            Console.WriteLine("这种人一般都能飞");
        }
    }
}
