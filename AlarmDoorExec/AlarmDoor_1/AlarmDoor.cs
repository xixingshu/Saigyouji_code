using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AlarmDoor_1
{
    class AlarmDoor:Door
    {
        protected string tar=>"123456";
        public string ac { set; get; }
        public AlarmDoor()
        {
            flag = 0;
        }
        public void text()
        {
            if(ac==tar)
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
        //To be complete
    }
}
