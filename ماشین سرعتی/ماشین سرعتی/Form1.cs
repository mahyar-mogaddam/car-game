using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ماشین_سرعتی
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            picCar.Left += 5;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            timer1.Enabled = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            timer1.Enabled = false;
            if ((picCar.Right + 10 > picBarrier.Left) &&
                (picCar.Right < picBarrier.Left))
                MessageBox.Show("you win");
            else
                MessageBox.Show("you lose");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
