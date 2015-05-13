using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoGIS
{
    public partial class punto : Form
    {

        bool existe;
        int cx, cy;
        string n1;
        conexion con;
        public punto(int x,int y)
        {
            InitializeComponent();
            cx = x;cy = y;
            con = new conexion();
 
        }

        private void punto_Load(object sender, EventArgs e)
        {
            cordenadas();
            if (con.existeCordenada(cx, cy))
            {
                button1.Enabled = false;
                button2.Enabled = true;
                button3.Enabled = true;
                n1 = con.getNombre;
                nombre.Text = n1;
                x.Text = con.getX.ToString();
                y.Text = con.getY.ToString();
            }
            else
            {
                button1.Enabled = true;
                button2.Enabled = false;
                button3.Enabled = false;
            }
            
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (con.existeCordenada(Convert.ToInt32(x.Text), Convert.ToInt32(y.Text)))
            { MessageBox.Show("Ya esta definido estas cordenadas"); }
            if (con.existeNombre(nombre.Text)==true)
                MessageBox.Show("Ya esta definido este lugar");
            else
            {
                con.insertar(nombre.Text, Convert.ToInt32(x.Text), Convert.ToInt32(y.Text));
                this.Close();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.baja(nombre.Text);
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.actualizar(n1, nombre.Text, Convert.ToInt32(x.Text), Convert.ToInt32(y.Text));
        }

        void cordenadas()
        {
            x.Text = cx.ToString();
            y.Text =cy.ToString();
        }
   
    }
}
