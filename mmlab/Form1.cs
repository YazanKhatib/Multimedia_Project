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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Color c;
            
        }

        Bitmap current, b;
        OpenFileDialog dialog;
        private void loadImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialog = new OpenFileDialog();
            dialog.Title = "Choose image file";
            dialog.Filter = "JPG files|*.jpg|JPEG files|*.jpeg";
            var res = dialog.ShowDialog();
            if (res == DialogResult.Cancel)
                return;
            b = new Bitmap(dialog.FileName);
            picBoxMain.Image = b;
            lblImgWidth.Text = b.Width.ToString();
            lblImgHeight.Text = b.Height.ToString();
            lblImgPixelFormat.Text = b.PixelFormat.ToString();
            current = b;

        }

        private void picBoxMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (current == null)
                return;
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                int x = e.X;
                int y = e.Y;
                double hr = (double)current.Height / picBoxMain.Height;
                double wr = (double)current.Width / picBoxMain.Width;
                //double r = Math.Max(hr, wr);
                if (hr > wr)
                {
                    y = (int)(y * hr);
                    x = (int)((x - picBoxMain.Width / 2) * hr + current.Width / 2);
                }
                else
                {
                    x = (int)(x * hr);
                    y = (int)((y - picBoxMain.Width / 2) * hr + current.Width / 2);
                }
                if (x >= 0 && x < current.Width && y >= 0 && y < current.Height)
                {
                    Color c = current.GetPixel(x, y);
                    colorBox.BackColor = c;
                }
            }
        }

        private void redImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (current == null)
                return;
            for (int i = 0; i < current.Width; i++)
            {
                for (int j = 0; j < current.Height; j++)
                {
                    Color c = current.GetPixel(i, j);
                    Color newC = Color.FromArgb(c.R, 0, 0);
                    current.SetPixel(i, j, newC);
                }
            }
            picBoxMain.Image = current;
        }

        private void brightenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (current == null)
                return;
            Form2 f2 = new Form2();
            f2.ShowDialog();
            string temp = Form2.passedvalue;

            Double brightnessratio = Convert.ToDouble(temp);

            for (int i = 0; i < current.Width; i++)
            {
                for (int j = 0; j < current.Height; j++)
                {
                    Color c = current.GetPixel(i, j);
                    byte r = (byte)((255 - c.R) * brightnessratio + c.R);
                    byte g = (byte)((255 - c.G) * brightnessratio + c.G);
                    byte b = (byte)((255 - c.B) * brightnessratio + c.B);
                    Color newC = Color.FromArgb(r, g, b);
                    current.SetPixel(i, j, newC);
                }
            }
            picBoxMain.Image = current;
        }

        private void picBoxMain_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void blueImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (current == null)
                return;
            for (int i = 0; i < current.Width; i++)
            {
                for (int j = 0; j < current.Height; j++)
                {
                    Color c = current.GetPixel(i, j);
                    Color newC = Color.FromArgb(0, 0, c.B);
                    current.SetPixel(i, j, newC);
                }
            }
            picBoxMain.Image = current;
        }

        private void restoreOriginalImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (b == null)
                return;
            b = new Bitmap(dialog.FileName);
            current = b;
            picBoxMain.Image = current; 
        }

        private void grayImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (current == null)
                return;
            for (int i = 0; i < current.Width; i++)
            {
                for (int j = 0; j < current.Height; j++)
                {
                    Color c = current.GetPixel(i, j);
                    double value = (c.R + c.G + c.B) / 3; 
                    Color newC = Color.FromArgb((int)value, (int)value, (int)value);
                    current.SetPixel(i, j, newC);
                }
            }
            picBoxMain.Image = current;
        }

        private void addColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog d = new ColorDialog();
            if (d.ShowDialog() == DialogResult.Cancel)
                return;
            Color uc = d.Color;
            for (int i = 0; i < current.Width; i++)
            {
                for (int j = 0; j < current.Height; j++)
                {
                    Color c = current.GetPixel(i, j);
                    byte r = (byte)((uc.R) + c.R / 2);
                    byte g = (byte)((uc.G) + c.G / 2);
                    byte b = (byte)((uc.B) + c.B / 2);
                    Color newC = Color.FromArgb(r, g, b);
                    current.SetPixel(i, j, newC);
                }
            }
            picBoxMain.Image = current;
        }

        private void flipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void horizontalFlipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (current == null)
                return;
            current.RotateFlip(RotateFlipType.Rotate180FlipY);
            picBoxMain.Image = current;
        }

        private void verticalFlipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (current == null)
                return;
            current.RotateFlip(RotateFlipType.Rotate180FlipX);
            picBoxMain.Image = current;
        }

        private void greenImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (current == null)
                return;
            for (int i = 0; i < current.Width; i++)
            {
                for (int j = 0; j < current.Height; j++)
                {
                    Color c = current.GetPixel(i, j);
                    Color newC = Color.FromArgb(0, c.G, 0);
                    current.SetPixel(i, j, newC);
                }
            }
            picBoxMain.Image = current;
        }
    }
}
