using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mmlab
{
    public partial class Form5 : Form
    {
        public static double passedvalue;
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            passedvalue = Convert.ToDouble(textBox1.Text);
            Close();
        }
    }
}
