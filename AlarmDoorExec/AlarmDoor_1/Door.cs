using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlarmDoor_1
{
    class Door:Alarm
    {
        public int flag { get; set; }
        
        public void Open()
        {
            if(flag==1)
            {
                Console.WriteLine("门开着");
                return;
            }
            flag = 1;
            Console.WriteLine("门开了");
            //To be complete
        }
        public void Close()
        {
            if (flag == 0)
            {
                Console.WriteLine("门关着");
                return;
            }
            flag = 0;
            Console.WriteLine("门关了");
            //To be complete
        }
    }
}
