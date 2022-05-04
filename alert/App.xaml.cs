using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace alert
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        static private List<int> signalList = new List<int>();

        static public void signalCheck()
        {
            for(int signal = 1; signal <= 4; signal++)
            {
                if (api.ReadDigitalChannel(signal) && !signalList.Contains(signal))
                {
                    signalList.Add(signal);
                }
                else if(!api.ReadDigitalChannel(signal) && signalList.Contains(signal))
                {
                    signalList.Remove(signal);
                }
            }
        }
    }
}
