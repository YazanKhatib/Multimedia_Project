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
    public partial class Form2 : Form
    {
        public static string passedvalue; 
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            passedvalue = textBox1.Text;
            Close(); 
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if ( ch == 46 && textBox1.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return; 
            }
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true; 
            }
        }
    }
}
