using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Configuration;

namespace ToolBox_Cloud_PC_v2
{
    public partial class CloudPCToolBox : Form
    {
        public CloudPCToolBox()
        {
            InitializeComponent();
        }
        //
        // Intranet
        //
        private void button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo cmd = new ProcessStartInfo();
            cmd.FileName = @"cmd.exe";
            cmd.WindowStyle= ProcessWindowStyle.Hidden;
            cmd.Arguments = @"/c start https://lgema.lge.com/index.php?action=main_page";
            Process.Start(cmd);
        }
        //
        // Security Portal
        //
        private void button8_Click(object sender, EventArgs e)
        {
            ProcessStartInfo s = new ProcessStartInfo();
            s.FileName = @"cmd.exe";
            s.WindowStyle = ProcessWindowStyle.Hidden;
            s.Arguments = @"/c start http://security.lge.com:5030/login.LoginDo.public.laf";
            Process.Start(s);
        }
        //
        // Mail
        //
        private void button12_Click(object sender, EventArgs e)
        {
            ProcessStartInfo m = new ProcessStartInfo();
            m.FileName = @"cmd.exe";
            m.WindowStyle = ProcessWindowStyle.Hidden;
            m.Arguments = @"/c start http://sso.lge.com";
            Process.Start(m);
        }
        //
        // ServiceDesk
        //
        private void button2_Click(object sender, EventArgs e)
        {
            ProcessStartInfo Serv = new ProcessStartInfo();
            Serv.FileName = @"cmd.exe";
            Serv.WindowStyle = ProcessWindowStyle.Hidden;
            Serv.Arguments = @"/c start https://lgema.lge.com/index.php?action=login";
            Process.Start(Serv);
        }
        //
        // Teta
        //
        private void button7_Click(object sender, EventArgs e)
        {
            ProcessStartInfo Tet = new ProcessStartInfo();
            Tet.FileName = @"cmd.exe";
            Tet.WindowStyle = ProcessWindowStyle.Hidden;
            Tet.Arguments = @"/c start https://ma-mf10-teta.lge.net/Core/Account/Login?ReturnUrl=%2F";
            Process.Start(Tet);
        }
        //
        // +SW dysk >> SW
        //
        private void button11_Click(object sender, EventArgs e)
        {
            ProcessStartInfo SW = new ProcessStartInfo();
            SW.FileName = @"cmd.exe";
            SW.WindowStyle = ProcessWindowStyle.Hidden;
            SW.Arguments = @"/c cd C:\\Users\\arkadiusz.mulkityn\\Desktop\\ToolBox Cloud PC v2 && start SW.bat";
            Process.Start(SW);

            Thread.Sleep(3000); // pauza na 3 sekundy

            Process.Start(@"S:");
        }
       //
       // Cloud Disk >> Planning
       //
        private void button4_Click(object sender, EventArgs e)
        {
            ProcessStartInfo Di = new ProcessStartInfo();
            Di.FileName = @"cmd.exe";
            Di.WindowStyle = ProcessWindowStyle.Hidden;
            Di.Arguments = @"/c cd C:\Program Files (x86)\LG CNS\CloudDisk\ && start LGCNS.CDS.UpdateManager.exe";
            Process.Start(Di);

            Thread.Sleep(3000); // pauza na 3 sekundy

            Process.Start(@"Z:\01. Planning");
        }
        //
        // zabbix
        //
        private void button6_Click(object sender, EventArgs e)
        {
            ProcessStartInfo za = new ProcessStartInfo();
            za.FileName = @"cmd.exe";
            za.WindowStyle = ProcessWindowStyle.Hidden;
            za.Arguments = @"/c start http://150.150.222.42/zabbix/zabbix.php?action=dashboard.view";
            Process.Start(za);
        }
        //
        // Messenger
        //
        private void button10_Click(object sender, EventArgs e)
        {
            ProcessStartInfo mes = new ProcessStartInfo();
            mes.FileName = @"cmd.exe";
            mes.WindowStyle = ProcessWindowStyle.Hidden;
            mes.Arguments = @"/c cd C:\Program Files (x86)\LG UCAP\ && start UCAP.exe";
            Process.Start(mes);
        }
        
     
    }
}
