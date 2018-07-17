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
    public partial class Form1 : Form
    {
        

        public Calc myCalc = new Calc(); //instantiate a new class calc.cs
        public Form1()
        {
            InitializeComponent();
            LoadCombobox();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = Properties.Resources.Title;
            pictureBox1.Image = Properties.Resources.men;
        }

        private void LoadCombobox() // Function Combobox
        {
            //pass the array across to the combobox
            cbxoperation.Items.AddRange(myCalc.LoadSymbols());
            //start at the first item
            cbxoperation.SelectedIndex = 0;
        }

        private void cbxoperation_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form2 FormTwo = new Form2();
            //FormTwo.Show();


            double result;
            //Check for numbers coming in
            if (double.TryParse(txtNum1.Text, out result))
            {
                myCalc.Num1 = result;
            }
            if (double.TryParse(txtNum2.Text, out result))
            {
                myCalc.Num2 = result;
            }
            //check selected operation
            myCalc.SelectedSymbol = cbxoperation.SelectedItem.ToString();
            //output answer
            lblAnswer.Text =  Convert.ToString(myCalc.SelectOperation());
            lbxOutput.Items.Add(myCalc.Num1 + " " + myCalc.SelectedSymbol + " " + myCalc.Num2 + " = " + lblAnswer.Text);
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
    

