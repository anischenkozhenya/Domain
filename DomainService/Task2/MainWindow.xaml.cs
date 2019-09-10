using System;
using System.Collections.Generic;
using System.Configuration.Install;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
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


namespace Task2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ServiceController controller;
        private string servicePath = @"..\..\..\Service\obj\Debug\Service.exe";

        public MainWindow()
        {
            InitializeComponent();           
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
            MessageBox.Show("Служба запущена");
        }

        private void UninstallBtn_Click(object sender, RoutedEventArgs e)
        {
            ManagedInstallerClass.InstallHelper(new string[] { @"/u",servicePath});
            MessageBox.Show("Служба удалена");
            
        }
    }
}
