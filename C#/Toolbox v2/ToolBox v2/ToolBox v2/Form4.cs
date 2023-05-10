using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;

namespace ToolBox_v2
{
    public partial class Form4 : Form
    {
      
        public Form4()
        {
            InitializeComponent();
        }

        //
        // zamyka formularz
        //
        private void button13_Click(object sender, EventArgs e)
        {
        this.Close();
        }

        //
        // VS
        //
        private void button2_Click(object sender, EventArgs e)
        {
            ProcessStartInfo vs = new ProcessStartInfo();
            vs.FileName = @"cmd.exe";
            vs.WindowStyle = ProcessWindowStyle.Hidden;
            vs.Arguments = @"/c cd C:\Program Files\Microsoft Visual Studio\2022\Community\Common7\IDE\ && start devenv.exe";
            Process.Start(vs);
            label1.Focus();
        }

        //
        // Github
        //
        private void button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo git = new ProcessStartInfo();
            git.FileName = @"cmd.exe";
            git.WindowStyle = ProcessWindowStyle.Hidden;
            git.Arguments = @"/c start https://github.com/N7wastaken/Programowanie";
            Process.Start(git);
            label1.Focus();

        }

        //
        // Dysk z Etrapezem
        //
        private void button3_Click(object sender, EventArgs e)
        {
            ProcessStartInfo d = new ProcessStartInfo();
            d.FileName = @"cmd.exe";
            d.WindowStyle = ProcessWindowStyle.Hidden;
            d.Arguments = @"/c start https://drive.google.com/drive/u/3/folders/15ki2mATp2ay9hY4RWnyNSADZGIrusC3p";
            Process.Start(d);
            label1.Focus();
        }

        //
        // Blender 3D
        //
        private void button4_Click(object sender, EventArgs e)
        {
            ProcessStartInfo bl = new ProcessStartInfo();
            bl.FileName = @"cmd.exe";
            bl.WindowStyle = ProcessWindowStyle.Hidden;
            bl.Arguments = @"/c cd C:\Program Files\Blender Foundation\Blender 3.4\ && start blender-launcher.exe";
            Process.Start(bl);
            label1.Focus();
        }

        //
        // Zonda PRO
        //
        private void button5_Click(object sender, EventArgs e)
        {
            ProcessStartInfo z = new ProcessStartInfo();
            z.FileName = @"cmd.exe";
            z.WindowStyle = ProcessWindowStyle.Hidden;
            z.Arguments = @"/c start https://pro.zonda.exchange";
            Process.Start(z);
            label1.Focus();
        }

        //
        // PayPal
        //
        private void button6_Click(object sender, EventArgs e)
        {
            ProcessStartInfo p = new ProcessStartInfo();
            p.FileName = @"cmd.exe";
            p.WindowStyle = ProcessWindowStyle.Hidden;
            p.Arguments = @"/c start https://www.paypal.com/myaccount/summary";
            Process.Start(p);
            label1.Focus();
        }
        
        //
        // Money pekao
        //
        private void button12_Click(object sender, EventArgs e)
        {
            ProcessStartInfo mon = new ProcessStartInfo();
            mon.FileName = @"cmd.exe";
            mon.WindowStyle = ProcessWindowStyle.Hidden;
            mon.Arguments = @"/c start https://www.pekao24.pl/logowanie";
            Process.Start(mon);
            label1.Focus();
        }

        //
        // Excel
        //
        private void button11_Click(object sender, EventArgs e)
        {
            ProcessStartInfo ex = new ProcessStartInfo();
            ex.FileName = @"cmd.exe";
            ex.WindowStyle = ProcessWindowStyle.Hidden;
            ex.Arguments = @"/c start excel";
            Process.Start(ex);
            label1.Focus();
        }

        //
        // PowerPoint
        //
        private void button10_Click(object sender, EventArgs e)
        {
            ProcessStartInfo pp = new ProcessStartInfo();
            pp.FileName = @"cmd.exe";
            pp.WindowStyle = ProcessWindowStyle.Hidden;
            pp.Arguments = @"/c start powerpnt";
            Process.Start(pp);
            label1.Focus();
        }

        //
        // Teams
        //
        private void button9_Click(object sender, EventArgs e)
        {
            ProcessStartInfo tea = new ProcessStartInfo();
            tea.FileName = @"cmd.exe";
            tea.WindowStyle = ProcessWindowStyle.Hidden;
            tea.Arguments = @"/c cd %LOCALAPPDATA%\Microsoft\Teams\current && start Teams.exe";
            Process.Start(tea);
            label1.Focus();
        }

        //
        // Outlook
        //
        private void button8_Click(object sender, EventArgs e)
        {
            ProcessStartInfo o = new ProcessStartInfo();
            o.FileName = @"cmd.exe";
            o.WindowStyle = ProcessWindowStyle.Hidden;
            o.Arguments = @"/c start outlook";
            Process.Start(o);
            label1.Focus();
        }

        //
        // word
        //
        private void button7_Click(object sender, EventArgs e)
        {
            ProcessStartInfo w = new ProcessStartInfo();
            w.FileName = @"cmd.exe";
            w.WindowStyle = ProcessWindowStyle.Hidden;
            w.Arguments = @"/c start winword";
            Process.Start(w);
            label1.Focus();
        }
    }
}
