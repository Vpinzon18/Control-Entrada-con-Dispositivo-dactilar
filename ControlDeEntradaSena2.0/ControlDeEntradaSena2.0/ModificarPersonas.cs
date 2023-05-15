using ControlDeEntradaSena2._0.CpDato;
using ControlDeEntradaSena2._0.CpValidation;
using DPFP;
using DPFP.Gui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDeEntradaSena2._0
{
    public partial class ModificarPersonas : Form
    {
        public ModificarPersonas()
        {
            InitializeComponent();
            Data = new AppData();
        }
        public Byte[] arrayImagenUser;
        public AppData Data;
        public int i;

        private void pERSONASBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pERSONASBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistemadeAsistenciaDataSet);

        }

        private void Personas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemadeAsistenciaDataSet.PERSONAS' Puede moverla o quitarla según sea necesario.
            this.pERSONASTableAdapter.Fill(this.sistemadeAsistenciaDataSet.PERSONAS);

        }

        private void pERSONASDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            this.btncancelar2.Visible = false;
            this.BtnModificar.Visible = false;
            this.cedula_PersonaTextBox.Text = null;
            this.photo_PersonaPictureBox.Image = null;
            this.nombre_PersonaTextBox.Text = null;
            this.apellido_PersonaTextBox.Text = null;
            this.correo_PersonaTextBox.Text = null;
            this.celular_PersonaTextBox.Text = null;
            this.funcionario_PersonaComboBox.Text = null;
            this.ficha_PersonaTextBox.Text = null;
            this.cedula_PersonaTextBox.Focus();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {

        }
       

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Personas a = new Personas();
            a.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void BtnCancelaR_Click(object sender, EventArgs e)
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

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            {
                this.BtnModificar.Visible = true;
                this.btncancelar2.Visible = true;
            }

        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            {
                if (this.no_DedoTextBox.Text == "")
                {
                    MessageBox.Show("Ingrese el código de barras");
                }
                else
                {
                    if (this.nombre_PersonaTextBox.Text == "")
                    {
                        MessageBox.Show("Ingrese el nombre de la Persona");
                    }
                    else
                    {
                        if (this.apellido_PersonaTextBox.Text == "")
                        {
                            MessageBox.Show("Ingrese el apellido de la persona");
                        }
                        else
                        {
                            if (this.correo_PersonaTextBox.Text == "" || ValidarCorreo.ValidarCorreoe(this.correo_PersonaTextBox.Text) == false)
                            {
                                MessageBox.Show("Ingrese un correo válido");
                            }
                            else
                            {
                                if (this.celular_PersonaTextBox.Text == "")
                                {
                                    MessageBox.Show("Ingrese el teléfono de la persona");

                                }
                                else
                                {
                                    if (this.funcionario_PersonaComboBox.Text == "")
                                    {
                                        MessageBox.Show("Ingrese el rol del funcionario");
                                    }
                                    else
                                    {
                                        if (this.ficha_PersonaTextBox.Text == "")
                                        {
                                            MessageBox.Show("Ingrese la ficha");
                                        }
                                        else
                                        {
                                            if (this.direccion_ImagenTextBox.Text == "")
                                            {
                                                MessageBox.Show("Ingrese una imagen");
                                            }
                                            else
                                            {

                                                //ClsPersona clsPersona1 = new ClsPersona(arrayImagenUser, this.txtName.Text, this.txtLastName.Text, this.txtCorreo.Text, this.txtTelefono.Text, this.comboFuncionamiento.Text, this.txtFicha.Text, this.txtFile.Text, arrayImagenUser, int.Parse(this.txtCodigo.Text));

                                                CpDato.PersonasBD personasBD = new CpDato.PersonasBD();
                                                DataTable data = new DataTable();
                                                DataTable dataTable = new DataTable();
                                                data = personasBD.ValidarCodigoBD(int.Parse(this.no_DedoTextBox.Text));
                                                dataTable = personasBD.ValidarCedulaBD(this.cedula_PersonaTextBox.Text);

                                                if (dataTable.Rows.Count == 0 || this.id_PersonaTextBox.Text == (data.Rows[0][0].ToString()) || this.id_PersonaTextBox.Text == (dataTable.Rows[0][0].ToString()))
                                                {
                                                    personasBD.ModificarPersonaBD(int.Parse(this.id_PersonaTextBox.Text), arrayImagenUser, this.cedula_PersonaTextBox.Text, this.nombre_PersonaTextBox.Text, this.nombre_PersonaTextBox.Text, this.correo_PersonaTextBox.Text, this.celular_PersonaTextBox.Text, this.funcionario_PersonaComboBox.Text, this.ficha_PersonaTextBox.Text, this.direccion_ImagenTextBox.Text, arrayImagenUser, int.Parse(this.no_DedoTextBox.Text));

                                                    //Mensaje de Salida para que el usuario sepa que está agregado el Usuario 
                                                    MessageBox.Show("Persona Modificada", "Notiicación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    this.no_DedoTextBox.Text = "";
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
                                                else
                                                {
                                                    MessageBox.Show("Ya existe una persona con esta Cedula", ":(");
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

        //private void enrollmentcontrol1_oncancelenroll(object control,int fingermask, dpfp.template template, string readerserialnumber, ref dpfp.gui.eventhandlerstatus eventhandlerstatus)
        //{
        //    if (data.iseventhandlersucceeds)
        //    {
        //        limpiarhuella(this);
        //        data.templates[fingermask - 1] = template;
        //    }
        //    else
        //    {
        //        eventhandlerstatus = dpfp.gui.eventhandlerstatus.failure;
        //    }
        //}

        private static void LimpiarHuella(ModificarPersonas s)
        {
            for (int i = 0; i < 10; i++)
            {
                s.Data.Templates[i] = null;
            }
            s.no_DedoTextBox.Text = "0";
        }

        private void enrollmentControl1_Load(object sender, EventArgs e)
        {

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

        private void enrollmentControl1_OnStartEnroll(object Control, string ReaderSerialNumber, int Finger)
        {
            this.no_DedoTextBox.Text = Finger.ToString();
        }

        private void cedula_PersonaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nombre_PersonaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void apellido_PersonaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ficha_PersonaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void funcionario_PersonaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void photo_PersonaPictureBox_Click(object sender, EventArgs e)
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

        private void Btnmodificarb_Click(object sender, EventArgs e)
        {
            {
                if (this.no_DedoTextBox.Text == "")
                {
                    MessageBox.Show("Ingrese el código de barras");
                }
                else
                {
                    if (this.nombre_PersonaTextBox.Text == "")
                    {
                        MessageBox.Show("Ingrese el nombre de la Persona");
                    }
                    else
                    {
                        if (this.apellido_PersonaTextBox.Text == "")
                        {
                            MessageBox.Show("Ingrese el apellido de la persona");
                        }
                        else
                        {
                            if (this.correo_PersonaTextBox.Text == "" || ValidarCorreo.ValidarCorreoe(this.correo_PersonaTextBox.Text) == false)
                            {
                                MessageBox.Show("Ingrese un correo válido");
                            }
                            else
                            {
                                if (this.celular_PersonaTextBox.Text == "")
                                {
                                    MessageBox.Show("Ingrese el teléfono de la persona");

                                }
                                else
                                {
                                    if (this.funcionario_PersonaComboBox.Text == "")
                                    {
                                        MessageBox.Show("Ingrese el rol del funcionario");
                                    }
                                    else
                                    {
                                        if (this.ficha_PersonaTextBox.Text == "")
                                        {
                                            MessageBox.Show("Ingrese la ficha");
                                        }
                                        else
                                        {
                                            if (this.direccion_ImagenTextBox.Text == "")
                                            {
                                                MessageBox.Show("Ingrese una imagen");
                                            }
                                            else
                                            {

                                                //ClsPersona clsPersona1 = new ClsPersona(arrayImagenUser, this.txtName.Text, this.txtLastName.Text, this.txtCorreo.Text, this.txtTelefono.Text, this.comboFuncionamiento.Text, this.txtFicha.Text, this.txtFile.Text, arrayImagenUser, int.Parse(this.txtCodigo.Text));

                                                CpDato.PersonasBD personasBD = new CpDato.PersonasBD();
                                                DataTable data = new DataTable();
                                                DataTable dataTable = new DataTable();
                                                data = personasBD.ValidarCodigoBD(int.Parse(this.no_DedoTextBox.Text));
                                                dataTable = personasBD.ValidarCedulaBD(this.cedula_PersonaTextBox.Text);

                                                if (dataTable.Rows.Count == 0 || this.id_PersonaTextBox.Text == (data.Rows[0][0].ToString()) || this.id_PersonaTextBox.Text == (dataTable.Rows[0][0].ToString()))
                                                {
                                                    personasBD.ModificarPersonaBD(int.Parse(this.id_PersonaTextBox.Text), arrayImagenUser, this.cedula_PersonaTextBox.Text, this.nombre_PersonaTextBox.Text, this.apellido_PersonaTextBox.Text, this.correo_PersonaTextBox.Text, this.celular_PersonaTextBox.Text, this.funcionario_PersonaComboBox.Text, this.ficha_PersonaTextBox.Text, this.direccion_ImagenTextBox.Text, arrayImagenUser, int.Parse(this.no_DedoTextBox.Text));

                                                    //Mensaje de Salida para que el usuario sepa que está agregado el Usuario 
                                                    MessageBox.Show("Persona Modificada", "Notiicación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                    this.no_DedoTextBox.Text = "";
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
                                                else
                                                {
                                                    MessageBox.Show("Ya existe una persona con esta Cedula", ":(");
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

        private void bunifuThinButton23_Click(object sender, EventArgs e)
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

                    Personas a = new Personas();
                    a.Show();
                    this.Hide();

                }
            }
        }

        private void funcionario_PersonaComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}

