using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsTransformationApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bm = new Bitmap(Canvas.Width, Canvas.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            Canvas.Image = bm;
        }

        private Bitmap bm;
        private Graphics g;
        private bool paint = false;
        private Pen pen = new Pen(Color.DarkBlue, 1);
        private Pen pen1 = new Pen(Color.Magenta, 1);
        private int index;
        private int transform;
        private int x, y, sX, sY, cX, cY;
        private bool canDraw = true;
        private int sX1, sY1, cX1, cY1;

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            cX = e.X; 
            cY = e.Y;
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            Canvas.Refresh();

            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            sX = x - cX;
            sY = y - cY;

            if (canDraw)
            {
                if (index == 1)
                {
                    g.DrawEllipse(pen, cX, cY, sX, sY);
                    canDraw = false;
                }
                else if (index == 2)
                {
                    g.DrawRectangle(pen, cX, cY, sX, sY);
                    canDraw = false;
                }
                cX1 = cX; 
                cY1 = cY;
                sX1 = sX;
                sY1 = sY;
            }
            
        }

        private void buttonElips_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void buttonTranslation_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            form2.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
        }

        private void buttonScale_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            form3.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            cX1 += Form2.translationX;
            cY1 += Form2.translationY;
            Form2.translationX = Form2.translationY = 0;
            transformation();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            int midX = sX1 / 2;
            int midY = sY1 / 2;
            sX1 *= Form3.scaleX;
            sY1 *= Form3.scaleY;
            if (Form3.scaleX != 1)
            {
                cX1 = cX1 + midX - (sX1 / 2);
            }
            if (Form3.scaleY != 1)
            {
                cY1 = cY1 + midY - (sY1 / 2);
            }
            Form3.scaleX = Form3.scaleY = 1;
            transformation();
        }
        private void transformation()
        {
            if (index == 1)
            {
                g.DrawEllipse(pen1, cX1, cY1, sX1, sY1);
            }
            else if (index == 2)
            {
                g.DrawRectangle(pen1, cX1, cY1, sX1, sY1);
            }
        }
    }
}
