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
    class Timer
    {
        // Since WPF has no Timer itself i created my own

        private int time;
        private bool run = false;

        /// <summary>
        /// Starts the timer. <br/>
        /// Takes a function as a argument and runs it in certain intervals. <br/>
        /// Takes int as argument for the lenght (1000 = 1000ms = 1s). Default time is 1000
        /// </summary>
        public void start(Action func, int millisecodns = 1000)
        {
            if (run) { return; }
            new Task(() => tick(func, millisecodns)).Start();
            run = true;
        }

        /// <summary>
        /// Stops the timer
        /// </summary>
        public void stop()
        {
            run = false;
        }

        // It's about the tick... IT'S ALWAYS ABOUT THE TICK!!!
        private void tick(Action func, int milliseconds)
        {
            while (run)
            {
                
                Task.Delay(milliseconds);
                Console.WriteLine(1);
                //func();
            }
        }

        /// <summary>
        /// Returns true if the timer is running. Otherwise false
        /// </summary>
        public bool isRunning()
        {
            return run;
        }
    }
}
