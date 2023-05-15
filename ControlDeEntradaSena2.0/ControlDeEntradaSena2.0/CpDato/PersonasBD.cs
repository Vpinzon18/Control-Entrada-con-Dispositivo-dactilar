using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeEntradaSena2._0.CpDato
{
    public class PersonasBD
    {
        public void ModificarPersonaBD(int id, byte[] huellaPersona, string cedula, string nombre, string apellido, string correo, string celular, string funcionario_Persona, string ficha_Persona, string direccion_Imagen, byte[] photo, int no_dedo)
        {
            ClsConexion conexion = new ClsConexion();

            string consultaModificar = "UPDATE PERSONAS SET Huella_Persona=@Huella_Persona,Cedula_Persona=@Cedula_Persona,Nombre_Persona=@Nombre_Persona,Apellido_Persona=@Apellido_Persona,Correo_Persona=@Correo_Persona,Celular_Persona=@Celular_Persona,Funcionario_Persona=@Funcionario_Persona,Ficha_Persona=@Ficha_Persona,Direccion_Imagen=@Direccion_Imagen,Photo_Persona=@Photo_Persona,No_Dedo=@No_dedo WHERE Id_Persona=@Id_Persona";
            SqlCommand comandoModificar = new SqlCommand(consultaModificar, conexion.Conectar());
            comandoModificar.Parameters.AddWithValue("@Huella_Persona", huellaPersona);
            comandoModificar.Parameters.AddWithValue("@Cedula_Persona", cedula);
            comandoModificar.Parameters.AddWithValue("@Nombre_Persona", nombre);
            comandoModificar.Parameters.AddWithValue("@Apellido_Persona", apellido);
            comandoModificar.Parameters.AddWithValue("@Correo_Persona", correo);
            comandoModificar.Parameters.AddWithValue("@Celular_Persona", celular);
            comandoModificar.Parameters.AddWithValue("@Funcionario_Persona", funcionario_Persona);
            comandoModificar.Parameters.AddWithValue("@Ficha_Persona", ficha_Persona);
            comandoModificar.Parameters.AddWithValue("Direccion_Imagen", direccion_Imagen);
            comandoModificar.Parameters.AddWithValue("Photo_Persona", photo);
            comandoModificar.Parameters.AddWithValue("@No_Dedo", no_dedo);
            comandoModificar.Parameters.AddWithValue("Id_Persona", id);
            comandoModificar.ExecuteNonQuery();
        }
        public DataTable ValidarCodigoBD(int no_dedo)
        {
            ClsConexion conexion = new ClsConexion();
            string consultaValidar = "SELECT Id_Persona FROM PERSONAS WHERE No_Dedo=@No_Dedo";
            SqlCommand sqlValidar = new SqlCommand(consultaValidar, conexion.Conectar());
            sqlValidar.Parameters.AddWithValue("@No_Dedo", no_dedo);


            SqlDataAdapter sqlData = new SqlDataAdapter(sqlValidar);
            DataTable dataTable = new DataTable();
            sqlData.Fill(dataTable);
            return dataTable;
        }
        public DataTable LlenarDatosBD()
        {
            ClsConexion conexion = new ClsConexion();
            string consulta = "SELECT * FROM PERSONAS";
            SqlCommand sql = new SqlCommand(consulta, conexion.Conectar());

            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            DataTable dataTable = new DataTable();
            sqlData.Fill(dataTable);
            return dataTable;
        }

        public void AgregarPersonasBD(byte[] huellaPersona, string cedula, string nombre, string apellido, string correo, string celular, string funcionario_Persona, string ficha_Persona, string direccion_Imagen, byte[] photo, int no_dedo)
        {
            ClsConexion conexion = new ClsConexion();
            string consultaInsertar = "INSERT INTO PERSONAS (Huella_Persona,Cedula_Persona,Nombre_Persona,Apellido_Persona,Correo_Persona,Celular_Persona,Funcionario_Persona,Ficha_Persona,Direccion_Imagen,Photo_Persona,No_Dedo) VALUES (@Huella_Persona,@Cedula_Persona,@Nombre_Persona,@Apellido_Persona,@Correo_Persona,@Celular_Persona,@Funcionario_Persona,@Ficha_Persona,@Direccion_Imagen,@Photo_Persona,@No_Dedo)";

            SqlCommand comandoInsertarPersonas = new SqlCommand(consultaInsertar, conexion.Conectar());

            comandoInsertarPersonas.Parameters.AddWithValue("@Huella_Persona", huellaPersona);
            comandoInsertarPersonas.Parameters.AddWithValue("@Cedula_Persona", cedula);
            comandoInsertarPersonas.Parameters.AddWithValue("@Nombre_Persona", nombre);
            comandoInsertarPersonas.Parameters.AddWithValue("@Apellido_Persona", apellido);
            comandoInsertarPersonas.Parameters.AddWithValue("@Correo_Persona", correo);
            comandoInsertarPersonas.Parameters.AddWithValue("@Celular_Persona", celular);
            comandoInsertarPersonas.Parameters.AddWithValue("@Funcionario_Persona", funcionario_Persona);
            comandoInsertarPersonas.Parameters.AddWithValue("@Ficha_Persona", ficha_Persona);
            comandoInsertarPersonas.Parameters.AddWithValue("@Direccion_Imagen", direccion_Imagen);
            comandoInsertarPersonas.Parameters.AddWithValue("@Photo_Persona", photo);
            comandoInsertarPersonas.Parameters.AddWithValue("@No_Dedo", no_dedo);

            comandoInsertarPersonas.ExecuteNonQuery();
        }
        public DataTable ValidarCedulaBD(string cedula)
        {
            ClsConexion conexion = new ClsConexion();
            string consultaValidar = "SELECT Id_Persona FROM PERSONAS WHERE Cedula_Persona=@Cedula_Persona";
            SqlCommand sqlValidar = new SqlCommand(consultaValidar, conexion.Conectar());
            sqlValidar.Parameters.AddWithValue("@Cedula_Persona", cedula);


            SqlDataAdapter sqlData = new SqlDataAdapter(sqlValidar);
            DataTable dataTable = new DataTable();
            sqlData.Fill(dataTable);
            return dataTable;
        }

        public DataTable TraerPersonaCedulaBD(string cedula)
        {
            ClsConexion conexion = new ClsConexion();
            string consultaTraer = "SELECT Id_Persona,Nombre_Persona,Apellido_Persona,Funcionario_Persona,Ficha_Persona,Photo_Persona,Huella_Persona FROM PERSONAS WHERE Cedula_Persona=@Cedula_Persona";
            SqlCommand sqlTraer = new SqlCommand(consultaTraer, conexion.Conectar());
            sqlTraer.Parameters.AddWithValue("Cedula_Persona", cedula);

            SqlDataAdapter sql = new SqlDataAdapter(sqlTraer);
            DataTable data = new DataTable();
            sql.Fill(data);
            return data;
        }
        public void EntradaPersonaBD(int id)
        {
            ClsConexion conexion = new ClsConexion();
            SqlCommand command = new SqlCommand("RegistroAsistenciaHuella", conexion.Conectar());
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("Id_Persona", id);
            // Ejecutamos el procedimiento almacenado
            command.ExecuteNonQuery();
            // Obtenemos el valor de retorno del procedimiento almacenado
        }

        public DataTable TraerEstadoAsistenciaBD(int id)
        {
            //Primero instanciamos la clase de conexión
            ClsConexion conexion = new ClsConexion();

            //Luego creamos la query
            string queryAsistencia = "SELECT Estado_Persona from ASISTENCIA_HUELLA WHERE Id_Asistencia = (SELECT MAX(Id_Asistencia) FROM ASISTENCIA_HUELLA WHERE Id_Persona =@Id_Persona)";

            SqlCommand sql = new SqlCommand(queryAsistencia, conexion.Conectar());
            sql.Parameters.AddWithValue("Id_Persona", id);
            sql.ExecuteNonQuery();

            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            DataTable data = new DataTable();
            sqlData.Fill(data);
            return data;
        }
    }
}
