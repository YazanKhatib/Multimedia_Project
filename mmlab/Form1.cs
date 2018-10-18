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
        OpenFileDialog dialog, dialog2; 
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

            for (int i = 0; i < current.Width; i++)
            {
                for (int j = 0; j < current.Height; j++)
                {
                    Color c = current.GetPixel(i, j);

                    List<double> values = FromRGB(c.R, c.G, c.B);
                    values[1] = 0; 
                    Color cc = ToRGB(values[0], values[1], values[2]);
                    current.SetPixel(i, j, cc); 

                }
            }
            picBoxMain.Image = current; 
                    /*
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
                    */
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
            for (int i = 0; i < current.Height; i++)
            {
                for (int j = 0; j < current.Width/2; j++)
                {
                    if (j == 0) continue;
                    Color c = current.GetPixel(j,i);
                    Color cc = current.GetPixel(current.Width - j,i); 
                    current.SetPixel(current.Width - j, i, c);
                    current.SetPixel(j, i, cc);
                }
            }

            picBoxMain.Image = current;

            
            /*
            if (current == null)
                return;
            current.RotateFlip(RotateFlipType.Rotate180FlipY);
            picBoxMain.Image = current;
            
            */

        }

        private void verticalFlipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (current == null)
                return;
            for (int i = 0; i < current.Width; i++)
            {
                for (int j = 0; j < current.Height / 2; j++)
                {
                    if (j == 0) continue;
                    Color c = current.GetPixel(i, j);
                    Color cc = current.GetPixel(i, current.Height - j);
                    current.SetPixel(i, current.Height - j, c);
                    current.SetPixel(i, j, cc);
                }
            }

            picBoxMain.Image = current;
            /*
            if (current == null)
                return;
            current.RotateFlip(RotateFlipType.Rotate180FlipX);
            picBoxMain.Image = current;
            */
        }

        private void loadImageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dialog2 = new OpenFileDialog();
            dialog2.Title = "Choose image file";
            dialog2.Filter = "JPG files|*.jpg|JPEG files|*.jpeg";
            var res = dialog2.ShowDialog();
            if (res == DialogResult.Cancel)
                return;

            Bitmap temp; 
            temp = new Bitmap(dialog2.FileName);
            temp = resizeImage(temp, current.Width, current.Height); 
            for (int i = 0; i < current.Width; i++)
            {
                for (int j = 0; j < current.Height; j++)
                {
                   
                    Color c1 = current.GetPixel(i, j);
                    Color c2 = temp.GetPixel(i, j); 
                    byte r = (byte)((c1.R) + c2.R / 2);
                    byte g = (byte)((c1.G) + c2.G / 2);
                    byte b = (byte)((c1.B) + c2.B / 2);
                    Color newC = Color.FromArgb(r, g, b);
                    current.SetPixel(i, j, newC);
                }
            }
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

        Bitmap resizeImage(Bitmap input, int w, int h)
        {
            return new Bitmap(input, w, h);
        }

        public static List<double> FromRGB(Byte R, Byte G, Byte B)
        {
            float _R = (R / 255f);
            float _G = (G / 255f);
            float _B = (B / 255f);

            float _Min = Math.Min(Math.Min(_R, _G), _B);
            float _Max = Math.Max(Math.Max(_R, _G), _B);
            float _Delta = _Max - _Min;

            float H = 0;
            float S = 0;
            float L = (float)((_Max + _Min) / 2.0f);

            if (_Delta != 0)
            {
                if (L < 0.5f)
                {
                    S = (float)(_Delta / (_Max + _Min));
                }
                else
                {
                    S = (float)(_Delta / (2.0f - _Max - _Min));
                }


                if (_R == _Max)
                {
                    H = (_G - _B) / _Delta;
                }
                else if (_G == _Max)
                {
                    H = 2f + (_B - _R) / _Delta;
                }
                else if (_B == _Max)
                {
                    H = 4f + (_R - _G) / _Delta;
                }
            }

            List<double> l = new List<double>
            {
                H,
                S,
                L
            };
            return l; 
        }

        private void mergeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public Color ToRGB(double Hue, double Saturation, double Luminosity)
        {
            byte r, g, b;
            if (Saturation == 0)
            {
                r = (byte)Math.Round(Luminosity * 255d);
                g = (byte)Math.Round(Luminosity * 255d);
                b = (byte)Math.Round(Luminosity * 255d);
            }
            else
            {
                double t1, t2;
                double th = Hue / 6.0d;

                if (Luminosity < 0.5d)
                {
                    t2 = Luminosity * (1d + Saturation);
                }
                else
                {
                    t2 = (Luminosity + Saturation) - (Luminosity * Saturation);
                }
                t1 = 2d * Luminosity - t2;

                double tr, tg, tb;
                tr = th + (1.0d / 3.0d);
                tg = th;
                tb = th - (1.0d / 3.0d);

                tr = ColorCalc(tr, t1, t2);
                tg = ColorCalc(tg, t1, t2);
                tb = ColorCalc(tb, t1, t2);
                r = (byte)Math.Round(tr * 255d);
                g = (byte)Math.Round(tg * 255d);
                b = (byte)Math.Round(tb * 255d);
            }
            return Color.FromArgb(r, g, b);
        }

        private static double ColorCalc(double c, double t1, double t2)
        {

            if (c < 0) c += 1d;
            if (c > 1) c -= 1d;
            if (6.0d * c < 1.0d) return t1 + (t2 - t1) * 6.0d * c;
            if (2.0d * c < 1.0d) return t2;
            if (3.0d * c < 2.0d) return t1 + (t2 - t1) * (2.0d / 3.0d - c) * 6.0d;
            return t1;
        }

    }
}
