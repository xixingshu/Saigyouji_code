using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlarmDoor_4
{
    class AlarmDoor:IAlarm,IDoor
    {
        //To be complete
        protected string tar => "123456";
        public string ac { set; get; }
        public int flag { get; set; }

        public AlarmDoor()
        {
            flag = 0;
        }

        public void MakeAlert()
        {
            Console.WriteLine("呜呜呜");
        }

        public void text()
        {
            if (ac == tar)
            {
                Open();
            }
            else
            {
                if (flag == 0)
                    MakeAlert();
                else
                    Close();
            }
        }
        public void Open()
        {
            if (flag == 1)
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
