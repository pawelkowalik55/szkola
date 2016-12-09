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
        Czas time = new Czas();
        
        
     
        
        private int gear = 1;
        
        public Form1()
        {
            InitializeComponent();
        }

       

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void spd_up_Click(object sender, EventArgs e)
        {
            speed++;
            if (speed > 0)
                gear = 1;
            if (speed > 20)
                gear = 2;
            if (speed > 40)
                gear = 3;
            if (speed > 60)
                gear = 4;
            if (speed > 80)
                gear = 5;
            if (speed > 100)
                gear = 6;
            spd.Text = Convert.ToString(speed);
            tbgear.Text = Convert.ToString(gear);
        }

        private void spd_down_Click(object sender, EventArgs e)
        {
            speed--;
            if (speed == -1)
                speed++;
            if (speed > 0)
                gear = 1;
            if (speed > 20)
                gear = 2;
            if (speed > 40)
                gear = 3;
            if (speed > 60)
                gear = 4;
            if (speed > 80)
                gear = 5;
            if (speed > 100)
                gear = 6;
            spd.Text = Convert.ToString(speed);
            Update();
            tbgear.Text = Convert.ToString(gear);
        }

        private void distance_TextChanged(object sender, EventArgs e)
        {
            double i = 0;
            do
            {
                i += 0.1;
            } while (i==800);
        }

        private void refresh_Click(object sender, EventArgs e)
        {

            distance.Text = Convert.ToString(TimeSpan.TicksPerMinute);

        }

        private void tbgear_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
