using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlarmDoor_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //To be complete
            AlarmDoor d1 = new AlarmDoor();
            d1.ac = Console.ReadLine();
            d1.text();
            Console.ReadKey();
        }
    }
}
