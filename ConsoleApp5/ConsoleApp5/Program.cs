using System;
using People;
using Biological;
namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            people p = new people();
            Virtual_Characters vp = new Virtual_Characters();
            bird b = new bird();
            b.eat();
            b.fly();
            p.speak("我是人");
            p.eat();
            p.protect();
            vp.speak("我是变种人");
            vp.eat();
            vp.protect();
            vp.fly();
            Console.ReadKey();
        }
    }
}
