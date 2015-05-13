using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace proyectoGIS
{

    public partial class Form1 : Form
    {
        bool add;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            add = true;
            mensaje.Text = "De click en la posicion del nuevo punto";
            mensaje.ForeColor = Color.Red;
            mensaje.BackColor = Color.Transparent;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (add == true)
            {
                add = false;
               
                punto nuevo = new punto(Cursor.Position.X, Cursor.Position.Y);
                nuevo.Show();
                mensaje.Text = "";

            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            conexion con = new conexion();
            int[,] cor = con.obtenerPuntos();
           
            Graphics grafica = this.pictureBox1.CreateGraphics();

            SolidBrush brush = new SolidBrush(Color.Black);

            for(int i=0;i<cor.GetLength(0);i++)
            grafica.FillEllipse(brush, cor[i,0], cor[i,1], 20, 20);
           


            
        }
    }
}
