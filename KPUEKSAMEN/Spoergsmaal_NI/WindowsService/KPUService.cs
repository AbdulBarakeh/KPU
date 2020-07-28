using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WindowsService
{
    public partial class KPUService : ServiceBase
    {
        public KPUService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            System.IO.File.AppendAllText("C:\\Users\\Abdul\\Documents\\UNI\\6_Semester\\KPUEKSAMEN\\Spoergsmaal_NI\\logKPUservice.txt",
                "\n Service has been started" + " @" + DateTime.Now);
        }

        protected override void OnStop()
        {
            System.IO.File.AppendAllText("C:\\Users\\Abdul\\Documents\\UNI\\6_Semester\\KPUEKSAMEN\\Spoergsmaal_NI\\logKPUservice.txt",
                "\n Service has been stopped" + " @" + DateTime.Now);
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            System.IO.File.AppendAllText("C:\\Users\\Abdul\\Documents\\UNI\\6_Semester\\KPUEKSAMEN\\Spoergsmaal_NI\\logKPUservice.txt",
                "\n Change happened in " + e.FullPath + " @"+ DateTime.Now + "\n This happened: " + e.ChangeType);
        }

        private void fileSystemWatcher1_Renamed(object sender, System.IO.FileSystemEventArgs e)
        {
            System.IO.File.AppendAllText("C:\\Users\\Abdul\\Documents\\UNI\\6_Semester\\KPUEKSAMEN\\Spoergsmaal_NI\\logKPUservice.txt",
                "\n Change happened in " + e.FullPath + " @" + DateTime.Now + "\n This happened: " + e.ChangeType);

        }
        private void fileSystemWatcher1_Deleted(object sender, System.IO.FileSystemEventArgs e)
        {
            System.IO.File.AppendAllText("C:\\Users\\Abdul\\Documents\\UNI\\6_Semester\\KPUEKSAMEN\\Spoergsmaal_NI\\logKPUservice.txt",
                "\n Change happened in " + e.FullPath + " @" + DateTime.Now + "\n This happened: " + e.ChangeType);

        }
        private void fileSystemWatcher1_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            System.IO.File.AppendAllText("C:\\Users\\Abdul\\Documents\\UNI\\6_Semester\\KPUEKSAMEN\\Spoergsmaal_NI\\logKPUservice.txt",
                "\n Change happened in " + e.FullPath + " @" + DateTime.Now + "\n This happened: " + e.ChangeType);

        }
    }
}
