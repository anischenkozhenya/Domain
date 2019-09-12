using System;
using System.Configuration.Install;
using System.IO;
using System.ServiceProcess;
using System.Windows;
using System.Windows.Threading;
namespace Task2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IDisposable
    {
        private ServiceController controller;
        private readonly string servicePath = @"..\..\..\Service\obj\Debug\Service.exe";
        readonly DispatcherTimer timer = new DispatcherTimer();
        readonly string logfile = @"D:\Log.txt";
        public MainWindow()
        {
            InitializeComponent();
            if (!File.Exists(logfile))
            {
                File.CreateText(logfile).Close();
            }
            timer.Tick += Timer_Tick;
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.Start();
            controller = new ServiceController();
            controller.ServiceName = "=MyService=";
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            textBox.Text = File.ReadAllText(logfile);
            Scrlwvr.ScrollToEnd();
        }


        private void InstallBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ManagedInstallerClass.InstallHelper(new string[] { servicePath });
                MessageBox.Show("Служба установлена");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }

        private void StartServiceBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {                
                controller.Start();
                MessageBox.Show("Служба запущена");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void StopServiceBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {                
                controller.Stop();
                MessageBox.Show("Служба остановлена");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void UninstallBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ManagedInstallerClass.InstallHelper(new string[] { @"/u", servicePath });
                MessageBox.Show("Служба удалена");
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }

        }

        public void Dispose()
        {
            timer.Stop();
            controller.Close();
        }
    }
}
