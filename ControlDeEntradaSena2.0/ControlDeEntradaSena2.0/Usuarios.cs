using ControlDeEntradaSena2._0.CpDato;
using ControlDeEntradaSena2._0.CpValidation;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ControlDeEntradaSena2._0
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();

        }
        public Byte[] arrayImagenUser;
        public string cedulaValidada;
        CsImagen image = new CsImagen();
        UsuarioBD agregarDB = new UsuarioBD();
        private void uSUARIOSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.uSUARIOSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistemadeAsistenciaDataSet);

        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemadeAsistenciaDataSet.USUARIOS' Puede moverla o quitarla según sea necesario.
            this.uSUARIOSTableAdapter.Fill(this.sistemadeAsistenciaDataSet.USUARIOS);

        }

        private void uSUARIOSDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void uSUARIOSBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.uSUARIOSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistemadeAsistenciaDataSet);

        }

        private void Usuarios_Load_1(object sender, EventArgs e)
        {
            
            // TODO: esta línea de código carga datos en la tabla 'sistemadeAsistenciaDataSet.USUARIOS' Puede moverla o quitarla según sea necesario.
            this.uSUARIOSTableAdapter.Fill(this.sistemadeAsistenciaDataSet.USUARIOS);

        }

        private void cedula_UsuarioLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClsOpenDialogPicture abrirCadena = new ClsOpenDialogPicture( this.photo_UsuarioPictureBox.Image);
            try
            {
                this.direccion_ImagenTextBox.Text = abrirCadena.AbrirCadena(this.direccion_ImagenTextBox.Text);
                this.photo_UsuarioPictureBox.Image = abrirCadena.MostrarImagen(this.direccion_ImagenTextBox.Text);

                CsImagen imagenArray = new CsImagen();
                arrayImagenUser = imagenArray.ImageToByteArray(this.photo_UsuarioPictureBox.Image);
            }
            catch
            {
                MessageBox.Show("Escoja una foto", "Notificación");
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            Menu a = new Menu();
            a.Show();
            this.Close();
        }

        private void photo_UsuarioLabel_Click(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            this.uSUARIOSDataGridView.Enabled = false;
            this.PnlDatos.Enabled = true;
            this.bunifuThinButton21.Visible = true;
            this.bunifuThinButton22.Visible = true;
            this.bunifuThinButton23.Visible = false;
            this.Btnmodificarb.Visible = false;
            this.cedula_UsuarioTextBox.Text = null;
            this.photo_UsuarioPictureBox.Image = null;
            this.nombre_UsuarioTextBox.Text = null;
            this.apellido_UsuarioTextBox.Text = null;
            this.correo_UsuarioTextBox.Text = null;
            this.celular_UsuarioTextBox.Text = null;
            this.password_UsuarioTextBox.Text = null;
            this.rol_UsuarioComboBox.Text = null;
            this.estado_UsuarioComboBox.Text = null;
            this.cedula_UsuarioTextBox.Focus();

        }



        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            CsUsuario agregarDB = new CsUsuario(this.cedula_UsuarioTextBox.Text, this.nombre_UsuarioTextBox.Text, this.apellido_UsuarioTextBox.Text, this.correo_UsuarioTextBox.Text, this.celular_UsuarioTextBox.Text, this.password_UsuarioTextBox.Text, this.rol_UsuarioComboBox.Text, this.estado_UsuarioComboBox.Text, this.direccion_ImagenTextBox.Text, this.arrayImagenUser);
            {
                if (string.IsNullOrEmpty(this.nombre_UsuarioTextBox.Text))
                {
                    MessageBox.Show("Digite el Nombre de usuario", "Notificación");
                    nombre_UsuarioTextBox.Focus();
                }
                else
                {
                    if (string.IsNullOrEmpty(this.apellido_UsuarioTextBox.Text))
                    {
                        MessageBox.Show("Digite el Apellido de usuario", "Notificación");
                        apellido_UsuarioTextBox.Focus();
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(this.celular_UsuarioTextBox.Text))
                        {
                            MessageBox.Show("Digite el Teléfono de Usuario", "Notificación");
                            celular_UsuarioTextBox.Focus();
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(this.rol_UsuarioComboBox.Text))
                            {
                                MessageBox.Show("Digite el Rol de Usuario", "Notificación");
                                rol_UsuarioComboBox.Focus();
                            }

                            else
                            {


                                if (string.IsNullOrEmpty(this.correo_UsuarioTextBox.Text) || ValidarCorreo.ValidarCorreoe(this.correo_UsuarioTextBox.Text) == false)
                                {
                                    MessageBox.Show("Digite un correo válido", "Notificación");
                                    correo_UsuarioTextBox.Focus();
                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(this.password_UsuarioTextBox.Text))
                                    {
                                        MessageBox.Show("Digite la Constraseña de Usuario", "Notificación");
                                        password_UsuarioTextBox.Focus();
                                    }
                                    else
                                    {
                                        if (this.estado_UsuarioComboBox.Text == "")
                                        {
                                            MessageBox.Show("Digite el estado del Usuario", "Notificación");
                                            estado_UsuarioComboBox.Focus();
                                        }
                                        else
                                        {
                                            if (this.direccion_ImagenTextBox.Text == "")
                                            {
                                                MessageBox.Show("Elije una foto", "Notificación");
                                               
                                            }
                                            else
                                            {
                                            DataTable valiacioncedula = new DataTable();
                                            valiacioncedula = agregarDB.ValidarCedula(this.cedula_UsuarioTextBox.Text);

                                            if (valiacioncedula.Rows.Count == 0)
                                            {
                                                string cedulavalida = ValidarClave.GetSHA256(this.password_UsuarioTextBox.Text);

                                                agregarDB.AgregarUsuario(this.cedula_UsuarioTextBox.Text, this.nombre_UsuarioTextBox.Text, apellido_UsuarioTextBox.Text, this.correo_UsuarioTextBox.Text, this.celular_UsuarioTextBox.Text, cedulavalida, this.rol_UsuarioComboBox.Text, this.estado_UsuarioComboBox.Text, this.direccion_ImagenTextBox.Text, this.arrayImagenUser);

                                                    DataTable dt = new DataTable();
                                                dt = agregarDB.LlenarUsuarios();

                                                MessageBox.Show("Usuario Agregado Con Exito :D", "Felicidades", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                                this.cedula_UsuarioTextBox.Text = null;
                                                this.photo_UsuarioPictureBox.Image = null;
                                                this.nombre_UsuarioTextBox.Text = null;
                                                this.apellido_UsuarioTextBox.Text = null;
                                                this.correo_UsuarioTextBox.Text = null;
                                                this.celular_UsuarioTextBox.Text = null;
                                                this.password_UsuarioTextBox.Text = null;
                                                this.rol_UsuarioComboBox.Text = null;
                                                this.estado_UsuarioComboBox.Text = null;
                                                this.cedula_UsuarioTextBox.Focus();
                                            }
                                            else
                                            {
                                                MessageBox.Show("Ya existe un Usuario con esta cédula", ":(");
                                            }

                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.uSUARIOSDataGridView.Enabled = true;
            this.PnlDatos.Enabled = true;
            this.Btnmodificarb.Visible = true;
            this.bunifuThinButton23.Visible = true;
            this.bunifuThinButton21.Visible = false;
            this.bunifuThinButton22.Visible = false;
        }

        private void PnlDatos_Paint(object sender, PaintEventArgs e)
        {

        }

       
        

        private void BtnCancelaR_Click(object sender, EventArgs e)
        {
           
        }

        
            
       

        private void btncancelar2_Click(object   sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cancelar el proceso?", "Notificación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                this.cedula_UsuarioTextBox.Text = "";
                this.nombre_UsuarioTextBox.Text = "";
                this.apellido_UsuarioTextBox.Text = "";
                this.correo_UsuarioTextBox.Text = "";
                this.celular_UsuarioTextBox.Text = "";
                this.password_UsuarioTextBox.Text = "";
                this.direccion_ImagenTextBox.Text = "";
                this.rol_UsuarioComboBox.Text = "";
                this.estado_UsuarioComboBox.Text = "";
                this.photo_UsuarioPictureBox.Image = null;
                this.PnlDatos.Enabled = false;
                this.Btnmodificarb.Visible = false;
                this.bunifuThinButton23.Visible = false;

            }
        }

        private void BfotoAgregar_Click(object sender, EventArgs e)
        {
            {
                ClsOpenDialogPicture abrirCadena = new ClsOpenDialogPicture(this.photo_UsuarioPictureBox.Image);
                try
                {
                    this.direccion_ImagenTextBox.Text = abrirCadena.AbrirCadena(this.direccion_ImagenTextBox.Text);
                    this.photo_UsuarioPictureBox.Image = abrirCadena.MostrarImagen(this.direccion_ImagenTextBox.Text);

                    CsImagen imagenArray = new CsImagen();
                    arrayImagenUser = imagenArray.ImageToByteArray(this.photo_UsuarioPictureBox.Image);
                }
                catch
                {
                    MessageBox.Show("Escoja una foto", "Notificación");
                }

            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            {
                {
                    CsUsuario agregarDB = new CsUsuario(this.cedula_UsuarioTextBox.Text, this.nombre_UsuarioTextBox.Text, this.apellido_UsuarioTextBox.Text, this.correo_UsuarioTextBox.Text, this.celular_UsuarioTextBox.Text, this.password_UsuarioTextBox.Text, this.rol_UsuarioComboBox.Text, this.estado_UsuarioComboBox.Text, this.direccion_ImagenTextBox.Text, this.arrayImagenUser);
                    {
                        if (string.IsNullOrEmpty(this.nombre_UsuarioTextBox.Text))
                        {
                            MessageBox.Show("Digite el Nombre de usuario", "Notificación");
                            nombre_UsuarioTextBox.Focus();
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(this.apellido_UsuarioTextBox.Text))
                            {
                                MessageBox.Show("Digite el Apellido de usuario", "Notificación");
                                apellido_UsuarioTextBox.Focus();
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(this.celular_UsuarioTextBox.Text))
                                {
                                    MessageBox.Show("Digite el Teléfono de Usuario", "Notificación");
                                    celular_UsuarioTextBox.Focus();
                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(this.rol_UsuarioComboBox.Text))
                                    {
                                        MessageBox.Show("Digite el Rol de Usuario", "Notificación");
                                        rol_UsuarioComboBox.Focus();
                                    }

                                    else
                                    {


                                        if (string.IsNullOrEmpty(this.correo_UsuarioTextBox.Text) || ValidarCorreo.ValidarCorreoe(this.correo_UsuarioTextBox.Text) == false)
                                        {
                                            MessageBox.Show("Digite un correo válido", "Notificación");
                                            correo_UsuarioTextBox.Focus();
                                        }
                                        else
                                        {
                                            if (string.IsNullOrEmpty(this.password_UsuarioTextBox.Text))
                                            {
                                                MessageBox.Show("Digite la Constraseña de Usuario", "Notificación");
                                                password_UsuarioTextBox.Focus();
                                            }
                                            else
                                            {
                                                if (this.estado_UsuarioComboBox.Text == "")
                                                {
                                                    MessageBox.Show("Digite el estado del Usuario", "Notificación");
                                                    estado_UsuarioComboBox.Focus();
                                                }
                                                else
                                                {
                                                    if (this.direccion_ImagenTextBox.Text == "")
                                                    {
                                                        MessageBox.Show("Elije una foto", "Notificación");

                                                    }
                                                    else
                                                    {
                                                        DataTable valiacioncedula = new DataTable();
                                                        valiacioncedula = agregarDB.ValidarCedula(this.cedula_UsuarioTextBox.Text);

                                                        if (valiacioncedula.Rows.Count == 0)
                                                        {
                                                            string cedulavalida = ValidarClave.GetSHA256(this.password_UsuarioTextBox.Text);

                                                            agregarDB.AgregarUsuario(this.cedula_UsuarioTextBox.Text, this.nombre_UsuarioTextBox.Text, apellido_UsuarioTextBox.Text, this.correo_UsuarioTextBox.Text, this.celular_UsuarioTextBox.Text, cedulavalida, this.rol_UsuarioComboBox.Text, this.estado_UsuarioComboBox.Text, this.direccion_ImagenTextBox.Text, this.arrayImagenUser);

                                                            DataTable dt = new DataTable();
                                                            dt = agregarDB.LlenarUsuarios();

                                                            MessageBox.Show("Usuario Agregado Con Exito :D", "Felicidades", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                                            this.cedula_UsuarioTextBox.Text = null;
                                                            this.photo_UsuarioPictureBox.Image = null;
                                                            this.nombre_UsuarioTextBox.Text = null;
                                                            this.apellido_UsuarioTextBox.Text = null;
                                                            this.correo_UsuarioTextBox.Text = null;
                                                            this.celular_UsuarioTextBox.Text = null;
                                                            this.password_UsuarioTextBox.Text = null;
                                                            this.rol_UsuarioComboBox.Text = null;
                                                            this.estado_UsuarioComboBox.Text = null;
                                                            this.cedula_UsuarioTextBox.Focus();
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Ya existe un Usuario con esta cédula", ":(");
                                                        }

                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
            {
                if (MessageBox.Show("¿Desea cancelar el proceso?", "Notificación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    this.cedula_UsuarioTextBox.Text = "";
                    this.nombre_UsuarioTextBox.Text = "";
                    this.apellido_UsuarioTextBox.Text = "";
                    this.correo_UsuarioTextBox.Text = "";
                    this.celular_UsuarioTextBox.Text = "";
                    this.password_UsuarioTextBox.Text = "";
                    this.direccion_ImagenTextBox.Text = "";
                    this.rol_UsuarioComboBox.Text = "";
                    this.estado_UsuarioComboBox.Text = "";
                    this.photo_UsuarioPictureBox.Image = null;
                    this.PnlDatos.Enabled = false;
                    this.bunifuThinButton21.Visible = false;
                    this.bunifuThinButton22.Visible = false;
                    this.uSUARIOSDataGridView.Enabled = true;

                }
            }
        }

        private void Btnmodificarb_Click(object sender, EventArgs e)
        {
            {
                arrayImagenUser = image.ImageToByteArray(photo_UsuarioPictureBox.Image);
                if (string.IsNullOrEmpty(this.nombre_UsuarioTextBox.Text))
                {
                    MessageBox.Show("Digite el Nombre de usuario", "Notificación");
                    nombre_UsuarioTextBox.Focus();
                }
                else
                {
                    if (string.IsNullOrEmpty(this.apellido_UsuarioTextBox.Text))
                    {
                        MessageBox.Show("Digite el Apellido de usuario", "Notificación");
                        apellido_UsuarioTextBox.Focus();
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(this.celular_UsuarioTextBox.Text))
                        {
                            MessageBox.Show("Digite el Teléfono de Usuario", "Notificación");
                            celular_UsuarioTextBox.Focus();
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(this.rol_UsuarioComboBox.Text))
                            {
                                MessageBox.Show("Digite el Rol de Usuario", "Notificación");
                                rol_UsuarioComboBox.Focus();
                            }

                            else
                            {
                                if (string.IsNullOrEmpty(this.correo_UsuarioTextBox.Text) || ValidarCorreo.ValidarCorreoe(this.correo_UsuarioTextBox.Text) == false)
                                {
                                    MessageBox.Show("Ingrese un correo válido", "Notificación");
                                    correo_UsuarioTextBox.Focus();
                                }
                                else
                                {
                                    if (this.direccion_ImagenTextBox.Text == "")
                                    {
                                        MessageBox.Show("Escoja una foto valida", "Notificacion");
                                    }
                                    else
                                    {
                                        DataTable validacionCedula = new DataTable();
                                        validacionCedula = agregarDB.ValidarCedulaBD(this.cedula_UsuarioTextBox.Text);
                                        if (validacionCedula.Rows.Count == 0 || validacionCedula.Rows[0][0].ToString() == this.id_UsuarioTextBox.Text)
                                        {
                                            if (this.password_UsuarioTextBox.Text != "")
                                            {
                                                cedulaValidada = ValidarClave.GetSHA256(this.password_UsuarioTextBox.Text);
                                            }

                                            CsUsuario ModificarUsuario = new CsUsuario(this.cedula_UsuarioTextBox.Text, this.nombre_UsuarioTextBox.Text, this.apellido_UsuarioTextBox.Text, this.correo_UsuarioTextBox.Text, this.celular_UsuarioTextBox.Text, this.password_UsuarioTextBox.Text, this.rol_UsuarioComboBox.Text, this.estado_UsuarioComboBox.Text, this.direccion_ImagenTextBox.Text, this.arrayImagenUser);

                                            ModificarUsuario.ModificarUsuario(int.Parse(this.id_UsuarioTextBox.Text), this.cedula_UsuarioTextBox.Text, this.nombre_UsuarioTextBox.Text, apellido_UsuarioTextBox.Text, this.correo_UsuarioTextBox.Text, this.celular_UsuarioTextBox.Text, cedulaValidada, this.rol_UsuarioComboBox.Text, this.estado_UsuarioComboBox.Text, this.direccion_ImagenTextBox.Text, this.arrayImagenUser);

                                            DataTable dataUser = new DataTable();
                                            dataUser = ModificarUsuario.LlenarUsuarios();

                                            MessageBox.Show("Usuario Modificado", "Notiicación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            this.cedula_UsuarioTextBox.Text = "";
                                            this.nombre_UsuarioTextBox.Text = "";
                                            this.apellido_UsuarioTextBox.Text = "";
                                            this.correo_UsuarioTextBox.Text = "";
                                            this.celular_UsuarioTextBox.Text = "";
                                            this.password_UsuarioTextBox.Text = "";
                                            this.direccion_ImagenTextBox.Text = "";
                                            this.rol_UsuarioComboBox.Text = "";
                                            this.estado_UsuarioComboBox.Text = "";
                                            this.photo_UsuarioPictureBox.Image = null;
                                            this.PnlDatos.Enabled = false;
                                            this.Btnmodificarb.Visible = false;
                                            this.bunifuThinButton23.Visible = false;

                                        }
                                        else
                                        {
                                            MessageBox.Show("Ya existe Un Usuario con esta cedula", ":(");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            {
                {
                    if (MessageBox.Show("¿Desea cancelar el proceso?", "Notificación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        this.cedula_UsuarioTextBox.Text = "";
                        this.nombre_UsuarioTextBox.Text = "";
                        this.apellido_UsuarioTextBox.Text = "";
                        this.correo_UsuarioTextBox.Text = "";
                        this.celular_UsuarioTextBox.Text = "";
                        this.password_UsuarioTextBox.Text = "";
                        this.direccion_ImagenTextBox.Text = "";
                        this.rol_UsuarioComboBox.Text = "";
                        this.estado_UsuarioComboBox.Text = "";
                        this.photo_UsuarioPictureBox.Image = null;
                        this.PnlDatos.Enabled = false;
                        this.bunifuThinButton21.Visible = false;
                        this.bunifuThinButton22.Visible = false;
                        this.uSUARIOSDataGridView.Enabled = true;

                    }
                }
            }
        }

        private void estado_UsuarioComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
