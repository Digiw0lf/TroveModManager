using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

using Microsoft.Win32;
using System.Security.Permissions;


using System.IO;
using System.IO.Compression;
using System.Windows.Forms;


namespace Trove_Mod_Manager_Launcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            string exeDirect = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
            try
            {
                using (WebClient wc = new WebClient())
                {
                    // wc.DownloadProgressChanged += wc_DownloadProgressChanged;
                    wc.DownloadFile(@"https://www.trovesaurus.com/modmanager/download", exeDirect + "\\temp.zip");

                }
                if (!Directory.Exists(exeDirect + "\\temp"))
                    Directory.CreateDirectory(exeDirect + "\\temp");

                ZipFile.ExtractToDirectory(exeDirect + "\\temp.zip", exeDirect + "\\temp\\");

                string versionNum = File.ReadAllText(exeDirect + "\\temp\\Release.txt");

                int currentVersion = Int32.Parse(File.ReadAllText(exeDirect + "\\Release.txt"));
                if (Int32.Parse(versionNum) > currentVersion)
                {
                    // File.Delete(exeDirect + "\\Trove Mod Manager.exe");
                    //File.Delete(exeDirect + "\\Trove Mod Manager.exe.config");
                    if (Directory.Exists(exeDirect + "\\Resources"))
                    {
                        Directory.Delete(exeDirect + "\\Resources", true);
                        //Directory.CreateDirectory(exeDirect + "\\Resources");
                        Directory.Move(exeDirect + "\\temp\\Resources", exeDirect + "\\Resources");
                    }
                    else
                    {
                        Directory.Move(exeDirect + "\\temp\\Resources", exeDirect + "\\Resources");
                        
                    }


                    File.Copy(exeDirect + "\\temp\\Trove Mod Manager.exe", exeDirect + "\\Trove Mod Manager.exe", true);
                    File.Copy(exeDirect + "\\temp\\Trove Mod Manager.exe.config", exeDirect + "\\Trove Mod Manager.exe.config", true);
                    File.Copy(exeDirect + "\\temp\\Release.txt", exeDirect + "\\Release.txt", true);




                }
               // Directory.Delete(exeDirect + "\\temp", true);
                File.Delete(exeDirect + "\\temp.zip");
            }
            catch { }

           

            
            System.Diagnostics.Process.Start(exeDirect + "\\Trove Mod Manager.exe");

            Application.Exit();

        }


    }
}
