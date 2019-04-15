using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlarmDoor_2
{
    class AlarmDoor:Door,IAlarm
    {
        //To be complete
        protected string tar => "123456";
        public string ac { set; get; }
        public AlarmDoor()
        {
            flag = 0;
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

        public void MakeAlert()
        {

            Console.WriteLine("呜呜呜");
        }
    }
}
