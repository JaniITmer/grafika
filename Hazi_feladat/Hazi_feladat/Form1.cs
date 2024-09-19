using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Hazi_feladat
{
  
    public partial class Form1 : Form
    {
        Graphics g;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.DrawLine(new Pen(Color.LightGreen, 5f), 0, pictureBox1.Height - 100, pictureBox1.Width, pictureBox1.Height - 100);

            g.DrawLine(new Pen(Color.Gray, 7f), 0, pictureBox1.Height - 160, 150, pictureBox1.Height - 160);
            g.DrawLine(new Pen(Color.Gray, 7f), 0, pictureBox1.Height - 60, 150, pictureBox1.Height - 60);
            g.DrawRectangle(new Pen(Color.Black,3f),200,150,240,240);
            g.FillRectangle(new SolidBrush(Color.DarkGreen), 8,250, 22, 160);
            g.FillRectangle(new SolidBrush(Color.DarkGreen), 36, 250, 22, 160);
            g.FillRectangle(new SolidBrush(Color.DarkGreen), 64, 250, 22, 160);
            g.FillRectangle(new SolidBrush(Color.DarkGreen), 92, 250, 22, 160);
            g.FillRectangle(new SolidBrush(Color.DarkGreen), 120, 250, 22, 160);



            g.FillRectangle(new SolidBrush(Color.RosyBrown), 200, 150, 240, 240);
            g.DrawRectangle(new Pen(Color.Black, 5f), 230, 260, 70, 70);
            g.FillRectangle(new SolidBrush(Color.LightBlue), 230, 260, 70, 70);
            g.DrawRectangle(new Pen(Color.Black, 3f), 330, 260,70, 130);
            g.FillRectangle(new SolidBrush(Color.SaddleBrown), 330, 260, 70, 130);
            g.DrawEllipse(new Pen(Color.Orange, 3f), 600, 50, 100, 100);
            g.FillEllipse(new SolidBrush(Color.Yellow), 600, 50, 100, 100);
        }
    }
}
