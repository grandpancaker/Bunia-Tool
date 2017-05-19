using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int ShutDownTime1 { get; set; } = 0;
        public int TurnOffScreenTime { get; set; } = 0;
        public int TurnOffTorrent { get; set; } = 0;
        public int TurnOffInternetFor { get; set; } = 0;
        public static bool NetOnOf { get; set; } = true;


        public MainWindow()
        {
            InitializeComponent();
        }
        
        
        //static void Enable(string interfaceName)
        //{
        //    var accessLevel = await Radio.RequestAccessAsync();
        //    var radios = await Radio.GetRadiosAsync();

        //    if (NetOnOf)
        //    {
        //        Radio radio = SOME_RADIO;
        //        radio.StateChanged = Radio_StateChangedCallback; // Called when the radio state completes the change
        //        radio.SetStateAsync(RadioState.On); // Or RadioState.Off

        //        NetOnOf = false;
        //    }
        //    else
        //    {
        //        Radio radio = SOME_RADIO;
        //        radio.StateChanged = Radio_StateChangedCallback; // Called when the radio state completes the change
        //        radio.SetStateAsync(RadioState.Off; // Or RadioState.Off

        //        NetOnOf = true;
        //    }
        //}
    


        private void RunItButtonClick(object sender, RoutedEventArgs e)
        {
            //% systemroot %\system32\scrnsave.scr / s
            //Process.Start("shutdown", "/s /t 0");
            //Process.Start("scrnsave.scr", "/s"); // turn of screen

        }
    }
}