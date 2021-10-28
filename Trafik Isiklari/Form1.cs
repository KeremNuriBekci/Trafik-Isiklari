using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trafik_Isiklari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayac;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
                                                     
        }

        private void Form1_Load(object sender, EventArgs e)
        {

                   
               



        }
    
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();


            for (int i = 0; i < 1; i++)

                timer1.Interval = 3000;
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox1.Show();



            timer1.Interval = 1000;
            pictureBox1.Hide();
            pictureBox3.Hide();
            pictureBox2.Show();



            timer1.Interval = 3000;
            pictureBox2.Hide();
            pictureBox1.Hide();
            pictureBox3.Show();
            
        }
    }   
}               
