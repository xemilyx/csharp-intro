using System;

namespace StopwatchExercise
{
    internal partial class Program
    {
        public class Stopwatch
        {
            //Design a class called Stopwatch. The job of this class is to simulate a stopwatch. It should provide two methods: Start and Stop. 
            public DateTime startTime;
            public DateTime stopTime;

            public void Start()
            {
                if (startTime != stopTime)
                {
                    //Console.WriteLine("Invalid Operation Exception.");
                    throw new InvalidOperationException("You must stop the watch before you start it again.");
                }
                else
                {
                    startTime = DateTime.Now;
                }
                    
            }

            public void Stop()
            {
                stopTime = DateTime.Now;
                Console.WriteLine(stopTime - startTime);
                startTime = stopTime;
            }

        }
    }
}