using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0806
{
    public partial class Form1 : Form
    {
        int vx = -10;
        int vy = -10;
        int a = Math.Abs(-10);
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Top += vx;
            label1.Left += vy;

            if (label1.Left < 0)
            {
                //vy = a * 11 / 10;
                vy = Math.Abs(vy) * 11 / 10;
            }
            
            if (label1.Top < 0)
            {
                //vx = a * 11 / 10;
                vx = Math.Abs(vx) * 11 / 10;
            }
             if(label1.Right > ClientSize.Width)
            //if (label1.Left > 234)
            {
                //vy = -a * 11 / 10;
                 vy = -Math.Abs(vy) * 11 / 10;
            }
             if (label1.Bottom > ClientSize.Height)
            //if (label1.Top > 234)
            {
                //vx = -a * 11 / 10;
                vx = -Math.Abs(vx) * 11 / 10;
            }

        }


        private void label1_Click(object sender, EventArgs e)
        {
            vx = 0;
            vy = 0;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("幅" + ClientSize.Width);
            //MessageBox.Show("高さ" + ClientSize.Height);
        }
       
    }
}
