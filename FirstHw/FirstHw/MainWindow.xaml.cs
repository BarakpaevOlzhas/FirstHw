using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

namespace FirstHw
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonClickOne(object sender, RoutedEventArgs e)
        {
            textBlockIp.Text = textBlockIp.Text.Remove(0,textBlockIp.Text.Count());
            IPHostEntry host = Dns.GetHostEntry(textBoxHost.Text);            
            foreach (IPAddress ip in host.AddressList)
                textBlockIp.Text += ip.ToString() + "\n";
        }

        private void ButtonClickTwo(object sender, RoutedEventArgs e)
        {            
            IPHostEntry entry = Dns.GetHostEntry(textBoxIp.Text);
            textBlockHost.Text = entry.HostName;
        }
    }
}
