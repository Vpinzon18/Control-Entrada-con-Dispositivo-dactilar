using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using ControlDeEntradaSena2._0.CpValidation;

namespace ControlDeEntradaSena2._0.CpDato
{

    public class UsuarioBD
    {
        public static DataTable temporal = new DataTable();
        public static void BuscarRegistros(string Cedula)
        {
            ClsConexion conexion = new ClsConexion();
            string comando = "SELECT Cedula_Usuario FROM USUARIOS WHERE Cedula_Usuario=@Cedula_Usuario ";
            SqlCommand sql = new SqlCommand(comando, conexion.Conectar());

            sql.Parameters.AddWithValue("@Cedula_Usuario", Cedula);
            SqlDataAdapter swq = new SqlDataAdapter(sql);
            DataTable dt = new DataTable();
            swq.Fill(dt);
        }


        public DataTable LoginBD(string Cedula, string Password)
        {
            ClsConexion conexion = new ClsConexion();
            string comando = "SELECT Nombre_Usuario, Estado_Usuario,Photo_Usuario FROM USUARIOS WHERE Cedula_Usuario=@Cedula_Usuario AND Password_Usuario=@Password_Usuario";
            SqlCommand sql = new SqlCommand(comando, conexion.Conectar());

            sql.Parameters.AddWithValue("@Cedula_Usuario", Cedula);
            sql.Parameters.AddWithValue("@Password_Usuario", Password);

            SqlDataAdapter sda = new SqlDataAdapter(sql);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }
        
        public DataTable ValidarCedulaBD(string Cedula)
        {
            ClsConexion conexion = new ClsConexion();
            string consultaval = "SELECT Id_Usuario FROM USUARIOS WHERE Cedula_Usuario=@Cedula_Usuario";
            SqlCommand sqlvalidar = new SqlCommand(consultaval, conexion.Conectar());
            sqlvalidar.Parameters.AddWithValue("@Cedula_Usuario", Cedula);

            SqlDataAdapter sqlData = new SqlDataAdapter(sqlvalidar);
            DataTable dt = new DataTable();
            sqlData.Fill(dt);
            return dt;
        }
        public static void LeerReggistrosUsuarios(Usuarios s)
        {
            //Recorrer tabla
            for (int i = 0; i < UsuarioBD.temporal.Rows.Count; i++)
            {
                s.correo_UsuarioTextBox.Text = UsuarioBD.temporal.Rows[i]["IdUsuario"].ToString();
                s.correo_UsuarioTextBox.Text = UsuarioBD.temporal.Rows[i]["Cedula"].ToString();
                s.correo_UsuarioTextBox.Text = UsuarioBD.temporal.Rows[i]["Nombre"].ToString();
                s.apellido_UsuarioTextBox.Text = UsuarioBD.temporal.Rows[i]["Correo"].ToString();
                s.correo_UsuarioTextBox.Text = UsuarioBD.temporal.Rows[i]["Usuario"].ToString();
                s.celular_UsuarioTextBox.Text = UsuarioBD.temporal.Rows[i]["Contrasena"].ToString();
                s.password_UsuarioTextBox.Text = UsuarioBD.temporal.Rows[i]["Correo"].ToString();
                s.rol_UsuarioComboBox.Text = UsuarioBD.temporal.Rows[i]["Usuario"].ToString();
                s.estado_UsuarioComboBox.Text = UsuarioBD.temporal.Rows[i]["Contrasena"].ToString();
                s.direccion_ImagenTextBox.Text = UsuarioBD.temporal.Rows[i]["Rol"].ToString();
               // s.photo_UsuarioPictureBox.Image = CsImagen.byteArrayToImage((Byte[])(UsuarioBD.temporal.Rows[0]["Foto"]));
            }
            s.uSUARIOSDataGridView.DataSource = UsuarioBD.temporal;
        }
        public void AgregarUsuarioBD(string Cedula, string Nombre, string Apellido, string Correo, string Celular, string Password, string Rol_Usuario, string Estado, string Direccion_Foto, byte[] Photo)
        {
            ClsConexion conectar = new ClsConexion();
            conectar.Conectar();

            string ConsultaInsertaUsuario = "INSERT INTO USUARIOS (Cedula_Usuario,Nombre_Usuario,Apellido_Usuario,Correo_Usuario,Celular_Usuario,Password_Usuario,Rol_Usuario,Estado_Usuario,Direccion_Imagen,Photo_Usuario)VALUES(@Cedula_Usuario,@Nombre_Usuario,@Apellido_Usuario,@Correo_Usuario,@Celular_Usuario,@Password_Usuario,@Rol_Usuario,@Estado_Usuario,@Direccion_Imagen,@Photo_Usuario)";

            SqlCommand comandoInsertaruser = new SqlCommand(ConsultaInsertaUsuario, conectar.Conectar());


            comandoInsertaruser.Parameters.AddWithValue("@Cedula_Usuario", Cedula);
            comandoInsertaruser.Parameters.AddWithValue("@Nombre_Usuario", Nombre);
            comandoInsertaruser.Parameters.AddWithValue("@Apellido_Usuario", Apellido);
            comandoInsertaruser.Parameters.AddWithValue("@Correo_Usuario", Correo);
            comandoInsertaruser.Parameters.AddWithValue("@Celular_Usuario", Celular);
            comandoInsertaruser.Parameters.AddWithValue("@Password_Usuario", Password);
            comandoInsertaruser.Parameters.AddWithValue("@Rol_Usuario", Rol_Usuario);
            comandoInsertaruser.Parameters.AddWithValue("@Estado_Usuario", Estado);
            comandoInsertaruser.Parameters.AddWithValue("@Direccion_Imagen", Direccion_Foto);
            comandoInsertaruser.Parameters.AddWithValue("@Photo_Usuario", Photo);

            comandoInsertaruser.ExecuteNonQuery();
            
        }

        
        public void ModificarUsuarioBD(int Id, string Cedula, string Nombre, string Apellido, string Correo, string Celular, string Password, string Rol_Usuario, string Estado, string Direccion_Foto, byte[] Photo)
        {
            ClsConexion conectar = new ClsConexion();
            conectar.Conectar();
            string ConsultaModificar = "UPDATE USUARIOS SET Cedula_Usuario=@Cedula_Usuario,Nombre_Usuario=@Nombre_Usuario,Apellido_Usuario=@Apellido_Usuario,Correo_Usuario=@Correo_Usuario,Celular_Usuario=@Celular_Usuario,Password_Usuario=@Password_Usuario,Rol_Usuario=@Rol_Usuario,Estado_Usuario=@Estado_Usuario,Direccion_Imagen=@Direccion_Imagen,Photo_Usuario=@Photo_Usuario WHERE Id_Usuario=@Id_Usuario";
            SqlCommand slq = new SqlCommand(ConsultaModificar, conectar.Conectar());
            slq.Parameters.AddWithValue("@Id_Usuario", Id);
            slq.Parameters.AddWithValue("@Cedula_Usuario", Cedula);
            slq.Parameters.AddWithValue("@Nombre_Usuario", Nombre);
            slq.Parameters.AddWithValue("@Apellido_Usuario", Apellido);
            slq.Parameters.AddWithValue("@Correo_Usuario", Correo);
            slq.Parameters.AddWithValue("@Celular_Usuario", Celular);
            slq.Parameters.AddWithValue("@Password_Usuario", Password);
            slq.Parameters.AddWithValue("@Rol_Usuario", Rol_Usuario);
            slq.Parameters.AddWithValue("@Estado_Usuario", Estado);
            slq.Parameters.AddWithValue("@Direccion_Imagen", Direccion_Foto);
            slq.Parameters.AddWithValue("@Photo_Usuario", Photo);
            slq.ExecuteNonQuery();

        }

        public DataTable LlenarUSuariosBD()
        {
            ClsConexion conexion = new ClsConexion();
            string readLlenar = "SELECT * FROM USUARIOS";
            SqlCommand sql = new SqlCommand(readLlenar, conexion.Conectar());

            SqlDataAdapter sqlData = new SqlDataAdapter(sql);
            DataTable dt = new DataTable();
            sqlData.Fill(dt);
            return dt;

        }

    }
}
