using ControlDeEntradaSena2._0.CpDato;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;


namespace ControlDeEntradaSena2._0
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Menu a = new Menu();
            a.Show();
            this.Hide();
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            DataTable re = new DataTable();
            ReportesBD reportesBD = new ReportesBD();
            re = reportesBD.LlenarDatosaBD();
            DGVreportes.DataSource = re;

            DGVreportes.Columns[0].Visible = false;
            DGVreportes.Columns[1].Visible = false;
            DGVreportes.Columns[5].Visible = false;
            DGVreportes.Columns[6].Visible = false;
            DGVreportes.Columns[7].Visible = false;
            DGVreportes.Columns[8].Visible = false;
            DGVreportes.Columns[9].Visible = false;
            DGVreportes.Columns[10].Visible = false;
            DGVreportes.Columns[11].Visible = false;
            DGVreportes.Columns[12].Visible = false;
            DGVreportes.Columns[13].Visible = false;
            DGVreportes.Columns[14].Visible = false;


            DGVreportes.Columns[2].HeaderText = "Documento";
            DGVreportes.Columns[3].HeaderText = "Nombre";
            DGVreportes.Columns[4].HeaderText = "Apellido";
            DGVreportes.Columns[15].HeaderText = "Hora De Entrada";
            DGVreportes.Columns[16].HeaderText = "Hora De Salida";



        }
        

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            Menu a = new Menu();
            a.Show();
            this.Hide();
        }

        private void Btnmodificarb_Click(object sender, EventArgs e)
        {
            SaveFileDialog Guardar = new SaveFileDialog();
            Guardar.FileName = "ReporteAsistencia" + DateTime.Now.ToString("ddMMyyyyHHmmss"); 
           

            string paginahtml_texto = Properties.Resources.Plantilla_html.ToString();
            paginahtml_texto = paginahtml_texto.Replace("@Adminstrador", txtNombre.Text);
            paginahtml_texto = paginahtml_texto.Replace("@Documento", txtDocumento.Text);
            paginahtml_texto = paginahtml_texto.Replace("@fecha", DateTime.Now.ToString("dd/MM/yyyy"));

            string filas = string.Empty;
            foreach (DataGridViewRow row in DGVreportes.Rows)

            {
                
                filas += "<tr>";
                filas += "<td>" + row.Cells["Cedula_Persona"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Nombre_Persona"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Apellido_Persona"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Fecha_Entrada"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Fecha_Salida"].Value.ToString() + "</td>";
                filas += "</tr>";
            }
            paginahtml_texto = paginahtml_texto.Replace("@FILAS", filas);


            if (Guardar.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(Guardar.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);

                    pdfDoc.Open();

                    pdfDoc.Add(new Phrase(""));

                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.logo_sena_verde_complementario_png_2022, System.Drawing.Imaging.ImageFormat.Png);
                    img.ScaleToFit(80, 60);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;
                    img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 40);
                    pdfDoc.Add(img);

                    using (StringReader sr = new StringReader(paginahtml_texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();

                    stream.Close();
                }

                MessageBox.Show("Se ha generado el reporte exitosamente");
                
                    
            }
        }

        private void DGVreportes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
