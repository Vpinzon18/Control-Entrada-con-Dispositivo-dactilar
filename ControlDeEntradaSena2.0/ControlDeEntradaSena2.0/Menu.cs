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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuarios S = new Usuarios();
            S.Show();
            this.Hide();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
            Login a= new Login();
            a.Show();
            this.Hide();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Personas a = new Personas();
            a.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ControlEntradaSalida a = new ControlEntradaSalida();
            a.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            {
                Usuarios S = new Usuarios();
                S.Show();
                this.Hide();

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            {
                Personas a = new Personas();
                a.Show();
                this.Hide();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            {
                ControlEntradaSalida a = new ControlEntradaSalida();
                a.Show();
                this.Hide();

            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Reportes a = new Reportes();
            a.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Acerca_de m = new Acerca_de();
            m.Show();
            this.Hide();
        }
    }
}
