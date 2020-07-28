using System.IO;
using System.ServiceProcess;

namespace WindowsService
{
    partial class KPUService
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.IncludeSubdirectories = true;
            this.fileSystemWatcher1.NotifyFilter = ((System.IO.NotifyFilters)((((((((System.IO.NotifyFilters.FileName | System.IO.NotifyFilters.DirectoryName) 
            | System.IO.NotifyFilters.Attributes) 
            | System.IO.NotifyFilters.Size) 
            | System.IO.NotifyFilters.LastWrite) 
            | System.IO.NotifyFilters.LastAccess) 
            | System.IO.NotifyFilters.CreationTime) 
            | System.IO.NotifyFilters.Security)));
            this.fileSystemWatcher1.Path = "C:\\Windows\\Temp\\KPU1\\";
            this.fileSystemWatcher1.Changed += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Changed);
            this.fileSystemWatcher1.Renamed += new System.IO.RenamedEventHandler(this.fileSystemWatcher1_Renamed);
            this.fileSystemWatcher1.Deleted += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Deleted);
            this.fileSystemWatcher1.Created += new System.IO.FileSystemEventHandler(this.fileSystemWatcher1_Created);
            // 
            // KPUService
            // 
            this.ServiceName = "KPUService";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}
