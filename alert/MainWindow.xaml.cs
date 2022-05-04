using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Drawing;

namespace alert
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        utils.Timer signalCheckTimer = new utils.Timer();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnOnOff_Click(object sender, RoutedEventArgs e)
        {
            if (signalCheckTimer.isRunning())
            {
                signalCheckTimer.stop();
                btnOnOff.Content = "OFF";
                btnOnOff.Background = Brushes.Red;
            }
            else
            {
                signalCheckTimer.start(() => App.signalCheck());
                btnOnOff.Content = "ON";
                btnOnOff.Background = Brushes.Green;
            }
        }
    }
}
