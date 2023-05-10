using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ToolBox_v2
{
    public partial class menu : Form
    {
        Thread th;
        

        //
        // Work
        //
        //public void openform3(object obj)
        //{
        //    Application.Run(new Form3());
        //}
        public menu()
        {
            InitializeComponent();

        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
            f3 = null;
            this.Show();
            
            // warte zapamietania - zamyka formularz i otwiera nowy 
            // |
            // V
            //this.Close();
            //th = new Thread(openform3);
            //th.SetApartmentState(ApartmentState.STA);
            //th.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog(); 
            f2 = null;
            this.Show();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog(); 
            f4 = null;
            this.Show();
        }
    }
}
