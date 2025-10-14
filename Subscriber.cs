using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Subscriber
    {
        public void Start()
        {
            Button button = new Button();
            button.OnClick += buttonClicked;
            Console.WriteLine("\nPress Any Key To See Clicked Event: ");
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine("");
            button.buttonClicked(key);


            AlarmClock alarmClock = new AlarmClock();
            alarmClock.OnAlarmRing += AlarmRang;
            Console.WriteLine("\nEnter The Seconds To Set Alarm: ");
            int seconds = Convert.ToInt32(Console.ReadLine());
            alarmClock.SetAlarm(seconds);
        }
        public void AlarmRang(string msg)
        {
            Console.WriteLine(msg);
        }

        public void buttonClicked(String msg)
        {
            Console.WriteLine(msg);
        }
    }
}
