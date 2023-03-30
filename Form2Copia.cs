using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace a
{
    public partial class Form2Copia : Form
    {
        bool Cierre2;
        public Form2Copia(bool Cierre2)
        {
            InitializeComponent();
            this.Cierre2 = Cierre2;
        }

        private void btnSiguiente1_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedIndex = 1;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedIndex = 2;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedIndex = 3;
        }

        private void button86_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedIndex = 4;
        }

        private void button56_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedIndex = 5;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedIndex = 0;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedIndex = 1;
        }

        private void button85_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedIndex = 2;
        }

        private void button55_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedIndex = 3;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedIndex = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 cerrarsecion = new Form3();
            cerrarsecion.ShowDialog();
        }

        private void Form2Copia_Load(object sender, EventArgs e)
        {
            object imagen1 = Image.FromFile(@"C:\Users\jjuli\OneDrive\Documentos\6 SEMESTRE\4.- INGENIERÍA DE SOFTWARE\U2.- Diseño\Imagenes\Avatar2.jpg");
            object imagen2 = Image.FromFile(@"C:\Users\jjuli\OneDrive\Documentos\6 SEMESTRE\4.- INGENIERÍA DE SOFTWARE\U2.- Diseño\Imagenes\Cars3.jpg");
            dataGridView2.AutoSizeRowsMode= DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView2.Rows.Add(imagen1, "AVATAR 2", "B", "120 MINUTOS", "3", "LUNES 27 DE FEBRERO DEL 2023");
            dataGridView2.Rows.Add(imagen2, "CARS 3", "AA", "90 MINUTOS", "3", "LUNES 27 DE FEBRERO");
            

            DataGridViewButtonColumn btnclm = new DataGridViewButtonColumn();

            DataGridViewComboBoxColumn comboBoxCell1 = new DataGridViewComboBoxColumn();
            ComboBox comboBoxCell2 = new ComboBox();

           
            //btnclm.HeaderText = "Button";
            //btnclm.Name = "Column11";
            //btnclm.Text = "CONTINUAR";
            //btnclm.UseColumnTextForButtonValue = true;
            //dataGridView2.Columns.Add(btnclm);

            comboBoxCell1.Items.Add("11:00 - 13:00");
            comboBoxCell1.Items.Add("14:00 - 16:00");
            comboBoxCell1.Items.Add("18:00 - 20:00");

            comboBoxCell2.Name = "Combo2";
            comboBoxCell2.Items.Add("hia");
            comboBoxCell2.Items.Add("hia");
            comboBoxCell2.Items.Add("hia");

            

            //for(int i = 0; i < 2; i++)
            //{
            //    dataGridView2.Columns.Add(dataGridView2.Controls.Add(comboBoxCell1));
            //}
            

            //dataGridView2.Rows.Add(imagen1, "AVATAR 2", "B","120 MINUTOS", "1", "LUNES 27 DE FEBRERO DEL 2023");

            //dataGridView2.Rows.Add(imagen2, "CARS 3","AA","90 MINUTOS","3","LUNES 27 DE FEBRERO");
        }

        #region NoSirven
        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //switch (this.dataGridView2.Columns[e.ColumnIndex].Name)
            //{
            //    case "Imagen":
            //        if(e.Value != null)
            //        {
            //            try
            //            {
            //                e.Value = Image.FromFile(e.Value.ToString());
            //            }
            //            catch (System.IO.FileNotFoundException exc)
            //            {
            //                e.Value = null;
            //            }
            //        }
            //        break;
            //}
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (this.dataGridView2.Columns[e.ColumnIndex].Name == "Eliminar")
            //{
            //    tabControl2.SelectedIndex = 1;
            //}
        }

        private void dataGridView2_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //if(e.ColumnIndex >= 0 && this.dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex >= 0 )
            //{
            //    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

            //    DataGridViewButtonCell celBoton = this.dataGridView2.Rows[e.RowIndex].Cells["Eliminar"] as DataGridViewButtonCell;
            //    Image iconAtomico = new Image(Environment.CurrentDirectory + @"\\Continuar2.png");
            //    e.Graphics.DrawImage(iconAtomico, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

            //    this.dataGridView2.Rows[e.RowIndex].Height = iconAtomico.Height + 8;
            //    this.dataGridView2.Columns[e.ColumnIndex].Width = iconAtomico.Width + 8;

            //    e.Handled = true;
            //}
        }
        #endregion

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 7 && e.RowIndex==0)
            {
                tabControl2.SelectedIndex = 1;
                pictureBox18.Image = Image.FromFile(@"C:\Users\jjuli\OneDrive\Documentos\6 SEMESTRE\4.- INGENIERÍA DE SOFTWARE\U2.- Diseño\Imagenes\Avatar2.jpg");
                label42.Text = string.Format("Titulo: Avatar 2");
                label43.Text = string.Format("Clasificación: B");
                label44.Text = string.Format("Duración: 120 minutos");
                pictureBox25.Image = Image.FromFile(@"C:\Users\jjuli\OneDrive\Documentos\6 SEMESTRE\4.- INGENIERÍA DE SOFTWARE\U2.- Diseño\Imagenes\Avatar2.jpg");
                label64.Text = string.Format("Titulo: Avatar 2");
                label65.Text = string.Format("Calasificación: B");
                label66.Text = string.Format("Duración: 120 minutos");
            }
            if(e.ColumnIndex == 7 && e.RowIndex == 1)
            {
                tabControl2.SelectedIndex = 1;
                pictureBox18.Image = Image.FromFile(@"C:\Users\jjuli\OneDrive\Documentos\6 SEMESTRE\4.- INGENIERÍA DE SOFTWARE\U2.- Diseño\Imagenes\Cars3.jpg");
                label42.Text = string.Format("Titulo: Cars 3");
                label43.Text = string.Format("Clasificación: AA");
                label44.Text = string.Format("Duración: 90 minutos");
                pictureBox25.Image = Image.FromFile(@"C:\Users\jjuli\OneDrive\Documentos\6 SEMESTRE\4.- INGENIERÍA DE SOFTWARE\U2.- Diseño\Imagenes\Cars3.jpg");
                label64.Text = string.Format("Titulo: Cars 3");
                label65.Text = string.Format("Calasificación: AA");
                label66.Text = string.Format("Duración: 90 minutos");
            }
        }
    }
}
