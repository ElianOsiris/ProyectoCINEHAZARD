using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ENTIDAD;
using LOGICA;

namespace a
{
    public partial class Form1 : Form
    {
        private readonly LCine CineLog = new LCine();

        bool Cierre;
        //IniciarSecionEmpleado inic = new IniciarSecionEmpleado();
        public Form1(bool Cierre)
        {
            InitializeComponent();
            this.Cierre = Cierre;
            panel28.Visible = false;
            panel38.Visible= false;
            panel39.Visible = true;
            //rFunciones.BackColor = SystemColors.Window;
        }
        bool clickRegistros = false;
        bool clickCatalogos = false;
        bool clickCajas = false;
        bool clickVentas = false;
        private void salasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtPrincipal.Text = "Salas";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            panelCajas.Visible = false;
            panelCatalogo.Visible = false;
            panelVentas.Visible = false;
            if (clickRegistros == false)
            {
                panelRegistros.Visible = true;

            }
            else
            {
                panelRegistros.Visible = false;
            }
        }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {
            panelCajas.Visible = false;

            panelRegistros.Visible = false;
            panelVentas.Visible = false;

            if (clickCatalogos == false)
            {
                panelCatalogo.Visible = true;

            }
            else
            {
                panelCatalogo.Visible = false;
            }
        }

        private void btnCajas_Click(object sender, EventArgs e)
        {
            panelCatalogo.Visible = false;
            panelRegistros.Visible = false;
            panelVentas.Visible = false;

            if (clickCajas == false)
            {
                panelCajas.Visible = true;

            }
            else
            {
                panelCajas.Visible = false;
            }
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            panelCajas.Visible = false;
            panelCatalogo.Visible = false;
            panelRegistros.Visible = false;


            if (clickVentas == false)
            {
                panelVentas.Visible = true;

            }
            else
            {
                panelVentas.Visible = false;
            }
        }

        private void panelRegistros_VisibleChanged_1(object sender, EventArgs e)
        {
            if (panelRegistros.Visible == false)
            {
                clickRegistros = false;
            }
            else
            {
                clickRegistros = true;
            }
        }

        private void panelCatalogo_VisibleChanged_1(object sender, EventArgs e)
        {
            if (panelCatalogo.Visible == false)
            {
                clickCatalogos = false;
            }
            else
            {
                clickCatalogos = true;
            }
        }

        private void panelCajas_VisibleChanged_1(object sender, EventArgs e)
        {
            if (panelCajas.Visible == false)
            {
                clickCajas = false;
            }
            else
            {
                clickCajas = true;
            }
        }

        private void panelVentas_VisibleChanged_1(object sender, EventArgs e)
        {
            if (panelVentas.Visible == false)
            {
                clickVentas = false;
            }
            else
            {
                clickVentas = true;
            }
        }

        //Registros
        private void btnRSalas_Click(object sender, EventArgs e)
        {
            txtPrincipal.Text = "Registrar → Salas";
            CargarRegistro();
            Image imagen = Image.FromFile("Salas.png");
            pbDer.Image = imagen;
            pbDer.SizeMode = PictureBoxSizeMode.StretchImage;
            tabControl1.SelectedIndex = 0;
        }

        private void btnREmpleados_Click(object sender, EventArgs e)
        {
            txtPrincipal.Text = "Registrar → Empleados";
            CargarRegistro();
            Image imagen = Image.FromFile("Empleados.png");
            pbDer.Image = imagen;
            pbDer.SizeMode = PictureBoxSizeMode.StretchImage;
            tabControl1.SelectedIndex = 1;
        }

        private void btnRPeliculas_Click(object sender, EventArgs e)
        {
            txtPrincipal.Text = "Registrar → Peliculas";
            CargarRegistro();
            Image imagen = Image.FromFile("Pelicula.png");
            pbDer.Image = imagen;
            pbDer.SizeMode = PictureBoxSizeMode.StretchImage;
            tabControl1.SelectedIndex = 2;
        }

        private void btnRFunciones_Click(object sender, EventArgs e)
        {
            txtPrincipal.Text = "Registrar → Funciones";
            CargarRegistro();
            Image imagen = Image.FromFile("Funciones.png");
            pbDer.Image = imagen;
            pbDer.SizeMode = PictureBoxSizeMode.StretchImage;
            tabControl1.SelectedIndex = 3;
        }

        private void btnRCartelera_Click(object sender, EventArgs e)
        {
            txtPrincipal.Text = "Registrar → Cartelera";
            CargarRegistro();
            Image imagen = Image.FromFile("Cartelera.png");
            pbDer.Image = imagen;
            pbDer.SizeMode = PictureBoxSizeMode.StretchImage;
            tabControl1.SelectedIndex = 4;
        }
        private void btnRClasificacion_Click(object sender, EventArgs e)
        {
            txtPrincipal.Text = "Registrar → Clasificacion";
            CargarRegistro();
            //Falta cargar una imagen propia para esto
            //Image imagen = Image.FromFile("Cartelera.png");
            //pbDer.Image = imagen;
            pbDer.SizeMode = PictureBoxSizeMode.StretchImage;
            tabControl1.SelectedIndex = 5;
        }
        private void btnRGenero_Click(object sender, EventArgs e)
        {
            txtPrincipal.Text = "Registrar → Genero";
            CargarRegistro();
            //Falta cargar una imagen propia para esto
            //Image imagen = Image.FromFile("Cartelera.png");
            //pbDer.Image = imagen;
            //pbDer.SizeMode = PictureBoxSizeMode.StretchImage;
            tabControl1.SelectedIndex = 6;
        }
        public void CargarRegistro()
        {
            panelRegistros.Visible = false;
            Image imagen = Image.FromFile("Registros.png");
            pbIqz.Image = imagen;
            pbIqz.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        //Catalogo
        private void btnCSalas_Click(object sender, EventArgs e)
        {
            txtPrincipal.Text = "Catálogo → Salas";
            CargarCatalogo();
            Image imagen = Image.FromFile("Sketch002.tif");
            pbDer.Image = imagen;
            pbDer.SizeMode = PictureBoxSizeMode.StretchImage;
            tabControl1.SelectedIndex = 7;
        }

        private void btnCEmpleados_Click(object sender, EventArgs e)
        {
            txtPrincipal.Text = "Catálogo → Empleados";
            CargarCatalogo();
            Image imagen = Image.FromFile("Sketch001.tif");
            pbDer.Image = imagen;
            pbDer.SizeMode = PictureBoxSizeMode.StretchImage;
            tabControl1.SelectedIndex = 8;
        }

        private void btnCPeliculas_Click(object sender, EventArgs e)
        {
            txtPrincipal.Text = "Catálogo → Peliculas";
            CargarCatalogo();
            Image imagen = Image.FromFile("Sketch003.tif");
            pbDer.Image = imagen;
            pbDer.SizeMode = PictureBoxSizeMode.StretchImage;
            tabControl1.SelectedIndex = 9;
        }

        private void btnCFunciones_Click(object sender, EventArgs e)
        {
            txtPrincipal.Text = "Catálogo → Funciones";
            CargarCatalogo();
            Image imagen = Image.FromFile("Sketch004.tif");
            pbDer.Image = imagen;
            pbDer.SizeMode = PictureBoxSizeMode.StretchImage;
            tabControl1.SelectedIndex = 10;
        }

        private void btnCCartelera_Click(object sender, EventArgs e)
        {
            txtPrincipal.Text = "Catálogo → Cartelera";
            CargarCatalogo();
            Image imagen = Image.FromFile("Sketch005.tif");
            pbDer.Image = imagen;
            pbDer.SizeMode = PictureBoxSizeMode.StretchImage;
            tabControl1.SelectedIndex = 11;
        }
        private void button122_Click(object sender, EventArgs e)
        {
            txtPrincipal.Text = "Catálogo → Clasificacion";
            CargarCatalogo();
            //Falta cargar una imagen propia para esto
            //Image imagen = Image.FromFile("Cartelera.png");
            //pbDer.Image = imagen;
            //pbDer.SizeMode = PictureBoxSizeMode.StretchImage;
            tabControl1.SelectedIndex = 12;
        }
        private void button112_Click(object sender, EventArgs e)
        {
            txtPrincipal.Text = "Catálogo → Clasificacion";
            CargarCatalogo();
            //Falta cargar una imagen propia para esto
            //Image imagen = Image.FromFile("Cartelera.png");
            //pbDer.Image = imagen;
            //pbDer.SizeMode = PictureBoxSizeMode.StretchImage;
            tabControl1.SelectedIndex = 13;
        }
        public void CargarCatalogo()
        {
            panelCatalogo.Visible = false;
            Image imagen = Image.FromFile("Catalogo.png");
            pbIqz.Image = imagen;
            pbIqz.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        //Cajas
        private void btnAperturaCaja_Click(object sender, EventArgs e)
        {
            txtPrincipal.Text = "Cajas → Apertura de caja";
            CargarCajas();
            Image imagen = Image.FromFile("Sketch008.tif");
            pbDer.Image = imagen;
            pbDer.SizeMode = PictureBoxSizeMode.StretchImage;
            tabControl1.SelectedIndex = 14;
        }

        private void btnCierreCaja_Click(object sender, EventArgs e)
        {
            txtPrincipal.Text = "Cajas → Cierre de caja";
            CargarCajas();
            Image imagen = Image.FromFile("Sketch009.tif");
            pbDer.Image = imagen;
            pbDer.SizeMode = PictureBoxSizeMode.StretchImage;
            tabControl1.SelectedIndex = 15;
        }
        public void CargarCajas()
        {
            panelCajas.Visible = false;
            Image imagen = Image.FromFile("Cajas2.png");
            pbIqz.Image = imagen;
            pbIqz.SizeMode = PictureBoxSizeMode.StretchImage;
        }


        //Ventas
        private void btnVenterBoletos_Click(object sender, EventArgs e)
        {
            txtPrincipal.Text = "Ventas → Vender boletos";
            CargarVentas();
            Image imagen = Image.FromFile("Sketch006.tif");
            pbDer.Image = imagen;
            pbDer.SizeMode = PictureBoxSizeMode.StretchImage;
            tabControl1.SelectedIndex = 16;
        }

        private void btnCatalogoVentas_Click(object sender, EventArgs e)
        {
            txtPrincipal.Text = "Ventas → Catalogo de ventas";
            CargarVentas();
            Image imagen = Image.FromFile("Sketch007.tif");
            pbDer.Image = imagen;
            pbDer.SizeMode = PictureBoxSizeMode.StretchImage;
            tabControl1.SelectedIndex = 17;
        }
        public void CargarVentas()
        {
            panelVentas.Visible = false;
            Image imagen = Image.FromFile("Ventas2.png");
            pbIqz.Image = imagen;
            pbIqz.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void panel22_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel26_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label92_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //tabControl1.SelectedIndex = 12;
            if (Cierre)
            {
                tabControl1.SelectedIndex = 18;
            }
            dataGridView10.Rows.Add("AS74583", "jshadkjv", "sjdvj", "ufjdfh", "74755", "HOLA");
            dataGridView10.Rows.Add("JF8485", "FD ", "SV", "RW", "DF", "HOLA2");
            dataGridView10.Rows.Add("CNDN2757", "DS", " X", "UI", "GH", "HOLA3");

            object imagen1 = Image.FromFile(@"C:\Users\jjuli\OneDrive\Documentos\6 SEMESTRE\4.- INGENIERÍA DE SOFTWARE\U2.- Diseño\Imagenes\Avatar2.jpg");
            object imagen2 = Image.FromFile(@"C:\Users\jjuli\OneDrive\Documentos\6 SEMESTRE\4.- INGENIERÍA DE SOFTWARE\U2.- Diseño\Imagenes\Cars3.jpg");
            dataGridView7.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView7.Rows.Add(imagen1, "AVATAR 2", "B", "120 MINUTOS", 1, "LUNES 27 DE FEBRERO DEL 2023");
            dataGridView7.Rows.Add(imagen2, "CARS 3", "AA", "90 MINUTOS", "3", "LUNES 27 DE FEBRERO");


        }

        private void label138_Click(object sender, EventArgs e)
        {

        }

        private void label142_Click(object sender, EventArgs e)
        {

        }

        private void jjTextBox22__TextChanged(object sender, EventArgs e)
        {

        }

        private void label114_Click(object sender, EventArgs e)
        {

        }

        private void cEmpleados_Click(object sender, EventArgs e)
        {

        }

        private void panel20_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label132_Click(object sender, EventArgs e)
        {

        }

        private void button31_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 13;
            tabControl2.SelectedIndex = 1;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button33_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 13;
            tabControl2.SelectedIndex = 0;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 13;
            tabControl2.SelectedIndex = 2;
        }

        private void button82_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 13;
            tabControl2.SelectedIndex = 3;
        }

        private void button81_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 13;
            tabControl2.SelectedIndex = 1;
        }

        private void button85_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 13;
            tabControl2.SelectedIndex = 2;
        }

        private void button86_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 12;
            tabControl2.SelectedIndex = 4;
        }

        private void button84_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 13;
            tabControl2.SelectedIndex = 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 13;
            tabControl2.SelectedIndex = 4;
        }

        private void button83_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 13;
            tabControl2.SelectedIndex = 3;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 13;
            tabControl2.SelectedIndex = 1;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditarCatalogoSalas_Click(object sender, EventArgs e)
        {
            panel28.Visible = true;
        }

        private void btnEliminarCatalogoSalas_Click(object sender, EventArgs e)
        {
            panel38.Visible = true;
        }

        private void dataGridView10_CurrentCellChanged(object sender, EventArgs e)
        {
            int renglon = dataGridView10.CurrentRow.Index;
            panel28.Visible = true;
            jjTextBox25.Texts = dataGridView10[0, renglon].Value.ToString();
            jjTextBox26.Texts = dataGridView10[1, renglon].Value.ToString();
            jjTextBox27.Texts = dataGridView10[2, renglon].Value.ToString();
            jjTextBox29.Texts = dataGridView10[3, renglon].Value.ToString();
            jjTextBox28.Texts = dataGridView10[4, renglon].Value.ToString();
            jjTextBox70.Texts = dataGridView10[5, renglon].Value.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 formtres = new Form3();
            formtres.ShowDialog();
        }

        private void dataGridView7_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7 && e.RowIndex == 0)
            {
                
                tabControl2.SelectedIndex = 1;
                pictureBox30.Image = Image.FromFile(@"C:\Users\jjuli\OneDrive\Documentos\6 SEMESTRE\4.- INGENIERÍA DE SOFTWARE\U2.- Diseño\Imagenes\Avatar2.jpg");
                label202.Text = string.Format("Titulo: Avatar 2");
                label201.Text = string.Format("Calasificación: B");
                label200.Text = string.Format("Duración: 120 minutos");
                pictureBox31.Image = Image.FromFile(@"C:\Users\jjuli\OneDrive\Documentos\6 SEMESTRE\4.- INGENIERÍA DE SOFTWARE\U2.- Diseño\Imagenes\Avatar2.jpg");
                label217.Text = string.Format("Titulo: Avatar 2");
                label216.Text = string.Format("Calasificación: B");
                label215.Text = string.Format("Duración: 120 minutos");
            }
            if (e.ColumnIndex == 7 && e.RowIndex == 1)
            {
                tabControl2.SelectedIndex = 1;
                pictureBox30.Image = Image.FromFile(@"C:\Users\jjuli\OneDrive\Documentos\6 SEMESTRE\4.- INGENIERÍA DE SOFTWARE\U2.- Diseño\Imagenes\Cars3.jpg");
                label202.Text = string.Format("Titulo: Cars 3");
                label201.Text = string.Format("Calasificación: AA");
                label200.Text = string.Format("Duración: 90 minutos");
                pictureBox31.Image = Image.FromFile(@"C:\Users\jjuli\OneDrive\Documentos\6 SEMESTRE\4.- INGENIERÍA DE SOFTWARE\U2.- Diseño\Imagenes\Cars3.jpg");
                label217.Text = string.Format("Titulo: Cars 3");
                label216.Text = string.Format("Calasificación: AA");
                label215.Text = string.Format("Duración: 90 minutos");
            }
        }

        private void button31_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 13;
            tabControl2.SelectedIndex = 2;
        }

        private void button79_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 13;
            tabControl2.SelectedIndex = 3;
        }

        private void button86_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 13;
            tabControl2.SelectedIndex = 4;
        }

        private void button82_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 13;
            tabControl2.SelectedIndex = 5;
        }

        private void button87_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 13;
            tabControl2.SelectedIndex = 0;
        }

        private void panel39_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button136_Click(object sender, EventArgs e)
        {
            string tipoSala = null;
            if (comboBoxx1.Texts == "NORMAL")
            {
                tipoSala = "NORMAL";
            }
            if (comboBoxx1.Texts == "IMAX")
            {
                tipoSala = "IMAX";
            }
            Sala sala = null;
            try
            {
                sala = new Sala
                {
                    IDSALA = jjTextBox131.Texts,
                    NOMBRE_SALA = jjTextBox16.Texts,
                    TIPO_SALA = tipoSala,
                    NO_ASIENTOS = Convert.ToInt32(jjTextBox14.Texts),
                    SILLA_DE_RUEDAS = jjTextBox15.Texts,
                    ID_EMPLEADO = jjTextBox126.Texts
                };
                CineLog.RegistrarSala(sala);
                if (CineLog.Mensaje.Length != 0)
                {
                    //Hubo un error
                    MessageBox.Show(CineLog.Mensaje.ToString(), "Mensaje de Error");
                }
                else
                {
                    MessageBox.Show("Preoducto guardado exitosamente en la B.D");
                    LimpiarRSala();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Error {0}", ex.Message, "Error inesperado "));
            }
        }
        public void LimpiarRSala()
        {
            jjTextBox131.Texts = " ";
            jjTextBox16.Texts = " ";
            comboBoxx1.Texts = " ";
            jjTextBox14.Texts = " ";
            jjTextBox15.Texts = " ";
            jjTextBox126.Texts = " ";
        }

        private void button175_Click(object sender, EventArgs e)
        {
        }

        private void button94_Click(object sender, EventArgs e)
        {
            Trabajador Traba = null;
            try
            {
                Traba = new Trabajador
                {
                    ID_EMPLEADO = jjTextBox1.Texts,
                    TIPO_EMPLEADO = jjTextBox6.Texts,
                    NOMBRE_EMPLEADO = jjTextBox11.Texts,
                    AP_PATERNO = jjTextBox2.Texts,
                    AP_MATERNO = jjTextBox10.Texts,
                    FECHA_NAC = Convert.ToDateTime(jjTextBox127.Texts),
                    EDAD = Convert.ToInt32(jjTextBox128.Texts),
                    GENERO = jjTextBox129.Texts,
                    TELEFONO = jjTextBox3.Texts,
                    CORREO_ELECTRONICO = jjTextBox4.Texts,
                    DIRECCION = jjTextBox9.Texts,
                    CODIGO_POSTAL = Convert.ToInt32(jjTextBox8.Texts),
                    NOMBRE_USUARIO = jjTextBox5.Texts,
                    CONTRASENA = jjTextBox7.Texts,
                };
                CineLog.RegistrarTrabajador(Traba);
                if (CineLog.Mensaje.Length != 0)
                {
                    //Hubo un error
                    MessageBox.Show(CineLog.Mensaje.ToString(), "Mensaje de Error");
                }
                else
                {
                    MessageBox.Show("Preoducto guardado exitosamente en la B.D");
                    LimpiarRSala();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Error {0}", ex.Message, "Error inesperado "));
            }
        }
        public void LimpiarRTrabajador()
        {
            jjTextBox1.Texts = " ";
            jjTextBox6.Texts = " ";
            jjTextBox11.Texts = " ";
            jjTextBox2.Texts = " ";
            jjTextBox10.Texts = " ";
            jjTextBox127.Texts = " ";
            jjTextBox128.Texts = " ";
            jjTextBox129.Texts = " ";
            jjTextBox3.Texts = " ";
            jjTextBox4.Texts = " ";
            jjTextBox9.Texts = " ";
            jjTextBox8.Texts = " ";
            jjTextBox5.Texts = " ";
            jjTextBox7.Texts = " ";

        }
    }
}
