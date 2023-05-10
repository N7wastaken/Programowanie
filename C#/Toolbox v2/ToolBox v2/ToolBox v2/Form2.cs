using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToolBox_v2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

     
        private void button2_Click(object sender, EventArgs e)
        {
            ProcessStartInfo cmd = new ProcessStartInfo();
            cmd.FileName = @"cmd.exe";
            cmd.WindowStyle= ProcessWindowStyle.Hidden;
            cmd.Arguments = @"/c cd C:\Program Files (x86)\Steam\ && start Steam.exe ";
            Process.Start(cmd);
            label1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo ba = new ProcessStartInfo();
            ba.FileName = @"cmd.exe";
            ba.WindowStyle = ProcessWindowStyle.Hidden;
            ba.Arguments = @"/c cd C:\Program Files (x86)\Battle.net\ && start Battle.net Launcher.exe ";
            Process.Start(ba);
            label1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProcessStartInfo dc = new ProcessStartInfo();
            dc.FileName = @"cmd.exe";
            dc.WindowStyle = ProcessWindowStyle.Hidden;
            dc.Arguments = @"/c cd C:\Users\admin\AppData\Local\Discord\ && start Update.exe --processStart Discord.exe";
            Process.Start(dc);
            label1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sp = new ProcessStartInfo();
            sp.FileName = @"cmd.exe";
            sp.WindowStyle = ProcessWindowStyle.Hidden;
            sp.Arguments = @"/c start spotify";
            Process.Start(sp);
            label1.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProcessStartInfo ep = new ProcessStartInfo();
            ep.FileName = @"cmd.exe";
            ep.WindowStyle = ProcessWindowStyle.Hidden;
            ep.Arguments = @"/c cd C:\Program Files (x86)\Epic Games\Launcher\Portal\Binaries\Win32\ && start EpicGamesLauncher.exe";
            Process.Start(ep);
            label1.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ProcessStartInfo or = new ProcessStartInfo();
            or.FileName = @"cmd.exe";
            or.WindowStyle = ProcessWindowStyle.Hidden;
            or.Arguments = @"/c cd C:\Program Files\Electronic Arts\EA Desktop\EA Desktop\ && start EALauncher.exe";
            Process.Start(or);
            label1.Focus();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ProcessStartInfo lo = new ProcessStartInfo();
            lo.FileName = @"cmd.exe";
            lo.WindowStyle = ProcessWindowStyle.Hidden;
            lo.Arguments = @"/c cd C:\Riot Games\League of Legends\ && start LeagueClient.exe";
            Process.Start(lo);
            label1.Focus();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
