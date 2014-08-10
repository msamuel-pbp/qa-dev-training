using System;
using NUnit.Framework;

namespace FunTimer
{
    [TestFixture]
    public class FunTimer
    {
        public class StopWatch
        {
            public DateTime EndTime { get; set; }

            public void TimeLeft()
            {
                DateTime curTime = DateTime.Now;

                Console.WriteLine("Current Time is {0}", curTime);
                Console.WriteLine("End Time is {0}", EndTime);

                int sec = (int) EndTime.Subtract(curTime).TotalSeconds;
                if (sec > 0)
                {
                    int min = sec/60;
                    int hours = min/60;
                    int days = hours/24;
                    hours %= 24;
                    min %= 60;
                    sec %= 60;

                    Console.WriteLine("You have {0} day(s), {1} hour(s), {2} minute(s), and {3} second(s) left", days,
                        hours, min, sec);
                }
                else
                {
                    Console.WriteLine("Sorry, you have missed your deadline!");
                }
            }
        }

        [Test]
        public void ReportTime()
        {
            StopWatch w = new StopWatch();
            w.EndTime = DateTime.Parse("Fri, 09 May 2014 12:00:00");

            w.TimeLeft();
        }
    }
}