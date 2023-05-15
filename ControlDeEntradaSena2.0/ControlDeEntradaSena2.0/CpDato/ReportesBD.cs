using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeEntradaSena2._0.CpDato
{
    public class ReportesBD
    {
        public DataTable LlenarDatosaBD()
        {
            ClsConexion conexion = new ClsConexion();
            string consulta = "SELECT * FROM PERSONAS,ASISTENCIA_HUELLA";
            SqlCommand sql = new SqlCommand(consulta, conexion.Conectar());

            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            DataTable dataTable = new DataTable();
            sqlData.Fill(dataTable);
            return dataTable;

        }
    }
}
