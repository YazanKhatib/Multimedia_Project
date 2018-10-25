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
    public partial class Form3 : Form
    {
        public static int passedvalue, passedvalue2; 
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            passedvalue = Convert.ToInt32(textBox1.Text);
            passedvalue2 = Convert.ToInt32(textBox2.Text);
            Close();
        }
    }
}
