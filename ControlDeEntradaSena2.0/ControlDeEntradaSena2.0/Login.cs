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

namespace ControlDeEntradaSena2._0
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public string NUser;
        public string StateUser;
        public byte[] fotoUser;
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
       

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void BtnIngresar_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            {
                DataTable dt = new DataTable();
                UsuarioBD ValidarExistencia = new UsuarioBD();
                dt = ValidarExistencia.LoginBD(this.TxtCedula.Text, ValidarClave.GetSHA256(this.TxtPassword.Text));

                if (this.TxtCedula.Text == "" || this.TxtPassword.Text == "")
                {
                    MessageBox.Show("Ingrese Datos Solicitados", "Alerta :(");
                }
                else
                {
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Usuario NO registrado", ":(");
                    }
                    else
                    {
                        CsImagen csImagen = new CsImagen();
                        NUser = dt.Rows[0][0].ToString();
                        StateUser = dt.Rows[0][1].ToString();
                        fotoUser = (byte[])dt.Rows[0][2];
                        if (StateUser == "Activo")
                        {
                            MessageBox.Show("Bienvenido, Ten buen dia " + NUser, ":D");
                            Menu S = new Menu();
                            S.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Quien sos ?_?");
                        }

                    }
                }

            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
