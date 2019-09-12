using System;
using System.ComponentModel;
using System.IO;
using System.Security;
using System.Security.Permissions;
using System.Security.Policy;
using System.Windows.Forms;

namespace task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ChooseBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            textBox1.Text = openFileDialog1.SafeFileName;
        }

        private void StartApp_Click(object sender, EventArgs e)
        {
            AppDomainSetup appDomainSetup = new AppDomainSetup();
            appDomainSetup.ApplicationBase = Path.GetFullPath(Application.ExecutablePath);
            PermissionSet permissionSet = new PermissionSet(PermissionState.None);
            permissionSet.AddPermission(new SecurityPermission(SecurityPermissionFlag.Execution));
            permissionSet.AddPermission(new FileIOPermission(FileIOPermissionAccess.AllAccess, @"E:\"));
            permissionSet.AddPermission(new UIPermission(UIPermissionWindow.AllWindows, UIPermissionClipboard.AllClipboard));
            var fullTrustAssembly = typeof(Form).Assembly.Evidence.GetHostEvidence<StrongName>();
            var newDomain = AppDomain.CreateDomain("SecondaryDomainApp", null, appDomainSetup,permissionSet, fullTrustAssembly);
            newDomain.ExecuteAssembly(openFileDialog1.FileName);
        }        
    }
}
