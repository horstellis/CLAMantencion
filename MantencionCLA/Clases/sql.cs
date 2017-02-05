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
        /* 
         * Clase que proporciona los metodos necesarios para conectarse a la base de datos
         * Requiere que se le indiquen los parametros de conexión el origen, la base, usuario y clave de acceso
         * que estan contenidos en la seccion conexion
         * No modificar los demas parámetros o procedimientos a menos de ser estrictamente necesario
         * Cualquier cambio incorrecto no permitira la comunicación correcta con la base de datos
         * Para utilizar los metodos de esta clase, se debe de instancear, utilizando la siguiente forma
         * sql sql = new sql();
         */

        // Parametros de conexion
        private static String origen = "localhost";
        private static String bd = "mantencion";
        private static String usuario = "sa";
        private static String clave = "qwe123ASD";

        // Variable de conexion >>> NO MODIFICAR
        private static String conexion = "Data Source=" + origen + ";Initial Catalog=" + bd + ";Persist Security Info=True;User ID=" + usuario + ";Password=" + clave + ";MultipleActiveResultSets=True";
        private SqlConnection con;

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
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error inesperado. Favor avise a un administrador e indiquele:\n" + ex.Message, "Clase SQL - Conexión");
            }
        }

        public void desconectar()
        {
            try
            {
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error inesperado. Favor avise a un administrador e indiquele:\n" + ex.Message, "Clase SQL - Desconexión");
            }
        }

        public SqlDataReader consulta(String sentencia)
        {
            try
            {
                desconectar();
                conectar();
                SqlCommand comando = new SqlCommand(sentencia, con);
                return comando.ExecuteReader();
            }
            catch
            {
                return null;
            }
        }

        public int contar(String tabla, String condicion)
        {
            try
            {
                String query = "SELECT COUNT(*) FROM " + tabla;
                if (!condicion.Equals(""))
                {
                    query += " WHERE " + condicion;
                }
                SqlDataReader r = consulta(query);
                r.Read();
                return r.GetInt32(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error inesperado. Favor avise a un administrador e indiquele:\n" + ex.Message, "Clase SQL - Contar");
                return -1;
            }
        }

        public int ejecutar(String sentencia)
        {
            /*
             * Ejecuta una consulta del tipo UPDATE o INSERT INTO en la base de datos
             * y devuelve la cantidad de filas afectadas, permitiendo evaluar el efecto
             * de la misma. Al utilizarla se debe declarar como un int, de la forma
             * int exec = sql.ejecutar(querySQL);
             */
            try
            {
                desconectar();
                conectar();
                SqlCommand comando = new SqlCommand(sentencia, con);
                return comando.ExecuteNonQuery();
            }
            catch
            {
                return -1; // en caso de error
            }
        }

        public Boolean verificar(string sentencia)
        {
            try
            {
                return consulta(sentencia).Read();
            }
            catch
            {
                return false;
            }
        }

        public Boolean llenar_grid(DataGridView dg, String sentencia)
        {
            /*
             * Permite llenar un DataGridView. Requiere de los parametros:
             * dg >>> DataGridView a llenar
             * sentencia >>> consulta del tipo SELECT
             * En caso de fallar, devuelve un false
             */
            try
            {
                desconectar();
                conectar();
                SqlDataAdapter adapt = new SqlDataAdapter(sentencia, con);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                dg.DataSource = ds.Tables[0];
                desconectar();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error inesperado. Favor avise a un administrador e indiquele:\n" + ex.Message, "Clase SQL - Llenar Grid");
                return false;
            }
        }

        public Boolean llenar_combo(ComboBox cmb, String sentencia, String tabla, String visible, String invisible)
        {
            /*
             * Permite llenar un ComboBox. Requiere de los parametros
             * cmb >>> ComboBox a llenar
             * sentencia >>> consulta del tipo SELECT
             * tabla >>> tabla donde se ejecuta el SELECT
             * visible >>> campo a mostrar en el combo
             * invisible >>> campo que contiene el indice de la tabla
             */
            try
            {
                desconectar();
                conectar();
                SqlDataAdapter adapt = new SqlDataAdapter(sentencia, con);
                DataSet ds = new DataSet();
                adapt.Fill(ds, tabla);
                cmb.DataSource = ds.Tables[0].DefaultView;
                cmb.DisplayMember = visible;
                cmb.ValueMember = invisible;
                desconectar();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error inesperado. Favor avise a un administrador e indiquele:\n" + ex.Message, "Clase SQL - Llenar Combo");
                return false;
            }
        }

        public Boolean llenar_lista(CheckedListBox lst, String sentencia, String tabla, String visible, String invisible)
        {
            try
            {
                desconectar();
                conectar();
                SqlDataAdapter adapt = new SqlDataAdapter(sentencia, con);
                DataSet ds = new DataSet();
                adapt.Fill(ds, tabla);
                lst.DataSource = ds.Tables[0].DefaultView;
                lst.DisplayMember = visible;
                lst.ValueMember = visible;
                desconectar();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error inesperado. Favor avise a un administrador e indiquele:\n" + ex.Message, "Clase SQL - Llenar Lista");
                return false;
            }
        }

        public Boolean llenar_vista(ListView lsv, String sentencia, String tabla, String visible, String invisible)
        {
            try
            {
                desconectar();
                conectar();
                SqlDataAdapter adapt = new SqlDataAdapter(sentencia, con);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                adapt.Fill(ds);
                dt = ds.Tables[0];
                lsv.Items.Clear();
                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                {
                    DataRow fila = ds.Tables[0].Rows[i];
                    ListViewItem elementos = new ListViewItem(fila[1].ToString());
                    elementos.SubItems.Add(fila[2].ToString());
                    lsv.Items.Add(elementos);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error inesperado. Favor avise a un administrador e indiquele:\n" + ex.Message, "Clase SQL - Llenar Lista");
                return false;
            }
        }
    }
}
