using ControlDeEntradaSena2._0.CpDato;
using System.Data;
using System.Data.SqlClient;


namespace ControlDeEntradaSena2._0.CpValidation
{
    public class CsUsuario
	    {
		public string Cedula { get; set; }
		public string Nombre { get; set; }

		public string Apellido { get; set; }
		public string Correo { get; set; }
		public string Celular { get; set; }

		private string Password { get; set; }
		private string Rol_Usuario { get; set; }

		public string Estado { get; set; }
        public string Direccion_Foto { get; set; }
        public byte[] Photo { get; set; }
	

	public CsUsuario(string cedula, string nombre, string apellido, string correo, string celular, string password, string rol_Usuario, string estado, string direccion_Foto, byte[] photo)
        {
            Cedula = cedula;
            Nombre = nombre;
            Apellido = apellido;
            Correo = correo;
            Celular = celular;
            Password = password;
            Rol_Usuario = rol_Usuario;
            Estado = estado;
            Direccion_Foto = direccion_Foto;
            Photo = photo;
        }
        public void AgregarUsuario(string cedula, string nombre, string apellido, string correo, string celular, string password, string rol_Usuario, string estado, string direccion_Foto, byte[] photo)
        {
            UsuarioBD userDb = new UsuarioBD();
            userDb.AgregarUsuarioBD(cedula, nombre, apellido, correo, celular, password, rol_Usuario, estado, direccion_Foto, photo);
        }
        public DataTable ValidarCedula(string Cedula)
		{
			UsuarioBD validarCedula = new UsuarioBD();
			return validarCedula.ValidarCedulaBD(Cedula);
		}
        public DataTable LlenarUsuarios()
        {
            UsuarioBD clsUsuarioBD = new UsuarioBD();
            return clsUsuarioBD.LlenarUSuariosBD();
        }
        public void ModificarUsuario(int id, string cedula, string nombre, string apellido, string correo, string celular, string password, string rol_Usuario, string estado, string direccion_Foto, byte[] photo)
        {
            UsuarioBD userDb = new UsuarioBD();
            userDb.ModificarUsuarioBD(id, cedula, nombre, apellido, correo, celular, password, rol_Usuario, estado, direccion_Foto, photo);
        }
       
    }
}


