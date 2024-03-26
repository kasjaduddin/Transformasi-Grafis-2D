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

        Bitmap bm;
        Graphics g;
        bool paint = false;
        Pen pen = new Pen(Color.DarkBlue, 1);
        int index;
        int x, y, sX, sY, cX, cY;
        bool canDraw = true;
        int sX1, sY1, cX1, cY1;

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
    }
}
