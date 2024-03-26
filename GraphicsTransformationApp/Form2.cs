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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public static int translationX;
        public static int translationY;

        private void enterTranslation_Click(object sender, EventArgs e)
        {
            translationX = Convert.ToInt32(inptTranslationX.Text);
            translationY = Convert.ToInt32(inptTranslationY.Text);
            this.Close();
        }

        
    }
}
