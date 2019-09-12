using System;
using System.IO;
using System.ServiceProcess;
using System.Text;
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
        static private FileSystemWatcher[] fileSystemWatcher;
        readonly string path = @"D:\";
        readonly string fileName = "Log.txt";       
        public Service1()
        {
            InitializeComponent();
            string[] drive = Environment.GetLogicalDrives();
            fileSystemWatcher = new FileSystemWatcher[drive.Length]; 
            for (int i = 0; i < drive.Length; i++)
            {
            fileSystemWatcher[i] = new FileSystemWatcher(drive[i]);
            fileSystemWatcher[i].IncludeSubdirectories = true;
            fileSystemWatcher[i].Deleted += FileSystemWatcher_Deleted;
            }    
        }

        protected override void OnStart(string[] args)
        {
            foreach (var item in fileSystemWatcher)
            {
                item.EnableRaisingEvents = true;
            }           
        }

        private void FileSystemWatcher_Deleted(object sender, FileSystemEventArgs e)
        {
            string filepath = path + fileName;            
            StringBuilder stringBuilder = new StringBuilder();
            dateTime = DateTime.UtcNow;
            stringBuilder.Append(dateTime.ToString());
            stringBuilder.Append(" "+e.FullPath + " был удален!\n");
            File.AppendAllText(filepath,stringBuilder.ToString());
        }

        protected override void OnStop()
        {
            foreach (var item in fileSystemWatcher)
            {
                item.EnableRaisingEvents = false;
            }            
        }
    }
}
