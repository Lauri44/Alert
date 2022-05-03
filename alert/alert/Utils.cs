using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace utils
{
    static class Timer
    {
        // Since WPF has no Timer itself i created my own one

        static public int interval { get; set; }
        static private bool run = false;
        static public void start(Action func)
        {
            //Task timer = new Task(() => tick(func));
            //timer.Start();
            tick(func);
            run = true;
        }

        static public void stop()
        {
            run = false;
        }

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
