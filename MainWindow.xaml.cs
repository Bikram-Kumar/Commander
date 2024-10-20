using System;
using System.Windows;
using System.Runtime.InteropServices;
using System.Timers;



namespace Commander
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private static System.Timers.Timer displayOffTimer;
        public MainWindow()
        {
            InitializeComponent();
            displayOffTimer = new System.Timers.Timer(500);
            displayOffTimer.Elapsed += SendMessageForDisplayOff;
            displayOffTimer.AutoReset = false;
        }

        private void TurnDisplayOff(object sender, RoutedEventArgs e)
        {
            displayOffTimer.Start();

        }

        public void SendMessageForDisplayOff(Object source, ElapsedEventArgs e)
        {
            SendMessage(-1, 0x0112, 0xF170, 2);

        }

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMessage(int hWnd, int hMsg, int wParam, int lParam);
        
    }
}
