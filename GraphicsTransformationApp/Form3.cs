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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public static int scaleX;
        public static int scaleY;
        private void enterScale_Click(object sender, EventArgs e)
        {
            scaleX = Convert.ToInt32(inptScaleX.Text);
            scaleY = Convert.ToInt32(inptScaleY.Text);
            this.Close();
        }
    }
}
