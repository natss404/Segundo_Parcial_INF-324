using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace texturas
{
    public partial class Form1 : Form
    {
        Bitmap bmp;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Carga una imagen y la muestra desde un PictureBox
            openFileDialog1.Filter = "Archivos JPG |*.jpg|Archivos BMP|*.bmp|Todos los archivos|*.*";
            openFileDialog1.ShowDialog();
            bmp = new Bitmap(openFileDialog1.FileName);
            pictureBox1.Image = bmp;
        
        }

        // if ((blue >= 30 && blue <= 72)&&(green>=33 && green<=108) &&(red>=33 && red<=166))
        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap bmp1 = new Bitmap(pictureBox1.Image);
            Bitmap bmp3 = new Bitmap(bmp.Width, bmp.Height);
            Color c = new Color();
            int rm, gm, bm;
            for (int i = 0; i < bmp.Width - 10; i = i + 10)
            {
                for (int j = 0; j < bmp.Height - 10; j = j + 10)
                {
                    rm = 0; gm = 0; bm = 0;
                    for (int im = i; im < i + 10; im++)
                    {
                        for (int jm = j; jm < j + 10; jm++)
                        {
                            c = bmp1.GetPixel(i, j);
                            rm = rm + c.R;
                            gm = gm + c.G;
                            bm = bm + c.B;
                        }
                    }
                    rm = rm / 100;
                    gm = gm / 100;
                    bm = bm / 100;
                    if ((rm >= 33 && rm <= 166) && (gm >= 33 && gm <= 108) && (bm >= 30 && bm <=72))
                    {
                        for (int im = i; im < i + 10; im++)
                        {
                            for (int jm = j; jm < j + 10; jm++)
                            {
                                bmp3.SetPixel(im, jm, Color.FromArgb(052, 064, 186));
                            }
                        }
                    }
                    else
                    {
                        for (int im = i; im < i + 10; im++)
                        {
                            for (int jm = j; jm < j + 10; jm++)
                            {
                                c = bmp1.GetPixel(im, jm);
                                bmp3.SetPixel(im, jm, Color.FromArgb(c.R, c.G, c.B));
                            }
                        }
                    }
                    pictureBox1.Image = bmp3;
                }
            }             
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            Bitmap bmp1 = new Bitmap(pictureBox1.Image);
            Bitmap bmp3 = new Bitmap(bmp.Width, bmp.Height);
            Color c = new Color();
            int rm, gm, bm;
            for (int i = 0; i < bmp.Width - 10; i = i + 10)
            {
                for (int j = 0; j < bmp.Height - 10; j = j + 10)
                {
                    rm = 0; gm = 0; bm = 0;
                    for (int im = i; im < i + 10; im++)
                    {
                        for (int jm = j; jm < j + 10; jm++)
                        {
                            c = bmp1.GetPixel(i, j);
                            rm = rm + c.R;
                            gm = gm + c.G;
                            bm = bm + c.B;
                        }
                    }
                    rm = rm / 100;
                    gm = gm / 100;
                    bm = bm / 100;
                    if ((rm >= 2 && rm <= 73) && (gm >= 26 && gm <= 136) && (bm >= 36 && bm <=143))
                    {
                        for (int im = i; im < i + 10; im++)
                        {
                            for (int jm = j; jm < j + 10; jm++)
                            {
                                bmp3.SetPixel(im, jm, Color.FromArgb(143, 052, 186));
                            }
                        }
                    }
                    else
                    {
                        for (int im = i; im < i + 10; im++)
                        {
                            for (int jm = j; jm < j + 10; jm++)
                            {
                                c = bmp1.GetPixel(im, jm);
                                bmp3.SetPixel(im, jm, Color.FromArgb(c.R, c.G, c.B));
                            }
                        }
                    }
                    pictureBox1.Image = bmp3;
                }
            }       
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bitmap bmp1 = new Bitmap(pictureBox1.Image);
            Bitmap bmp3 = new Bitmap(bmp.Width, bmp.Height);
            Color c = new Color();
            int rm, gm, bm;
            for (int i = 0; i < bmp.Width - 10; i = i + 10)
            {
                for (int j = 0; j < bmp.Height - 10; j = j + 10)
                {
                    rm = 0; gm = 0; bm = 0;
                    for (int im = i; im < i + 10; im++)
                    {
                        for (int jm = j; jm < j + 10; jm++)
                        {
                            c = bmp1.GetPixel(i, j);
                            rm = rm + c.R;
                            gm = gm + c.G;
                            bm = bm + c.B;
                        }
                    }
                    rm = rm / 100;
                    gm = gm / 100;
                    bm = bm / 100;
                    if ((rm >= 55 && rm <= 84) && (gm >= 90 && gm <= 205) && (bm >= 126 && bm <= 276))
                    {
                        for (int im = i; im < i + 10; im++)
                        {
                            for (int jm = j; jm < j + 10; jm++)
                            {
                                bmp3.SetPixel(im, jm, Color.FromArgb(041, 142, 030));
                            }
                        }
                    }
                    else
                    {
                        for (int im = i; im < i + 10; im++)
                        {
                            for (int jm = j; jm < j + 10; jm++)
                            {
                                c = bmp1.GetPixel(im, jm);
                                bmp3.SetPixel(im, jm, Color.FromArgb(c.R, c.G, c.B));
                            }
                        }
                    }
                    pictureBox1.Image = bmp3;
                }
            }      
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
