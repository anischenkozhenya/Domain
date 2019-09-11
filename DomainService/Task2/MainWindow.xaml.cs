using System;
using System.Collections.Generic;
using System.Configuration.Install;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace Task2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        private ServiceController controller;
        private string servicePath = @"..\..\..\Service\obj\Debug\Service.exe";
        DispatcherTimer timer = new DispatcherTimer();
        string logfile = @"D:\Log.txt";        
        public MainWindow()
        {
            InitializeComponent();
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0,0,5);
            timer.Start();
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            textBox.Text = File.ReadAllText(logfile);
        }

        private async Task<string> ShowLogFile()
        {
            await Task<string>.Run(()=> {
                string result = File.ReadAllText(logfile);
                return result;
            });
            return null;
        }

        private void InstallBtn_Click(object sender, RoutedEventArgs e)
        {

            ManagedInstallerClass.InstallHelper(new string[] { servicePath });
            MessageBox.Show("Служба установлена");

        }

        private void StartServiceBtn_Click(object sender, RoutedEventArgs e)
        {
            controller = new ServiceController();
            controller.ServiceName = "=MyService=";
            controller.Start();
            MessageBox.Show("Служба запущена");
        }

        private void StopServiceBtn_Click(object sender, RoutedEventArgs e)
        {
            controller = new ServiceController();
            controller.ServiceName = "=MyService=";
            controller.Stop();
            MessageBox.Show("Служба остановлена");
        }

        private void UninstallBtn_Click(object sender, RoutedEventArgs e)
        {
            ManagedInstallerClass.InstallHelper(new string[] { @"/u",servicePath});
            MessageBox.Show("Служба удалена");
            
        }
    }
}
