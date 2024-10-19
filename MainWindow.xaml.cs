
using System.Windows;
using System.Runtime.InteropServices;



namespace Commander
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TurnDisplayOff(object sender, RoutedEventArgs e)
        {
            SendMessage(-1, 0x0112, 0xF170, 2);
        }

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        public static extern int SendMessage(int hWnd, int hMsg, int wParam, int lParam);
        
    }
}
