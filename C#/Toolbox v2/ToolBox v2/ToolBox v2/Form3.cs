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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProcessStartInfo gx = new ProcessStartInfo();
            gx.FileName = @"cmd.exe";
            gx.WindowStyle= ProcessWindowStyle.Hidden;
            gx.Arguments = @"/c cd C:\Users\admin\AppData\Local\Programs\Opera GX && start launcher.exe ";
            Process.Start(gx);
            label1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo yt = new ProcessStartInfo();
            yt.FileName = @"cmd.exe";
            yt.WindowStyle= ProcessWindowStyle.Hidden;
            yt.Arguments = @"/c start https://www.youtube.com/@TivoltGames";
            Process.Start(yt);
            label1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProcessStartInfo hd = new ProcessStartInfo();
            hd.FileName = @"cmd.exe";
            hd.WindowStyle= ProcessWindowStyle.Hidden;
            hd.Arguments = @"/c start https://hdtoday.tv";
            Process.Start(hd);
            label1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ProcessStartInfo Tw = new ProcessStartInfo();
            Tw.FileName = @"cmd.exe";
            Tw.WindowStyle = ProcessWindowStyle.Hidden;
            Tw.Arguments = @"/c start https://www.twitch.tv";
            Process.Start(Tw);
            label1.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProcessStartInfo gm = new ProcessStartInfo();
            gm.FileName = @"cmd.exe";
            gm.WindowStyle = ProcessWindowStyle.Hidden;
            gm.Arguments = @"/c start https://mail.google.com/mail/u/0/#inbox";
            Process.Start(gm);
            label1.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ProcessStartInfo ig = new ProcessStartInfo();
            ig.FileName = @"cmd.exe";
            ig.WindowStyle= ProcessWindowStyle.Hidden;
            ig.Arguments = @"/c start https://www.instagram.com";
            Process.Start(ig);
            label1.Focus();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ProcessStartInfo nf = new ProcessStartInfo();
            nf.FileName = @"cmd.exe";
            nf.WindowStyle = ProcessWindowStyle.Hidden;
            nf.Arguments = @"/c start https://www.netflix.com/browse";
            Process.Start(nf);
            label1.Focus();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ProcessStartInfo ali = new ProcessStartInfo();
            ali.FileName = @"cmd.exe";
            ali.WindowStyle = ProcessWindowStyle.Hidden;
            ali.Arguments = @"/c start https://best.aliexpress.com/?dp=8d2d885a8e71cce4b5ad67c18d163133&af=630324&cv=47843&afref=&utm_source=admitad&utm_medium=cpa&utm_campaign=630324&utm_content=47843&aff_fcid=3a5705d80e5b43f19c58da38edf20e8c-1672255624423-07767-_ePNSNV&aff_fsk=_ePNSNV&aff_platform=portals-tool&sk=_ePNSNV&aff_trace_key=3a5705d80e5b43f19c58da38edf20e8c-1672255624423-07767-_ePNSNV&terminal_id=f2eeead706e048caa1842d55eed46237";
            Process.Start(ali);
            label1.Focus();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
