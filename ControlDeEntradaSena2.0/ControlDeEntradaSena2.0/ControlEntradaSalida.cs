using ControlDeEntradaSena2._0.CpDato;
using ControlDeEntradaSena2._0.CpValidation;
using DPFP;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ControlDeEntradaSena2._0
{
    public partial class ControlEntradaSalida : Form
    {
        public ControlEntradaSalida()
        {
            InitializeComponent();
            Data = new AppData();
            Timer timer = new Timer();
            timer.Interval = 500; // Intervalo de tiempo en milisegundos
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
        }
        private AppData Data;
        string cedula = string.Empty;
        byte[] huella;
        byte[] photoPerson;
        int idPersona;
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (labelEstado.Visible == true)
            {
                labelEstado.Visible = false;
            }
            else
            {
                labelEstado.Visible = true;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ModificarPersonas personas = new ModificarPersonas();
            CpDato.PersonasBD personasBD = new CpDato.PersonasBD();
            CpValidation.CsImagen csImagen = new CpValidation.CsImagen();

            if (this.cedula_PersonaTextBox.Text == "")
            {
                MessageBox.Show("Ingrese una cedula", ":(");
            }
            else
            {
                DataTable datacontrol = personasBD.TraerPersonaCedulaBD(this.cedula_PersonaTextBox.Text);
                if (datacontrol.Rows.Count != 0)
                {
                    idPersona = (int)datacontrol.Rows[0][0];

                    this.nombre_PersonaTextBox.Text = datacontrol.Rows[0][1].ToString();
                    this.apellido_PersonaTextBox.Text = datacontrol.Rows[0][2].ToString();
                    this.funcionario_PersonaComboBox.Text = datacontrol.Rows[0][3].ToString();
                    this.ficha_PersonaTextBox.Text = datacontrol.Rows[0][4].ToString();
                    photoPerson = (byte[])datacontrol.Rows[0][5];
                    huella = (byte[])datacontrol.Rows[0][6];

                    CsImagen imagen = new CsImagen();

                    this.photo_PersonaPictureBox.Image = imagen.byteArrayToImage(photoPerson);

                    personasBD.EntradaPersonaBD(idPersona);

                    DataTable dataEstado = personasBD.TraerEstadoAsistenciaBD(idPersona);
                    int estadoPersona = (int)dataEstado.Rows[0][0];
                    if (estadoPersona == 1)
                    {
                        this.labelEstado.ForeColor = Color.FromArgb(143, 199, 62);
                        this.labelEstado.Text = "Usted está saliendo";
                    }
                    else
                    {
                        this.labelEstado.ForeColor = Color.FromArgb(143, 199, 62);

                        this.labelEstado.Text = "Usted está entrando";
                    }
                }
                else
                {
                    this.labelEstado.ForeColor = Color.Red;
                    this.labelEstado.Text = "Usted no está en la base de datos";
                }
            }
            }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu a = new Menu();
            a.Show();
        }

        private void verificationControl1_Load(object sender, EventArgs e)
        {

        }

        private void verificationControl1_OnComplete(object Control, FeatureSet FeatureSet, ref DPFP.Gui.EventHandlerStatus EventHandlerStatus)
        {
            {
                DPFP.Verification.Verification ver = new DPFP.Verification.Verification();
                DPFP.Verification.Verification.Result res = new DPFP.Verification.Verification.Result();
                ClsConexion conexion = new ClsConexion();
                SqlCommand command = new SqlCommand("SELECT Cedula_Persona,Huella_Persona FROM PERSONAS", conexion.Conectar());
                SqlDataReader reader = command.ExecuteReader();
                cedula = string.Empty;

                while (reader.Read())
                {
                    byte[] Huella = (byte[])reader["Huella_Persona"];
                    cedula = reader["Cedula_Persona"].ToString();
                    MemoryStream memoryStream = new MemoryStream(Huella);
                    DPFP.Template tmpObj = new DPFP.Template();

                    tmpObj.DeSerialize(memoryStream);
                    if (tmpObj != null)
                    {
                        ver.Verify(FeatureSet, tmpObj, ref res);
                        Data.IsFeatureSetMatched = res.Verified;
                        Data.FalseAcceptRate = res.FARAchieved;
                        if (res.Verified)
                        {
                            this.cedula_PersonaTextBox.Text = cedula;


                            CpDato.PersonasBD clspersona= new CpDato.PersonasBD();
                            DataTable dataControl = clspersona.TraerPersonaCedulaBD(this.cedula_PersonaTextBox.Text);
                            idPersona = (int)dataControl.Rows[0][0];

                            this.nombre_PersonaTextBox.Text = dataControl.Rows[0][1].ToString();
                            this.apellido_PersonaTextBox.Text = dataControl.Rows[0][2].ToString();
                            this.funcionario_PersonaComboBox.Text = dataControl.Rows[0][3].ToString();
                            this.ficha_PersonaTextBox.Text = dataControl.Rows[0][4].ToString();
                            photoPerson = (byte[])dataControl.Rows[0][5];
                            huella = (byte[])dataControl.Rows[0][6];
                            CsImagen image = new CsImagen();

                            this.photo_PersonaPictureBox.Image = image.byteArrayToImage(photoPerson);
                            //clsPersona.EntradaPersona_db(idPersona);

                            clspersona.EntradaPersonaBD(idPersona);



                            DataTable dataEstado = clspersona.TraerEstadoAsistenciaBD(idPersona);

                            //Funciona, solo es encontrar la manera de que actualice apenas se haya ejecutado el procedimiento almacenado
                            int estadoPerson = (int)dataEstado.Rows[0][0];
                            if (estadoPerson == 1)
                            {
                                this.labelEstado.ForeColor = Color.FromArgb(143, 199, 62);
                                this.labelEstado.Text = "Usted está saliendo";
                            }
                            else
                            {
                                this.labelEstado.ForeColor = Color.FromArgb(143, 199, 62);
                                this.labelEstado.Text = "Usted está entrando";
                            }
                            break;
                        }
                    }
                }


                if (!res.Verified)
                {
                    EventHandlerStatus = DPFP.Gui.EventHandlerStatus.Failure;
                    this.labelEstado.ForeColor = Color.Red;
                    this.labelEstado.Text = "Usted no está en la base de datos";



                }
            }

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            {
                ModificarPersonas personas = new ModificarPersonas();
                CpDato.PersonasBD personasBD = new CpDato.PersonasBD();
                CpValidation.CsImagen csImagen = new CpValidation.CsImagen();

                if (this.cedula_PersonaTextBox.Text == "")
                {
                    MessageBox.Show("Ingrese una cedula", ":(");
                }
                else
                {
                    DataTable datacontrol = personasBD.TraerPersonaCedulaBD(this.cedula_PersonaTextBox.Text);
                    if (datacontrol.Rows.Count != 0)
                    {
                        idPersona = (int)datacontrol.Rows[0][0];

                        this.nombre_PersonaTextBox.Text = datacontrol.Rows[0][1].ToString();
                        this.apellido_PersonaTextBox.Text = datacontrol.Rows[0][2].ToString();
                        this.funcionario_PersonaComboBox.Text = datacontrol.Rows[0][3].ToString();
                        this.ficha_PersonaTextBox.Text = datacontrol.Rows[0][4].ToString();
                        photoPerson = (byte[])datacontrol.Rows[0][5];
                        huella = (byte[])datacontrol.Rows[0][6];

                        CsImagen imagen = new CsImagen();

                        this.photo_PersonaPictureBox.Image = imagen.byteArrayToImage(photoPerson);

                        personasBD.EntradaPersonaBD(idPersona);

                        DataTable dataEstado = personasBD.TraerEstadoAsistenciaBD(idPersona);
                        int estadoPersona = (int)dataEstado.Rows[0][0];
                        if (estadoPersona == 1)
                        {
                            this.labelEstado.ForeColor = Color.FromArgb(143, 199, 62);
                            this.labelEstado.Text = "Usted está entrando";
                        }
                        else
                        {
                            this.labelEstado.ForeColor = Color.FromArgb(143, 199, 62);

                            this.labelEstado.Text = "Usted está saliendo";
                        }
                    }
                    else
                    {
                        this.labelEstado.ForeColor = Color.Red;
                        this.labelEstado.Text = "Usted no está en la base de datos";
                    }
                }
            }
        }

        private void labelEstado_Click(object sender, EventArgs e)
        {

        }
    }
}



