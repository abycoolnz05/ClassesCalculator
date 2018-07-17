using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassesCalculator
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.apple_icon;
            pictureBox2.Image = Properties.Resources.electronics;
            pictureBox3.Image = Properties.Resources.samsung_logo;
            pictureBox4.Image = Properties.Resources.men;

        }

        private void lblAnswer_Click(object sender, EventArgs e)
        {

        }
    }
}
