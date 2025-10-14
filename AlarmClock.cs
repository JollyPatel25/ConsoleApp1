using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class AlarmClock
    {
        public delegate void AlarmRing(String msg);
        public event AlarmRing OnAlarmRing; 
        
        public void SetAlarm(int seconds)
        {
            System.Threading.Thread.Sleep(seconds * 1000);
            Console.WriteLine(seconds + " Seconds Completed");
            OnAlarmRing?.Invoke("Alarm Rang! Wake Up!!!");
        }
    }
}
