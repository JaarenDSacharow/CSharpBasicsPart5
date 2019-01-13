using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;  // current date time
            var today = DateTime.Today; // day without time


            Console.WriteLine("Hour:" + now.Hour);
            Console.WriteLine("Minute:" + now.Minute);

            //Datetime objects are immutable
            //to change them you need to use built in methods.

            now.AddDays(1); //returns tomorrow, current time
            now.AddDays(-1); //returns yesterday, current time


            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToShortTimeString());

            // all of it

            Console.WriteLine(now.ToString());

            //format
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:MM"));

            //============TIMESPANS: represent length of time==========================

            //creating

            var timeSpan = new TimeSpan(1, 2, 3);  //params are hours, minutes, seconds, this means a span of time of 1 hour, 2 minutes and 3 seconds

            //these two statements are equivalent, the lower more readable
            var timeSpan1 = new TimeSpan(1,0,0);
            var timeSpan2 = TimeSpan.FromHours(1);


            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);

            var duration = end - start;

            Console.WriteLine(duration);

            //properties

            Console.WriteLine("Minutes:" + timeSpan.Minutes);
            Console.WriteLine("Total Minutes:" + timeSpan.TotalMinutes);

            //add

            Console.WriteLine("Add Example:" + timeSpan.Add(TimeSpan.FromMinutes(8)));

        }
    }
}
