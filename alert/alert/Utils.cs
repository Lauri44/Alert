using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace utils
{
    /// <summary>
    /// Timer
    /// </summary>
    static class Timer
    {
        // Since WPF has no Timer itself i created my own

        static private int interval;
        static public bool run { get; } = false;

        /// <summary>
        /// Starts the timer. <br/>
        /// Takes a function as a argument and runs it in certain intervals. <br/>
        /// Takes int as argument vor the interval (1000 = 1000ms = 1s). Default time is 1000
        /// </summary>
        /// <param name="func"></param>
        static public void start(Action func, int interval = 1000)
        {
            this.interval = interval;
            //Task timer = new Task(() => tick(func));
            //timer.Start();
            tick(func);
            run = true;
        }

        /// <summary>
        /// Stops the timer
        /// </summary>
        static public void stop()
        {
            run = false;
        }

        // It's about the tick... IT'S ALWAYS ABOUT THE TICK!!!
        static private void tick(Action func)
        {
            while (run)
            {
                func();
                Task.Delay(interval);
            }
            
        }
    }
}
