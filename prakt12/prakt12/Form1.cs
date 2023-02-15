using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prakt12
{
    public partial class Form1 : Form
    {
        class Figure
        {
            public double Rectangl(double x, double y)
            {
                double per = 2 * x + 2 * y;
                return per;

            }
            public double Rectangl2(double x, double y)
            {
                double pl = x * y;
                return pl;

            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void кругToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            double x, y;
            if(comboBox1.Text=="прямоугольник")
            {
            }
        }
    }
}
