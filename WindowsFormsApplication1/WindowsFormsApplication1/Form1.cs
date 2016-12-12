using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private static readonly Random r = new Random(7);
        public int speed = r.Next(0, 200);
        private float czas;


        private int gear = 1;

        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {
        }


        private void spd_up_Click(object sender, EventArgs e)
        {
            speed++;
            if (speed == 251)
                speed--;
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

            tbgear.Text = Convert.ToString(gear);
        }

        private float dystans = 0;

        private void distance_TextChanged(object sender, EventArgs e)
        {
        }


        private void tbgear_TextChanged(object sender, EventArgs e)
        {
            tbgear.Text = gear.ToString();
        }


        private void start_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();


            spd.Text = Convert.ToString(speed);
            spd.Text = Convert.ToString(gear);
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
            tbgear.Text = speed.ToString();

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            czas += 1;
            
            tbtime.Text = czas.ToString();
            dystans += czas * speed/3600;
            distance.Text = dystans.ToString();
        }

        
        

    

        private void spd_TextChanged(object sender, EventArgs e)
        {
            spd.Text = speed.ToString();
        }
    }
}
