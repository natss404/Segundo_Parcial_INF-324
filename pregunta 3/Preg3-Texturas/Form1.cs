using ExamenForm.Dato;
using ExamenForm.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenForm
{
    public partial class Form1 : Form
    {
        int index = 0;
        DataTable tabla;
        Bitmap Imagen;
        TextureData dato = new TextureData();
        public Form1()
        {
            InitializeComponent();
           
            Guardar("Negro",3, 18, 2, 17, 2, 17);
            Guardar("Gris",79, 136, 77, 136, 75, 133);
            Guardar("Rojo",126, 159, 0, 0, 22, 33);
            Iniciar();
            Consultar();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            CargarImagen();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (Imagen == null)
            {
                CargarImagen();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int c1 = Int32.Parse((string)dataGridView1.Rows[index].Cells[1].Value);
            int c2 = Int32.Parse((string)dataGridView1.Rows[index].Cells[2].Value);
            int c3 = Int32.Parse((string)dataGridView1.Rows[index].Cells[3].Value);
            int c4 = Int32.Parse((string)dataGridView1.Rows[index].Cells[4].Value);
            int c5 = Int32.Parse((string)dataGridView1.Rows[index].Cells[5].Value);
            int c6 = Int32.Parse((string)dataGridView1.Rows[index].Cells[6].Value);
            if (Imagen == null)
            {
                CargarImagen();
            }
            else
            {
                Pintar(c1, c2, c3, c4, c5, c6);
            }
        }
        private void CargarImagen()
        {
            openFileDialog1.Filter = "Imagenes PNG|*.png";
            openFileDialog1.ShowDialog();
            if (openFileDialog1 != null)
            {
                Imagen = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = Imagen;
            }
        }
        private void Iniciar()
        {
            tabla = new DataTable();
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("R1");
            tabla.Columns.Add("R2");
            tabla.Columns.Add("G1");
            tabla.Columns.Add("G2");
            tabla.Columns.Add("B1");
            tabla.Columns.Add("B2");
            dataGridView1.DataSource = tabla; 
        }
        private void Guardar(string name, int r1,int r2, int g1, int g2, int b1, int b2)
        {
            TextureModel modelo = new TextureModel()
            {
                name = name,
                R1 = r1,
                R2 = r2,
                G1 = g1,
                G2 = g2,
                B1 = b1,
                B2 = b2,
            };
            dato.Guardar(modelo);
        }
        private void Consultar()
        {
            foreach (var item in dato.Consultar())
            {
                DataRow fila = tabla.NewRow();
                fila["Nombre"] = item.name;
                fila["R1"] = item.R1;
                fila["R2"] = item.R2;
                fila["G1"] = item.G1;
                fila["G2"] = item.G2;
                fila["B1"] = item.B1;
                fila["B2"] = item.B2;
                tabla.Rows.Add(fila);
            }
        }
        private void Limpiar()
        {
            if (Imagen == null)
            {
                CargarImagen();
            }
            else
            {
                pictureBox1.Image = Imagen;
            }
        }
        private void Pintar(int r1, int r2, int g1, int g2, int b1, int b2)
        {
            Bitmap b = new Bitmap(pictureBox1.Image);
            Bitmap bc = new Bitmap(b.Width, b.Height);
            decimal num = 0;
            Color c = new Color();
            for (int i = 0; i < b.Width; i++)
            {
                for (int j = 0; j < b.Height; j++)
                {
                    c = b.GetPixel(i, j);
                    if ((c.R >= r1 - num && c.R <= r2 + num) && (c.G >= g1 - num && c.G <= g2 + num) && (c.B - num >= b1 && c.B <= b2 + num))
                    {
                        for (int k = i; k < i + 10; k++)
                        {
                            for (int l = j; l < j + 10; l++)
                            {
                                if (k < b.Width && l < b.Height)
                                    if (k > 0 && l > 0)
                                    {
                                        bc.SetPixel(k, l, Color.FromArgb(167, 87, 1));
                                    }
                            }
                        }
                        bc.SetPixel(i, j, Color.FromArgb(167, 87, 1));
                    }
                    else
                    {
                        bc.SetPixel(i, j, Color.FromArgb(c.R, c.G, c.B));
                    }
                }
            }
            pictureBox1.Image = bc;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int n = e.RowIndex;
            if(n != -1)
            {
                if (dataGridView1.Rows.Count - 1 > n)
                {
                    label1.Text = (string)dataGridView1.Rows[n].Cells[0].Value;
                    index = n;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Imagen == null)
            {
                CargarImagen();
            }
            else
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    int c1 = Int32.Parse((string)dataGridView1.Rows[i].Cells[1].Value);
                    int c2 = Int32.Parse((string)dataGridView1.Rows[i].Cells[2].Value);
                    int c3 = Int32.Parse((string)dataGridView1.Rows[i].Cells[3].Value);
                    int c4 = Int32.Parse((string)dataGridView1.Rows[i].Cells[4].Value);
                    int c5 = Int32.Parse((string)dataGridView1.Rows[i].Cells[5].Value);
                    int c6 = Int32.Parse((string)dataGridView1.Rows[i].Cells[6].Value);
                    Pintar(c1, c2, c3, c4, c5, c6);
                }
                //Pintar(c1, c2, c3, c4, c5, c6);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
