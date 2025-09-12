using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FixedDebugThree4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            int birth;
            int year;
            birth = Convert.ToInt32(textBox1.Text);
            year = Convert.ToInt32(textBox2.Text);
            age = year + birth
            outputLabel.Text = String.Format("On your birthday this year, \nyou were or will be " +
                "{0} years old", age);
        }
    }
}
