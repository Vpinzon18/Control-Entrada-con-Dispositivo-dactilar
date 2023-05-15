using ControlDeEntradaSena2._0.CpDato;
using ControlDeEntradaSena2._0.CpValidation;
using DPFP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDeEntradaSena2._0
{
    public partial class AgregarPersonas : Form
    {
        public AgregarPersonas()
        {
            InitializeComponent();
            Data = new AppData();
        }
        Byte[] arrayImagenUser;
        public AppData Data;
        public int i;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Personas a = new Personas();
            a.Show();
            this.Hide();
        }

        private void pERSONASBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pERSONASBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistemadeAsistenciaDataSet);

        }

        private void AgregarPersonas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemadeAsistenciaDataSet.PERSONAS' Puede moverla o quitarla según sea necesario.
            this.pERSONASTableAdapter.Fill(this.sistemadeAsistenciaDataSet.PERSONAS);

        }

        private void cedula_PersonaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {

                int cantidadHuellas;
                if (this.TxtnoDedo.Text == "")
                {
                    MessageBox.Show("Ingrese el código de barras", "Notificación");
                }
                else
                {
                    if (this.nombre_PersonaTextBox.Text == "")
                    {
                        MessageBox.Show("Ingrese el nombre de la Persona", "Notificación");
                    }
                    else
                    {
                        if (this.apellido_PersonaTextBox.Text == "")
                        {
                            MessageBox.Show("Ingrese el apellido de la persona", "Notificación");
                        }
                        else
                        {
                            if (this.correo_PersonaTextBox.Text == "" || ValidarCorreo.ValidarCorreoe(this.correo_PersonaTextBox.Text) == false)
                            {
                                MessageBox.Show("Ingrese un correo válido", "Notificación");
                            }
                            else
                            {
                                if (this.celular_PersonaTextBox.Text == "")
                                {
                                    MessageBox.Show("Ingrese el teléfono de la persona", "Notificación");

                                }
                                else
                                {
                                    if (this.funcionario_PersonaComboBox.Text == "")
                                    {
                                        MessageBox.Show("Ingrese el rol del funcionario", "Notificación");
                                    }
                                    else
                                    {
                                        if (this.ficha_PersonaTextBox.Text == "")
                                        {
                                            MessageBox.Show("Ingrese la ficha", "Notificación");
                                        }
                                        else
                                        {
                                            if (this.direccion_ImagenTextBox.Text == "")
                                            {
                                                MessageBox.Show("Ingrese una imagen", "Notificación");
                                            }
                                            else
                                            {
                                                cantidadHuellas = 0;

                                                for (int i = 0; i < 10; i++)
                                                {
                                                    if (Data.Templates[i] != null)
                                                    {
                                                        cantidadHuellas++;

                                                    }
                                                }
                                                if ((cantidadHuellas == 0) && (this.enrollmentControl1.EnrolledFingerMask == 0))
                                                {
                                                    MessageBox.Show("No se puede guardar el registro, debe registrar mínimo una huella dáctilar", "Error");
                                                    this.cedula_PersonaTextBox.Focus();
                                                }
                                                else
                                                {
                                                    try
                                                    {
                                                        cantidadHuellas = 0;
                                                        for (i = 0; i < 10; i++)
                                                        {
                                                            if ((Data.Templates[i] != null))
                                                            {
                                                                cantidadHuellas++;
                                                                this.TxtnoDedo.Text = (i + 1).ToString();

                                                                //ClsPersona clsPersona1 = new ClsPersona(arrayImagenUser, this.txtName.Text, this.txtLastName.Text, this.txtCorreo.Text, this.txtTelefono.Text, this.comboFuncionamiento.Text, this.txtFicha.Text, this.txtFile.Text, arrayImagenUser, int.Parse(this.txtCodigo.Text));
                                                                PersonasBD clsPersona = new PersonasBD();
                                                                DataTable data = new DataTable();
                                                                data = clsPersona.ValidarCedulaBD(this.cedula_PersonaTextBox.Text);

                                                                if (data.Rows.Count == 0)
                                                                {


                                                                    clsPersona.AgregarPersonasBD(Data.Templates[i].Bytes, this.cedula_PersonaTextBox.Text, this.nombre_PersonaTextBox.Text, this.apellido_PersonaTextBox.Text, this.correo_PersonaTextBox.Text, this.celular_PersonaTextBox.Text, this.funcionario_PersonaComboBox.Text, this.ficha_PersonaTextBox.Text, this.direccion_ImagenTextBox.Text, arrayImagenUser, int.Parse(this.TxtnoDedo.Text));

                                                                    DataTable dataPeople = new DataTable();
                                                                    dataPeople = clsPersona.LlenarDatosBD();

                                                                    //Mensaje de Salida para que el usuario sepa que está agregado el Usuario 
                                                                    MessageBox.Show("Persona Agregada", "Notiicación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                    this.TxtnoDedo.Text = "";
                                                                    this.nombre_PersonaTextBox.Text = "";
                                                                    this.apellido_PersonaTextBox.Text = "";
                                                                    this.correo_PersonaTextBox.Text = "";
                                                                    this.celular_PersonaTextBox.Text = "";
                                                                    this.funcionario_PersonaComboBox.Text = "";
                                                                    this.direccion_ImagenTextBox.Text = "";
                                                                    this.ficha_PersonaTextBox.Text = "";
                                                                    this.photo_PersonaPictureBox.Image = null;
                                                                }
                                                                //}
                                                                //else
                                                                //{
                                                                //    MessageBox.Show("Este código ya existe", "Notificación");
                                                                //}
                                                                else
                                                                {
                                                                    MessageBox.Show("Ya existe una persona con esta cédula");
                                                                    int idPersona = int.Parse(data.Rows[0][0].ToString());

                                                                }
                                                            }

                                                        }

                                                    }
                                                    catch (Exception e1)
                                                    {
                                                        MessageBox.Show("No se puede guardar el registro en la base de datos" + e1.ToString(), "Error");
                                                        this.TxtnoDedo.Focus();

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

        private void button2_Click(object sender, EventArgs e)
        {
            {
                ClsOpenDialogPicture abrirCadena = new ClsOpenDialogPicture(this.photo_PersonaPictureBox.Image);
                try
                {
                    this.direccion_ImagenTextBox.Text = abrirCadena.AbrirCadena(this.direccion_ImagenTextBox.Text);
                    this.photo_PersonaPictureBox.Image = abrirCadena.MostrarImagen(this.direccion_ImagenTextBox.Text);

                    CsImagen imagenArray = new CsImagen();
                    arrayImagenUser = imagenArray.ImageToByteArray(this.photo_PersonaPictureBox.Image);
                }
                catch
                {
                    MessageBox.Show("Escoja una foto", "Notificación");
                }

            }
        }

        private void btncancelar2_Click(object sender, EventArgs e)
        {
            {
                if (MessageBox.Show("¿Desea cancelar el proceso?", "Notificación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    this.cedula_PersonaTextBox.Text = "";
                    this.nombre_PersonaTextBox.Text = "";
                    this.apellido_PersonaTextBox.Text = "";
                    this.correo_PersonaTextBox.Text = "";
                    this.celular_PersonaTextBox.Text = "";
                    this.funcionario_PersonaComboBox.Text = "";
                    this.direccion_ImagenTextBox.Text = "";
                    this.ficha_PersonaTextBox.Text = "";
                    this.photo_PersonaPictureBox.Image = null;

                }
            }
        }

        private void enrollmentControl1_OnDelete(object Control, int FingerMask, ref DPFP.Gui.EventHandlerStatus EventHandlerStatus)
        {
            if (Data.IsEventHandlerSucceeds)
            {
                Data.Templates[FingerMask - 1] = null;
            }
            else
            {
                EventHandlerStatus = DPFP.Gui.EventHandlerStatus.Failure;
            }
        }

        private void enrollmentControl1_OnEnroll(object Control, int FingerMask, Template Template, ref DPFP.Gui.EventHandlerStatus EventHandlerStatus)
        {
            if (Data.IsEventHandlerSucceeds)
            {
                LimpiarHuella(this);
                Data.Templates[FingerMask - 1] = Template;
            }
            else
            {
                EventHandlerStatus = DPFP.Gui.EventHandlerStatus.Failure;
            }
        }
        private static void LimpiarHuella(AgregarPersonas x)
        {
            for (int i = 0; i < 10; i++)
            {
                x.Data.Templates[i] = null;
            }
            x.TxtnoDedo.Text = "0";
        }

        private void enrollmentControl1_OnStartEnroll(object Control, string ReaderSerialNumber, int Finger)
        {
            this.TxtnoDedo.Text = Finger.ToString();
        }

        private void celular_PersonaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BfotoAgregar_Click(object sender, EventArgs e)
        {
            {
                ClsOpenDialogPicture abrirCadena = new ClsOpenDialogPicture(this.photo_PersonaPictureBox.Image);
                try
                {
                    this.direccion_ImagenTextBox.Text = abrirCadena.AbrirCadena(this.direccion_ImagenTextBox.Text);
                    this.photo_PersonaPictureBox.Image = abrirCadena.MostrarImagen(this.direccion_ImagenTextBox.Text);

                    CsImagen imagenArray = new CsImagen();
                    arrayImagenUser = imagenArray.ImageToByteArray(this.photo_PersonaPictureBox.Image);
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

                    int cantidadHuellas;
                    if (this.TxtnoDedo.Text == "")
                    {
                        MessageBox.Show("Ingrese el código de barras", "Notificación");
                    }
                    else
                    {
                        if (this.nombre_PersonaTextBox.Text == "")
                        {
                            MessageBox.Show("Ingrese el nombre de la Persona", "Notificación");
                        }
                        else
                        {
                            if (this.apellido_PersonaTextBox.Text == "")
                            {
                                MessageBox.Show("Ingrese el apellido de la persona", "Notificación");
                            }
                            else
                            {
                                if (this.correo_PersonaTextBox.Text == "" || ValidarCorreo.ValidarCorreoe(this.correo_PersonaTextBox.Text) == false)
                                {
                                    MessageBox.Show("Ingrese un correo válido", "Notificación");
                                }
                                else
                                {
                                    if (this.celular_PersonaTextBox.Text == "")
                                    {
                                        MessageBox.Show("Ingrese el teléfono de la persona", "Notificación");

                                    }
                                    else
                                    {
                                        if (this.funcionario_PersonaComboBox.Text == "")
                                        {
                                            MessageBox.Show("Ingrese el rol del funcionario", "Notificación");
                                        }
                                        else
                                        {
                                            if (this.ficha_PersonaTextBox.Text == "")
                                            {
                                                MessageBox.Show("Ingrese la ficha", "Notificación");
                                            }
                                            else
                                            {
                                                if (this.direccion_ImagenTextBox.Text == "")
                                                {
                                                    MessageBox.Show("Ingrese una imagen", "Notificación");
                                                }
                                                else
                                                {
                                                    cantidadHuellas = 0;

                                                    for (int i = 0; i < 10; i++)
                                                    {
                                                        if (Data.Templates[i] != null)
                                                        {
                                                            cantidadHuellas++;

                                                        }
                                                    }
                                                    if ((cantidadHuellas == 0) && (this.enrollmentControl1.EnrolledFingerMask == 0))
                                                    {
                                                        MessageBox.Show("No se puede guardar el registro, debe registrar mínimo una huella dáctilar", "Error");
                                                        this.cedula_PersonaTextBox.Focus();
                                                    }
                                                    else
                                                    {
                                                        try
                                                        {
                                                            cantidadHuellas = 0;
                                                            for (i = 0; i < 10; i++)
                                                            {
                                                                if ((Data.Templates[i] != null))
                                                                {
                                                                    cantidadHuellas++;
                                                                    this.TxtnoDedo.Text = (i + 1).ToString();

                                                                    //ClsPersona clsPersona1 = new ClsPersona(arrayImagenUser, this.txtName.Text, this.txtLastName.Text, this.txtCorreo.Text, this.txtTelefono.Text, this.comboFuncionamiento.Text, this.txtFicha.Text, this.txtFile.Text, arrayImagenUser, int.Parse(this.txtCodigo.Text));
                                                                    PersonasBD clsPersona = new PersonasBD();
                                                                    DataTable data = new DataTable();
                                                                    data = clsPersona.ValidarCedulaBD(this.cedula_PersonaTextBox.Text);

                                                                    if (data.Rows.Count == 0)
                                                                    {


                                                                        clsPersona.AgregarPersonasBD(Data.Templates[i].Bytes, this.cedula_PersonaTextBox.Text, this.nombre_PersonaTextBox.Text, this.apellido_PersonaTextBox.Text, this.correo_PersonaTextBox.Text, this.celular_PersonaTextBox.Text, this.funcionario_PersonaComboBox.Text, this.ficha_PersonaTextBox.Text, this.direccion_ImagenTextBox.Text, arrayImagenUser, int.Parse(this.TxtnoDedo.Text));

                                                                        DataTable dataPeople = new DataTable();
                                                                        dataPeople = clsPersona.LlenarDatosBD();

                                                                        //Mensaje de Salida para que el usuario sepa que está agregado el Usuario 
                                                                        MessageBox.Show("Persona Agregada", "Notiicación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                                        this.TxtnoDedo.Text = "";
                                                                        this.nombre_PersonaTextBox.Text = "";
                                                                        this.apellido_PersonaTextBox.Text = "";
                                                                        this.correo_PersonaTextBox.Text = "";
                                                                        this.celular_PersonaTextBox.Text = "";
                                                                        this.funcionario_PersonaComboBox.Text = "";
                                                                        this.direccion_ImagenTextBox.Text = "";
                                                                        this.ficha_PersonaTextBox.Text = "";
                                                                        this.photo_PersonaPictureBox.Image = null;
                                                                    }
                                                                    //}
                                                                    //else
                                                                    //{
                                                                    //    MessageBox.Show("Este código ya existe", "Notificación");
                                                                    //}
                                                                    else
                                                                    {
                                                                        MessageBox.Show("Ya existe una persona con esta cédula");
                                                                        int idPersona = int.Parse(data.Rows[0][0].ToString());

                                                                    }
                                                                }

                                                            }

                                                        }
                                                        catch (Exception e1)
                                                        {
                                                            MessageBox.Show("No se puede guardar el registro en la base de datos" + e1.ToString(), "Error");
                                                            this.TxtnoDedo.Focus();

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
            {
                {
                    if (MessageBox.Show("¿Desea cancelar el proceso?", "Notificación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        this.cedula_PersonaTextBox.Text = "";
                        this.nombre_PersonaTextBox.Text = "";
                        this.apellido_PersonaTextBox.Text = "";
                        this.correo_PersonaTextBox.Text = "";
                        this.celular_PersonaTextBox.Text = "";
                        this.funcionario_PersonaComboBox.Text = "";
                        this.direccion_ImagenTextBox.Text = "";
                        this.ficha_PersonaTextBox.Text = "";
                        this.photo_PersonaPictureBox.Image = null;
                        this.Close();

                        Personas a = new Personas();
                        a.Show();
                        this.Hide();
                    }
                }
            }

        }

        private void funcionario_PersonaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void funcionario_PersonaComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
