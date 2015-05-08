using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace caminomascorto
{
    public partial class Form1 : Form
    {
        private bool[,]  x=new bool[8,8];
        private bool[,] r;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            matriz();
         }

        void cierreTransitivoWarshall(bool[,] A, bool[,] R,int n)
        {
            int i, j, k;
            R = A;
            for (k = 0; k < n; k++)
            {
                for (i = 0; i < n; i++)
                    for (j = 0; j < n; j++)
                        R[i, j] = R[i, j] || (R[i, k] && R[k, j]);
             }
            String m = "";
            for (int p = 0; p < x.GetLength(0); p++)
            {
                for (int o = 0; o < x.GetLength(1); o++)
                {
                    if (R[p, o] == false)
                        m += "0";
                    else
                        m += 1;
                }
                m += "\n";
            }
            MessageBox.Show(m);
        }// void cierreTransitivoWarshall(bool[,] A, bool[,] R,int n)

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void matriz()
        { String m = "";
            x[0, 1] = true;
            x[0, 4] = true;
            x[1, 6] = true;
            x[3, 2] = true;
            x[3, 6] = true;
       
            x[5, 0] = true;
            x[5, 1] = true;
            x[5, 2] = true;
            x[7, 6] = true;
 
            for (int i = 0; i < x.GetLength(0); i++) { 
            for (int j = 0; j < x.GetLength(1); j++)
            {
                if (x[i, j] == false)
                    m += "0";
                else
                    m += 1;
            } m += "\n"; }
            pantalla.Text=m;
        }// void matriz()

        private void algoritmoDeWarshallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cierreTransitivoWarshall(x, r, x.GetLength(0));
        }
    }
}
