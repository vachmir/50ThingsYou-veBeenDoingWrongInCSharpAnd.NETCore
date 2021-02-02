using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using NodaTime;    //PM> Install-Package NodaTime



namespace MisusingCSharpPrimitives.MisusingDateTime
{
    class DateTimes
    {
        public static void GeneralDateTimeUsage()
        {
            Console.WriteLine("GeneralDateTimeUsage");
            var now = DateTime.Now;
            Console.WriteLine($"Now is {now}");

            var someDate = new DateTime();
            Console.WriteLine($"Date is {someDate}");

            var nowWithOffset = DateTimeOffset.Now;
            Console.WriteLine($"Offset is {nowWithOffset}");

            var thicks = DateTime.Now.Ticks;
            Console.WriteLine($"Time thicks {thicks}");
            Console.WriteLine();
        }

        public static void TimeMeausure()
        {
            Console.WriteLine("TimeMeausure");
            //Wrong way.
            var start = DateTime.Now;
            //Do something
            for (byte b = 0; b < byte.MaxValue; b++)
            { }
            var end = DateTime.Now;
            var elapsed1 = end - start;
            Console.WriteLine($"Wrong Way {elapsed1}");

            //Correct way
            var sw = Stopwatch.StartNew();
            //Do something
            for (byte b = 0; b < byte.MaxValue; b++)
            { }
            var elapsed2 = sw.Elapsed;
            Console.WriteLine($"Correct Way {elapsed2}");
            Console.WriteLine();

        }

        public static void Scheduling()
        {
            Console.WriteLine("Scheduling");

            var trueNow = SystemClock.Instance.GetCurrentInstant();
            Console.WriteLine($"Current instant of time {trueNow}");

            ZonedDateTime nowInIsoUtc = trueNow.InUtc();
            Console.WriteLine($"Current time in ISO UTC {nowInIsoUtc}");

            var london = DateTimeZoneProviders.Tzdb["Europe/Berlin"];
            Console.WriteLine($"London Time Zone Provider {london}");

            var londonTime = trueNow.InZone(london);
            Console.WriteLine($"London Time Zone {londonTime}");

            var localDate = new LocalDateTime(2019, 3, 31, 1, 45, 00);
            Console.WriteLine($"Local Date is {localDate}");


            //  london.AtStrictly(localDate);
            Console.WriteLine("_____________________________________________________________________");
        }
    }
}
