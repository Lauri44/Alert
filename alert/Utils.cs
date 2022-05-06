using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

/// <summary>
/// Provides utilitys
/// </summary>
namespace utils
{
    /// <summary>
    /// Timer
    /// </summary>
    class Timer
    {
        // Since WPF has no Timer itself i created my own

        private int milliseconds;
        private bool run = false;
        private Action func;


        /// <summary>
        /// Takes a function as a argument and runs it in certain intervals. <br/>
        /// Takes int as argument for the lenght (1000 = 1000ms = 1s). Default time is 1000
        /// </summary>
        /// <param name="func"></param>
        /// <param name="milliseconds"></param>
        public Timer(Action func, int milliseconds = 1000)
        {
            this.func = func;
            this.milliseconds = milliseconds;
        }

        /// <summary>
        /// Starts the timer. <br/>
        /// </summary>
        public void start()
        {
            new Thread(() => tick(func, milliseconds)).Start();
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
                Thread.Sleep(milliseconds);
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
