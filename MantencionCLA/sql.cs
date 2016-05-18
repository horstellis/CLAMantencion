using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.ComponentModel;
using System.Drawing;

namespace MantencionCLA
{
    class sql
    {
        String conexion = "Data Source=localhost;Initial Catalog=mantencion;Persist Security Info=True;User ID=sa;Password=qwe123ASD;MultipleActiveResultSets=True";
        SqlConnection con;

        public sql()
        {
            con = new SqlConnection(conexion);
        }

        public void conectar()
        {
            try
            {
                con.Open();
            }
            catch { }
        }

        public void desconectar()
        {
            try
            {
                con.Close();
            }
            catch(Exception f) { MessageBox.Show(f.Message, "Clase SQL"); }
        }

        public SqlDataReader consulta(String sentencia)
        {
            try
            {
                conectar();
                SqlCommand comando = new SqlCommand(sentencia, con);
                return comando.ExecuteReader();
            }
            catch { return null; }
        }

        public int ejecutar(String sentencia){
            try{
                conectar();
                SqlCommand comando = new SqlCommand(sentencia, con);
                return comando.ExecuteNonQuery();
            }
            catch { return -1; }
        }

        public Boolean verificar(string sentencia)
        {
            try
            {
                return consulta(sentencia).Read();
            }
            catch { return false;  }
        }

        public void llenar_grid(DataGridView dg, String sentencia)
        {
            try
            {
                con.Close();
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(sentencia, con);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                dg.DataSource = ds.Tables[0];
                con.Close();
            }
            catch { }
        }
    }
}
