using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MantencionCLA
{
    class sqlaux
    {
        public String select (String campos, String nombre_tabla){
            return "SELECT " + campos + " FROM " + nombre_tabla;
        }

        public String select(String campos, String nombre_tabla, String condicion)
        {
            return "SELECT " + campos + " FROM " + nombre_tabla + " WHERE " + condicion;
        }

    }
}