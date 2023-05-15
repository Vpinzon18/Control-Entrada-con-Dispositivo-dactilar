using ControlDeEntradaSena2._0.CpDato;
using ControlDeEntradaSena2._0.CpValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace ControlDeEntradaSena2._0
{
    public partial class Personas : Form
    {
        public Personas()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
           
            Menu a = new Menu();
            a.Show();
            this.Hide();
            this.Close();
        }

        private void pERSONASBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pERSONASBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sistemadeAsistenciaDataSet);

        }

        private void Personas_Load(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            PersonasBD clsPersona = new PersonasBD();
            dt = clsPersona.LlenarDatosBD();
            PersonasDGV.DataSource = dt;

            PersonasDGV.Columns[0].Visible = false;
            PersonasDGV.Columns[1].Visible = false;
            PersonasDGV.Columns[5].Visible = false;
            PersonasDGV.Columns[6].Visible = false;
            PersonasDGV.Columns[8].Visible = false;
            PersonasDGV.Columns[9].Visible = false;
            PersonasDGV.Columns[10].Visible = false;


            PersonasDGV.Columns[2].HeaderText = "Cédula";
            PersonasDGV.Columns[3].HeaderText = "Nombre";
            PersonasDGV.Columns[4].HeaderText = "Apellido";
            PersonasDGV.Columns[7].HeaderText = "Funcionario";
            PersonasDGV.Columns[11].HeaderText = "Código de Barras";

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            AgregarPersonas agregarPersona = new AgregarPersonas();
            agregarPersona.Show();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            CsImagen imagen = new CsImagen();

            ModificarPersonas modificarPersonas = new ModificarPersonas();

            if (PersonasDGV.Rows.Count != 0)
            {
                modificarPersonas.id_PersonaTextBox.Text = PersonasDGV.CurrentRow.Cells[0].Value.ToString();
                modificarPersonas.cedula_PersonaTextBox.Text = PersonasDGV.CurrentRow.Cells[2].Value.ToString();
                modificarPersonas.nombre_PersonaTextBox.Text = PersonasDGV.CurrentRow.Cells[3].Value.ToString();
                modificarPersonas.apellido_PersonaTextBox.Text = PersonasDGV.CurrentRow.Cells[4].Value.ToString();
                modificarPersonas.correo_PersonaTextBox.Text = PersonasDGV.CurrentRow.Cells[5].Value.ToString();
                modificarPersonas.celular_PersonaTextBox.Text = PersonasDGV.CurrentRow.Cells[6].Value.ToString();
                modificarPersonas.funcionario_PersonaComboBox.Text = PersonasDGV.CurrentRow.Cells[7].Value.ToString();
                modificarPersonas.ficha_PersonaTextBox.Text = PersonasDGV.CurrentRow.Cells[8].Value.ToString();
                modificarPersonas.direccion_ImagenTextBox1.Text = PersonasDGV.CurrentRow.Cells[9].Value.ToString();
                byte[] photoPerson = (byte[])PersonasDGV.CurrentRow.Cells[10].Value;
                modificarPersonas.no_DedoTextBox.Text = PersonasDGV.CurrentRow.Cells[11].Value.ToString();

                Image imagePerson = imagen.byteArrayToImage(photoPerson);
                modificarPersonas.photo_PersonaPictureBox.Image = imagePerson;
                modificarPersonas.arrayImagenUser = photoPerson;
                modificarPersonas.Show();

            }
        
            else
            {
                MessageBox.Show("Elija el dato que va a modificar","Notificación");
            }
}

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            AgregarPersonas agregarPersona = new AgregarPersonas();
            agregarPersona.Show();
            this.Hide();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            
            {
                CsImagen imagen = new CsImagen();

                ModificarPersonas modificarPersonas = new ModificarPersonas();
                modificarPersonas.Show();
                this.Hide();

                if (PersonasDGV.Rows.Count != 0)
                {
                    modificarPersonas.id_PersonaTextBox.Text = PersonasDGV.CurrentRow.Cells[0].Value.ToString();
                    modificarPersonas.cedula_PersonaTextBox.Text = PersonasDGV.CurrentRow.Cells[2].Value.ToString();
                    modificarPersonas.nombre_PersonaTextBox.Text = PersonasDGV.CurrentRow.Cells[3].Value.ToString();
                    modificarPersonas.apellido_PersonaTextBox.Text = PersonasDGV.CurrentRow.Cells[4].Value.ToString();
                    modificarPersonas.correo_PersonaTextBox.Text = PersonasDGV.CurrentRow.Cells[5].Value.ToString();
                    modificarPersonas.celular_PersonaTextBox.Text = PersonasDGV.CurrentRow.Cells[6].Value.ToString();
                    modificarPersonas.funcionario_PersonaComboBox.Text = PersonasDGV.CurrentRow.Cells[7].Value.ToString();
                    modificarPersonas.ficha_PersonaTextBox.Text = PersonasDGV.CurrentRow.Cells[8].Value.ToString();
                    modificarPersonas.direccion_ImagenTextBox1.Text = PersonasDGV.CurrentRow.Cells[9].Value.ToString();
                    byte[] photoPerson = (byte[])PersonasDGV.CurrentRow.Cells[10].Value;
                    modificarPersonas.no_DedoTextBox.Text = PersonasDGV.CurrentRow.Cells[11].Value.ToString();

                    Image imagePerson = imagen.byteArrayToImage(photoPerson);
                    modificarPersonas.photo_PersonaPictureBox.Image = imagePerson;
                    modificarPersonas.arrayImagenUser = photoPerson;
                    modificarPersonas.Show();

                }

                else
                {
                    MessageBox.Show("Tienes que elegir a una persona para modificarla", ":(");
                }
            }

        }
    }
}
