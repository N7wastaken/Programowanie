using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolBox_2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //
        // Visual Studio
        //
        private void button2_Click(object sender, EventArgs e)
        {
            ProcessStartInfo v = new ProcessStartInfo();
            v.FileName = @"cmd.exe";
            v.WindowStyle = ProcessWindowStyle.Hidden;
            v.Arguments = @"/c cd C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\IDE\ && start devenv.exe";
            Process.Start(v);
            label1.Focus();
        }
        //
        // Cloud PC
        //

        public void exclick()
        {
            
            if (File.Exists(@"C:\Users\arkadiusz.mulkityn\Downloads\vmcubelauncher.ica"))
            {
                ProcessStartInfo clo = new ProcessStartInfo();
                clo.FileName = @"cmd.exe";
                clo.WindowStyle = ProcessWindowStyle.Hidden;
                clo.Arguments = @"/c cd C:\Users\arkadiusz.mulkityn\Downloads && start vmcubelauncher.ica && del vmcubelauncher";
                Process.Start(clo);
                Thread.Sleep(2000);
                Process[] processNames = Process.GetProcessesByName("msedge");

                foreach (Process item in processNames)
                {
                    item.Kill();
                }
            }
            else
            {
                Thread.Sleep(2000);
                exclick();
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo cmd = new ProcessStartInfo();
            cmd.FileName = @"cmd.exe";
            cmd.WindowStyle = ProcessWindowStyle.Hidden;
            cmd.Arguments = @"/c start /max msedge.exe https://eicvpc.lge.com/vmCube/Launcher/DesktopLauncher/ViewDesktop";
            Process.Start(cmd);
            //Clipboard.SetText("Zaqwsx439!");
            label1.Focus();

            //Thread.Sleep(6000);
            exclick();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProcessStartInfo b = new ProcessStartInfo();
            b.FileName = @"cmd.exe";
            b.WindowStyle = ProcessWindowStyle.Hidden;
            b.Arguments = @"/c cd C:\Program Files\Blender Foundation\Blender 3.4\ && start blender";
            Process.Start(b);
            label1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProcessStartInfo s = new ProcessStartInfo();
            s.FileName = @"cmd.exe";
            s.WindowStyle = ProcessWindowStyle.Hidden;
            s.Arguments = @"/c  start http://lgemaras.lge.com/en/";
            Process.Start(s);
            label1.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProcessStartInfo ms = new ProcessStartInfo();
            ms.FileName = @"cmd.exe";
            ms.WindowStyle = ProcessWindowStyle.Hidden;
            ms.Arguments = @"/c  start msra /offerra";
            Process.Start(ms);
            label1.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(File.Exists("C:\\Users\\arkadiusz.mulkityn\\AppData\\Local\\RAExpertHistory.xml")) 
            {
                File.Delete("C:\\Users\\arkadiusz.mulkityn\\AppData\\Local\\RAExpertHistory.xml");
            }
            label1.Focus();
        }
    }
}
