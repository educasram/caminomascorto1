using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;


namespace proyectoGIS
{
    class conexion
    {
        string cadena = @"Data Source=.\SQLEXPRESS;Initial Catalog=GIS;Integrated Security=True";
        private  SqlConnection con = new SqlConnection();
        private string nombre;
        private int x, y;
        public conexion()
        {
            con.ConnectionString = cadena; 
        }


        public bool existeCordenada(int x, int y)
        {
            SqlCommand cx = new SqlCommand("select nombre,x,y from punto where x=" + x , con);
            int corx=0, cory=0;
            try
            {
                SqlDataReader reader;
                con.Open();
                reader = cx.ExecuteReader();
                reader.Read();
                corx = Convert.ToInt32(reader.GetValue(1));
                cory = Convert.ToInt32(reader.GetValue(2));
                nombre = reader.GetValue(0).ToString();

                con.Close();
            }
            catch { con.Close(); }
            if (corx == x & cory == y)
            { x = corx;y = cory; return true; }
            else
                return false;
        }
        public bool existeNombre(string n)
        {
         
            SqlCommand cx = new SqlCommand("select nombre from punto where nombre='" + n + "'", con);
            string nom="";
            try
            {
                con.Open();
                SqlDataReader reader = cx.ExecuteReader();
                reader.Read();
                nom = reader.GetValue(0).ToString();
                con.Close();
            }
            catch (Exception)
            {
                con.Close();
            }
            if (nom == n)
                return true;
            else
                return false;
        }
        public void insertar(String n,int x,int y)
        {
            con.Open();
            SqlCommand cx = new SqlCommand("INSERT INTO punto VALUES ('"+n+"',"+x+","+y+")", con);
            cx.ExecuteNonQuery();
            con.Close();
        }
        public void baja(String n)
        {
            con.Open();
            SqlCommand cx = new SqlCommand("DELETE FROM punto where clave="+obtenerClave(n), con);
            cx.ExecuteNonQuery();
            con.Close();
        }
        public void actualizar(string  c,String n,int x,int y)
        {
            con.Open();
            SqlCommand cx = new SqlCommand("update punto Set nombre='" + n + "',x="+x+",y="+y+"where clave="+obtenerClave(c), con);
            cx.ExecuteNonQuery();
            con.Close();
        }
        private int obtenerClave(string n)
        {
            SqlCommand cx = new SqlCommand("select clave from punto where nobre='" + n+"'", con);
            int corx = 0;
            try
            {
                con.Open();
                SqlDataReader reader = cx.ExecuteReader();
                reader.Read();
                corx = Convert.ToInt32(reader.GetValue(0));
                con.Close();
                
            }
            catch (Exception)
            {
                con.Close();

            }
            return corx;

        }//private void obtenerClave(string n)

        public String getNombre { get { return nombre; } }
        public int getX { get { return x; } }
        public int getY { get { return y; } }
        public int[,] obtenerPuntos()
        {

            SqlCommand cx = new SqlCommand("select COUNT(x) from punto " , con);
            int corx = 0;
          
      
                SqlDataReader reader;
                con.Open();
                reader = cx.ExecuteReader();
                reader.Read();
                corx = Convert.ToInt32(reader.GetValue(0));
            int[,] pos = new int[corx, 2];
            con.Close();
   
            SqlCommand cx1 = new SqlCommand("select x,y from punto ", con);
            SqlDataReader reader1;
            con.Open();

            reader1 = cx1.ExecuteReader();
            int t = 0;
           while (reader1.Read())
            {
                pos[t, 0] = Convert.ToInt32( reader1.GetInt32(0));
                pos[t, 1] = Convert.ToInt32(reader1.GetInt32(1));
                t++;
            }
            con.Close();
            return pos;

            }
    }
}
