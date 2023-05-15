using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeEntradaSena2._0
{
    public class ClsConexion
    {
        

        public SqlConnection Conectar()
        {
            //Se usa Sql Conecction para hacer la conexiòn a la BD
            //Por paràmetro entra la cadena de conexiòn
            SqlConnection conexion = new SqlConnection("Data Source = (Local)\\Sqlexpress; Initial Catalog = SistemadeAsistencia; Integrated Security = True");
            //SqlConnection conexion = new SqlConnection("Data Source = (Local)\\SQLEXPRESS; Initial Catalog = Sistema de Asistencia; Integrated Security = True");
            conexion.Open();
            return conexion;
        }




    }
}