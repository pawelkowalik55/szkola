using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        static Random r = new Random(5);
        public int speed = r.Next(0, 200);
        public Form1()
        {
            InitializeComponent();
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(TimeSpan.FromSeconds(1));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void spd_up_Click(object sender, EventArgs e)
        {
            speed++;
            spd.Text = Convert.ToString(speed);
        }

        private void spd_down_Click(object sender, EventArgs e)
        {
            speed--;
            spd.Text = Convert.ToString(speed);
        }
    }
}
