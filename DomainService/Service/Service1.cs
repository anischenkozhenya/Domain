using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
//Создайте службу Windows, которая будет мониторить жесткие диски и при удалении из этих
//дисков файла записывать информацию(полный путь) в текстовый файл.
//Создайте WPF приложение.Разместите в нем TextBox, в который с определенной
//периодичностью будет считываться информация из текстового файла(в который пишет
//сервис). Также разместите четыре кнопки, которые будут отвечать за установку, деинсталяцию,
//старт и остановку сервиса.
namespace Service
{
    public partial class Service1 : ServiceBase
    {
        DateTime dateTime;
        DriveInfo[] drives = DriveInfo.GetDrives();
        FileSystemWatcher fileSystemWatcher;
        string path = @"..\..\";
        string fileName = "Log.txt";
        ProcessStartInfo processStartInfo;
        
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {            
            for (int i = 0; i < drives.Length; i++)
            {
                fileSystemWatcher = new FileSystemWatcher(drives[i].Name.ToString());
                fileSystemWatcher.Deleted += FileSystemWatcher_Deleted;
            }
        }

        private void FileSystemWatcher_Deleted(object sender, FileSystemEventArgs e)
        {
            string filepath = path + fileName;            
            StringBuilder stringBuilder = new StringBuilder();
            dateTime = DateTime.UtcNow;
            stringBuilder.Append(dateTime.ToString());
            stringBuilder.Append(e.FullPath + " был удален!");
            File.AppendAllText(filepath,stringBuilder.ToString());
        }

        protected override void OnStop()
        {
        }
    }
}
