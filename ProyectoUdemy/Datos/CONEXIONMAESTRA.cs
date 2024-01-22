using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoUdemy.Datos
{
    public class CONEXIONMAESTRA
    {
        public static string conexion = @"Data source=DESKTOP-D6JQ9NG\SQLEXPRESS; Initial Catalog=SKYSS; Integrated Security=true";
        public static SqlConnection conectar = new SqlConnection(conexion);
        public static void abrir()
        {
            if (conectar.State == System.Data.ConnectionState.Closed) { 
            conectar.Open();
            }
        }
        public static void cerrar()
        {
            if (conectar.State == System.Data.ConnectionState.Open)
            {
                conectar.Close();
            }
        }
    }
}
